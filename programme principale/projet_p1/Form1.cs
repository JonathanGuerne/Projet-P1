using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_p1
{
    public partial class Form1 : Form
    {
        Kinect kinect;
        

        public Form1()
        {
            InitializeComponent();
            kinect = new Kinect();
            kinect.form = this;
            kinect.launch();

            
        }



        public Button getBtnD()
        {
            return this.btnD;
        }

        public Button getBtnG()
        {
            return this.btnG;
        }


        private void refreshBTN(Button Btn, int T) //rafraichit la taille des "bouttons" oui, désolé ce sont des buttons qui indiquent la vitesse ... ><
        {
            kinect.refreshBTN(Btn,T);

        }
        private void refreshBTN2(Button Btn, int T) // idem mais avec des nombres positifs et négatifs (2ème sorte de bouttons)
        {
            kinect.refreshBTN2(Btn, T);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kinect.launch();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            kinect.Form1_FormClosing(sender, e);
        }

        private void btnD_Click(object sender, EventArgs e)
        {

        }
    }
}
