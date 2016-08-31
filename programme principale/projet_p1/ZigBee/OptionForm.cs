using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZigBee
{
    public partial class OptionForm : Form
    {
        //Variables
        //Controle
        bool start = false;
        //Config
        private string MAC = "0013A20040A6E27F";
        private int BAUD = 115200;
        //Valeur a envoyer
        private Byte[] ByteSendData;
        private int vitesseRouesGauches = 0;
        private int vitesseRouesDroites = 0;
        private int brasPinces = 0;
        private int ouverturePinces = 0;
        //Valeur reçu
        private static string[] tabHex = {"00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "00", "FF"}; 


        public OptionForm()
        {
            InitializeComponent();
            scanPort();
            Timer.Start();

            //Insert les valeurs par default
            tB_MAC.Text = MAC;
            tB_BAUD.Text = BAUD.ToString();
        }

        //Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (start == true)
            {
                serialPortXBEE.BaudRate = BAUD;
                //Envoie continue
                makePacket();
                sendData();
            }
        }

        //Ouvre la fenetre de commande AT
        private void btn_atcmd_Click(object sender, EventArgs e)
        {
            DebugForm debug = new DebugForm();
            debug.Show(); 
        }

        //Change le port ouvert
        private void cmbCOMPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPortXBEE.IsOpen)
            {
                serialPortXBEE.Close();
            }

            if (!serialPortXBEE.IsOpen)
            {
                serialPortXBEE.PortName = cmbCOMPort.Text;

                if (serialPortXBEE.IsOpen)
                {
                    serialPortXBEE.Close();
                }

                //TO DO : Try catch 
                serialPortXBEE.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                serialPortXBEE.Open();
            }
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            byte[] dataHex = new byte[sp.BytesToRead];
            for (int i = 0; i < sp.BytesToRead; i++)
            {
                sp.Read(dataHex, 0, sp.BytesToRead);
            }

            string data = "";
            foreach (byte b in dataHex)
            {
                data += b.ToString("X2")+" ";//7E00058801415402DF
            }

            string[] tabHex_loc = data.Split(' ');
            if (tabHex_loc.Length == 28 && tabHex_loc[3].Equals("90",StringComparison.Ordinal))
            {
                tabHex = tabHex_loc;
            }            
        }

        //Ferme les fenetre
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            tB_MAC.Text = MAC;
            tB_BAUD.Text = BAUD.ToString();
            this.Hide();
        }

        //Ferme et enregistre
        private void btn_ok_Click(object sender, EventArgs e)
        {
            MAC = tB_MAC.Text;
            BAUD = int.Parse(tB_BAUD.Text);
            this.Hide();
        }

        //Crée les packets zigbee
        private Byte makePacket()
        {
            //-----------------------------------------------------------------------------//
            //Contruit le packet a envoyer
            byte hexRG;
            byte hexRD;
            byte mask = 0xFF;
            if (vitesseRouesDroites < 0)
            {                
                hexRD = Convert.ToByte(Math.Abs(vitesseRouesDroites));
                hexRD = (byte)(hexRD ^ mask);
                mask = 0x01;
                hexRD = (byte)(hexRD + mask);
            }
            else
            {
                hexRD = Convert.ToByte(vitesseRouesDroites);
            }

            if (vitesseRouesGauches < 0)
            {
                mask = 0xFF;
                hexRG = Convert.ToByte(Math.Abs(vitesseRouesGauches));
                hexRG = (byte)(hexRG ^ mask);
                mask = 0x01;
                hexRG = (byte)(hexRG + mask);
            }
            else
            {
                hexRG = Convert.ToByte(vitesseRouesGauches);
            }
            
            
            byte hexBras = Convert.ToByte(brasPinces);
            byte hexPince = Convert.ToByte(ouverturePinces);
            byte[] hex = { hexRG, hexRD, hexBras, hexPince, 0x81 };
            //-----------------------------------------------------------------------------//

            //Creat the byte array
            int size = hex.Length + 18;
            ByteSendData = new byte[size];

            //Set the start delimiter
            ByteSendData[0] = 0x7E;

            //Set the lenght
            ByteSendData[1] = 0x00;
            ByteSendData[2] = Convert.ToByte(14 + hex.Length);

            //Set Frame Type
            ByteSendData[3] = 0x10;

            //Set Frame ID
            ByteSendData[4] = 0x01;

            //Set Destination adress ------> TODO 
            // AF - 0013A20040A2C700
            //ByteSendData[5] = 0x00;
            //ByteSendData[6] = 0x13;
            //ByteSendData[7] = 0xA2;
            //ByteSendData[8] = 0x00;
            //ByteSendData[9] = 0x40;
            //ByteSendData[10] = 0xEC;
            //ByteSendData[11] = 0x4C;
            //ByteSendData[12] = 0x7B;
            //------------------------
            //ByteSendData[5] = 0x00;
            //ByteSendData[6] = 0x13;
            //ByteSendData[7] = 0xA2;
            //ByteSendData[8] = 0x00;
            //ByteSendData[9] = 0x40;
            //ByteSendData[10] = 0xA2;
            //ByteSendData[11] = 0xC7;
            //ByteSendData[12] = 0x00;
            //----------Robot
            //ByteSendData[5] = 0x00;
            //ByteSendData[6] = 0x13;
            //ByteSendData[7] = 0xA2;
            //ByteSendData[8] = 0x00;
            //ByteSendData[9] = 0x40;
            //ByteSendData[10] = 0xA6;
            //ByteSendData[11] = 0xE2;
            //ByteSendData[12] = 0x7F;

            //-----------------------------------------------------------------------------//
            //Adresse de destination
            long value = long.Parse(MAC, NumberStyles.HexNumber, CultureInfo.CurrentCulture.NumberFormat);
            byte[] macBytes = BitConverter.GetBytes(value);

            ByteSendData[5] = macBytes[7];
            ByteSendData[6] = macBytes[6];
            ByteSendData[7] = macBytes[5];
            ByteSendData[8] = macBytes[4];
            ByteSendData[9] = macBytes[3];
            ByteSendData[10] = macBytes[2];
            ByteSendData[11] = macBytes[1];
            ByteSendData[12] = macBytes[0];
            //-----------------------------------------------------------------------------//

            //Set destination network adress
            ByteSendData[13] = 0xFF;
            ByteSendData[14] = 0xFE;

            //Set broadcast radius
            ByteSendData[15] = 0x00;

            //Set option
            ByteSendData[16] = 0x00;

            for (int i = 0; i < hex.Length; i++)
            {
                ByteSendData[17 + i] = Convert.ToByte(hex[i]);
            }

            //Set CheckSum
            int sum = 0;
            for (int i = 3; i < ByteSendData.Length - 1; i++)
            {
                sum += ByteSendData[i];
            }

            sum = sum & 0xFF;

            ByteSendData[ByteSendData.Length - 1] = Convert.ToByte(0xFF - sum);

            return 0;
        }

        //Envoie en continue les données au robot
        private void sendData()
        {
            serialPortXBEE.Write(ByteSendData, 0, ByteSendData.Length);
        }

        //Récupère en continue les données reçu
        private void getData()
        {
            //Test si la buffer du serialport contient quelque chose
            if (serialPortXBEE.BytesToRead != 0)
            {
                SerialPort sp = serialPortXBEE;
                byte[] dataHex = new byte[sp.BytesToRead];
                for (int i = 0; i < sp.BytesToRead; i++)
                {
                        sp.Read(dataHex, 0, sp.BytesToRead);                    
                }

                string data = "";
                int compteurbyte = 0;
                foreach (byte b in dataHex)
                {
                    compteurbyte++;
                    data += b.ToString("X2");//7E00058801415402DF
                    if (compteurbyte%2 == 0)
                    {
                        data += " ";
                    }
                   
                }
                //Console.WriteLine(data);
                string[] tabHex_loc = data.Split(' ');
               if (tabHex_loc.Length >= 23 )
               {
                    tabHex = data.Split(' ');
                    foreach (string s in tabHex){
                    }
                    
              }               
            }
        }

        public int getCapAvDroit()
        {           
            string loc = tabHex[15] + tabHex[16];               

            int data = Convert.ToInt32(loc,16);

            return data;
        }

        public int getCapAvGauche()
        {
            string loc = tabHex[17] + tabHex[18];
            int data = Convert.ToInt32(loc,16);
            return data;
        }

        public int getCapArrDroite()
        {
            string loc = tabHex[19] + tabHex[20];
            int data = Convert.ToInt32(loc,16);
            return data;
        }

        public int getCapArrGauche()
        {
            string loc = tabHex[21] + tabHex[22];
            int data = Convert.ToInt32(loc,16);
            return data;
        }

        public int status()
        {
            string loc = tabHex[23];
            int data = Convert.ToInt32(loc,16);
            return data;
        }


        //---------------------------------------------------------------------------//
        //Ci-dessous les fonctions qui peuvent être appelées par le programme main

        /// <summary>
        /// Scan tous les port sériel disponible est ouvre le premier port trouvé
        /// </summary>
        public void scanPort()
        {
            cmbCOMPort.Items.Clear();

            foreach (string pn in SerialPort.GetPortNames())
            {
                cmbCOMPort.Items.Add(pn);
            }

            cmbCOMPort.SelectedItem = cmbCOMPort.Items[0];
        }

        /// <summary>
        /// Start transmision
        /// </summary>
        public void startTrans()
        {
            start = true;
        }

        /// <summary>
        /// Stop transmision
        /// </summary>
        public void stopTrand()
        {
            start = false;
        }

        /// <summary>
        /// Vitesse pour les roues droites à envoyer
        /// </summary>
        /// <param name="vrd"></param>
        public void setVitesseRouesDroites(int vrd)
        {
            vitesseRouesDroites = vrd;
        }

        /// <summary>
        ///  Vitesse pour les roues gauches à envoyer
        /// </summary>
        /// <param name="vrg"></param>
        public void setVitesseRouesGauches(int vrg)
        {
            vitesseRouesGauches = vrg;
        }

        /// <summary>
        /// Hauteur du bras
        /// </summary>
        /// <param name="bp"></param>
        public void setBrasPinces(int bp)
        {
            brasPinces = bp;
        }

        /// <summary>
        /// Ouverture de la pinces
        /// </summary>
        /// <param name="op"></param>
        public void setOuverturePinces(int op)
        {
            ouverturePinces = op;
        }
    }
}
