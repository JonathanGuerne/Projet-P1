using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_p1
{
    public partial class Form1 : Form
    {
        Kinect kinect;

        Boolean VoitureConnection = true;
        int DetecObstacleAvant = 500;
        int DetecObstacleArriere = 500;
        int DetecObstacleDroite = 500;
        int DetecObstacleGauche = 500;
        int StatuVoiture = 0xC0;
        ColorMatrix cmx1 = new ColorMatrix();           // opacité
        ImageAttributes ia = new ImageAttributes();     // opacité
        Rectangle rectCapGauche = new Rectangle(170, 130, 80, 80);
        Rectangle rectCapDroit = new Rectangle(100, 130, 80, 80);
        Rectangle rectCapHaut = new Rectangle(170, 20, 80, 80);
        Rectangle rectCapBas = new Rectangle(100, 20, 80, 80);
        Rectangle rectCapVoiture = new Rectangle(133, 60, 80, 100);

        Rectangle rectVueAutre;
        Rectangle rectVitesse;

        double af = 0; // simulation
        double posX = 100; // simulation
        double posY = 100; // simulation

        int flagBG = 0;

        Point[] points = new Point[4];
        Point[] pointsH = new Point[4];

        Brush BRGrisFonce = new SolidBrush(Color.FromArgb(255, 64, 64, 64));
        Brush BRVertClaire = new SolidBrush(Color.FromArgb(255, 0, 192, 0));
        Brush BRJaunePetant = new SolidBrush(Color.FromArgb(255, 255, 255, 0));
        Brush BRRougePetant = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
        Brush BRRougeClair = new SolidBrush(Color.FromArgb(255, 255, 50, 50));
        Brush BRBleuTurquoise = new SolidBrush(Color.FromArgb(255, 0, 150, 255));
        Brush BROrangeTransparent = new SolidBrush(Color.FromArgb(100, 250, 150, 0));
        Brush BROrange = new SolidBrush(Color.FromArgb(255, 250, 150, 0));
        Brush BRBleuTransparent = new SolidBrush(Color.FromArgb(90, 0, 60, 250));
        Brush BRBleu = new SolidBrush(Color.FromArgb(255, 0, 60, 250));

        Boolean changeHaut = false;
        Boolean changeBas = false;
        Boolean changeClose = false;
        Boolean changeOpen = false;
        Boolean changeL = false;
        Boolean mouseDownYes = false;


        //-----------------ZIGBEE--------------------------------//
        //Code Ajouté le 24.08.2016 à 14:18
        ZigBee.OptionForm zigbeeSettings = new ZigBee.OptionForm();
        //-------------------------------------------------------//


        public Form1()
        {
            InitializeComponent();
            kinect = new Kinect();
            kinect.form = this;
            kinect.launch();
            timer1.Start();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            kinect.launch();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            kinect.Form1_FormClosing(sender, e);
        }

        private void panelVitesse_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            Graphics g = e.Graphics;
            //Brush brush;

            rectVitesse.X = 10;
            rectVitesse.Y = 0;
            rectVitesse.Height = p.Height;
            rectVitesse.Width = (p.Width / 2) - (2 * rectVitesse.X);

            Brush brush = BRGrisFonce;

            g.FillRectangle(brush, rectVitesse);


            rectVitesse.X += (p.Width / 2);

            brush = BRGrisFonce;

            g.FillRectangle(brush, rectVitesse);


            double facteur = 3.02;

            rectVitesse.X = 14;
            if (-(int)(kinect.getVGLisse() * facteur) > 0)
            {
                rectVitesse.Height = -(int)(kinect.getVGLisse() * facteur);
                rectVitesse.Y = p.Height / 2;
            }
            else
            {
                rectVitesse.Height = (int)(kinect.getVGLisse() * facteur);
                rectVitesse.Y = p.Height / 2 - rectVitesse.Height;
            }
            rectVitesse.Width = (p.Width / 2) - (2 * rectVitesse.X);

            if ((int)(Math.Abs(kinect.getVGLisse()) * 255) / 100 < 255 && (int)((-Math.Abs(kinect.getVGLisse()) * 255) / 100) + 255 < 255)
            {
                brush = new SolidBrush(Color.FromArgb(255, 0, (int)((-Math.Abs(kinect.getVGLisse()) * 255) / 200) + 255, (int)(Math.Abs(kinect.getVGLisse()) * 255) / 100));
            }
            else
            {
                brush = BRRougePetant;
            }

            g.FillRectangle(brush, rectVitesse);

            if (-(int)(kinect.getVDLisse() * facteur) > 0)
            {
                rectVitesse.Height = -(int)(kinect.getVDLisse() * facteur);
                rectVitesse.Y = p.Height / 2;
            }
            else
            {
                rectVitesse.Height = (int)(kinect.getVDLisse() * facteur);
                rectVitesse.Y = p.Height / 2 - rectVitesse.Height;
            }
            rectVitesse.X += p.Width / 2;
            if ((int)(Math.Abs(kinect.getVDLisse()) * 255) / 100 < 255 && (int)((-Math.Abs(kinect.getVDLisse()) * 255) / 100) + 255 < 255)
            {
                brush = new SolidBrush(Color.FromArgb(255, 0, (int)((-Math.Abs(kinect.getVDLisse()) * 255) / 200) + 255, (int)(Math.Abs(kinect.getVDLisse()) * 255) / 100));
            }
            else
            {
                brush = BRRougePetant;
            }

            g.FillRectangle(brush, rectVitesse);

            rectVitesse.X = 10;
            rectVitesse.Y = (p.Height / 2) - 2;
            rectVitesse.Height = 4;
            rectVitesse.Width = (p.Width / 2) - (2 * rectVitesse.X);

            brush = BRJaunePetant;

            g.FillRectangle(brush, rectVitesse);

            rectVitesse.X += p.Width / 2;

            brush = BRJaunePetant;

            g.FillRectangle(brush, rectVitesse);

            if (kinect.getVGLisse() != 0)
            {
                Console.WriteLine("Vgauche : " + kinect.getVGLisse());
            }
            if (kinect.getVDLisse() != 0)
            {
                Console.WriteLine("Vdroite : " + kinect.getVDLisse());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbVitesse.Refresh();
            pbox_VUE_Autres.Refresh();
            pbCapteurs.Refresh();
            pboxSIM.Refresh();

            //Envoie des données au modules zigbee
            zigbeeSettings.setVitesseRouesDroites((int)kinect.getVDLisse());
            zigbeeSettings.setVitesseRouesGauches((int)kinect.getVGLisse());
            zigbeeSettings.setBrasPinces((int)kinect.getPinceUpDown());
            zigbeeSettings.setOuverturePinces((int)kinect.getPinceOpenClose());
            DetecObstacleAvant = zigbeeSettings.getCapAvDroit();
            DetecObstacleArriere = zigbeeSettings.getCapAvGauche();
            DetecObstacleDroite = zigbeeSettings.getCapArrGauche();
            DetecObstacleGauche = zigbeeSettings.getCapArrDroite();
            StatuVoiture = zigbeeSettings.status();

        }

        private void panelKVueDessus_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y - 15 < 93 - (int)(kinect.getMargesPinceHaut() * 250))
            {
                changeHaut = true;
            }
            else
            {
                changeHaut = false;
            }
            if (e.Y + 15 > 93 - (int)(kinect.getMargesPinceBas() * 250))
            {
                changeBas = true;
            }
            else
            {
                changeBas = false;
            }
            if (e.X - 15 < 52 - (int)(kinect.getMargesPinceClose() * 250))
            {
                changeClose = true;
            }
            else
            {
                changeClose = false;
            }
            if (e.X + 15 > 52 - (int)(kinect.getMargesPinceOpen() * 250))
            {
                changeOpen = true;
            }
            else
            {
                changeOpen = false;
            }
            if (mouseDownYes == true)
            {
                if (changeHaut == true)
                {
                    kinect.setMargesPinceHaut((-e.Y + 93.0) / 250);
                }
                if (changeBas == true)
                {
                    kinect.setMargesPinceBas((-e.Y + 93.0) / 250);
                }
                if (changeClose == true)
                {
                    kinect.setMargesPinceClose((-e.X + 52.0) / 480);
                }
                if (changeOpen == true)
                {
                    kinect.setMargesPinceOpen((-e.X + 52.0) / 480);
                }
            }
        }

        private void panelKVueDessus_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownYes = true;
        }

        private void panelKVueDessus_MouseLeave(object sender, EventArgs e)
        {
            changeHaut = false;
            changeBas = false;
            changeOpen = false;
            changeClose = false;
            changeL = false;
        }

        private void panelKVueDessus_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownYes = false;
        }

        private void pbVueAutrePaint(object sender, PaintEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            Graphics g = e.Graphics;
            Brush brush;

            if (kinect.getHead().Z != 0 && kinect.getModePince() == false)
            {
                g.RotateTransform(180);
                g.TranslateTransform(-p.Width, -p.Height);
                if (flagBG == 1)
                {
                    p.BackgroundImage = projet_p1.Properties.Resources.BG1;
                    flagBG = 0;
                }

                rectVueAutre.X = 0;
                rectVueAutre.Y = (p.Height / 2) + (int)(-kinect.getHead().X * 100) - kinect.getLargeurConduite();
                rectVueAutre.Width = p.Width;
                rectVueAutre.Height = 2 * kinect.getLargeurConduite();

                //pointsH[0].X = 0;
                //pointsH[0].Y = (p.Height / 2) + (int)(-kinect.getHead().X * 100) + kinect.getLargeurConduite();
                //pointsH[1].X = 0;
                //pointsH[1].Y = (p.Height / 2) + (int)(-kinect.getHead().X * 100) - kinect.getLargeurConduite();
                //pointsH[2].X = p.Width;
                //pointsH[2].Y = (p.Height / 2) + (int)(-kinect.getHead().X * 100) - kinect.getLargeurConduite();
                //pointsH[3].X = p.Width;
                //pointsH[3].Y = (p.Height / 2) + (int)(-kinect.getHead().X * 100) + kinect.getLargeurConduite();


                brush = BROrangeTransparent;

                g.FillRectangle(brush, rectVueAutre);
                //g.FillPolygon(brush, pointsH);

                // tête
                rectVueAutre.Width = 30;
                rectVueAutre.Height = 30;
                rectVueAutre.X = (int)(kinect.getHead().Z * 100) - 15;
                rectVueAutre.Y = (p.Height / 2) + (int)(-kinect.getHead().X * 100) - 15;
                brush = BRBleuTurquoise;

                g.FillEllipse(brush, rectVueAutre);

                // main gauche
                rectVueAutre.Width = 20;
                rectVueAutre.Height = 20;
                rectVueAutre.X = (int)(kinect.getLHand().Z * 100) - 10;
                rectVueAutre.Y = (p.Height / 2) + (int)(-kinect.getLHand().X * 100) - 10;
                brush = BRRougeClair;

                g.FillEllipse(brush, rectVueAutre);

                // main gauche
                rectVueAutre.Width = 20;
                rectVueAutre.Height = 20;
                rectVueAutre.X = (int)(kinect.getRHand().Z * 100) - 10;
                rectVueAutre.Y = (p.Height / 2) + (int)(-kinect.getRHand().X * 100) - 10;

                g.FillEllipse(brush, rectVueAutre);




                if (changeL == true)
                {
                    rectVueAutre.X = 0;
                    rectVueAutre.Y = pbox_VUE_Autres.Height / 2 + (int)(-kinect.getHead().X * 100) - (int)(kinect.getLargeurConduite()) - 2;
                    rectVueAutre.Height = 4;
                    rectVueAutre.Width = p.Width;
                    brush = BROrange;
                    g.FillRectangle(brush, rectVueAutre);

                    rectVueAutre.X = 0;
                    rectVueAutre.Y = pbox_VUE_Autres.Height / 2 + (int)(-kinect.getHead().X * 100) + (int)(kinect.getLargeurConduite()) - 2;
                    rectVueAutre.Height = 4;
                    rectVueAutre.Width = p.Width;
                    g.FillRectangle(brush, rectVueAutre);
                }
                // ------------------- REFERENCES ---------------------
                if (kinect.getReferenceDroite() != 0)
                {
                    rectVueAutre.Width = 4;
                    rectVueAutre.Height = kinect.getLargeurConduite();
                    rectVueAutre.X = (int)(kinect.getReferenceDroite()) - 2;
                    rectVueAutre.Y = (p.Height / 2) + (int)(-kinect.getHead().X * 100) - (int)(kinect.getLargeurConduite());
                    //R.X = p.Width - R.X - R.Width;
                    g.FillRectangle(BRJaunePetant, rectVueAutre);
                }
                if (kinect.getReferenceGauche() != 0)
                {
                    rectVueAutre.Width = 4;
                    rectVueAutre.Height = kinect.getLargeurConduite();
                    rectVueAutre.X = (int)(kinect.getReferenceGauche()) - 2;
                    rectVueAutre.Y = (p.Height / 2) + (int)(-kinect.getHead().X * 100);
                    //R.X = p.Width - R.X - R.Width;
                    g.FillRectangle(BRJaunePetant, rectVueAutre);
                }
            }
            ///////////////////////////// MODE PINCE ///////////////////////////////
            else if (kinect.getModePince() == true)
            {
                if (flagBG == 0)
                {
                    p.BackgroundImage = projet_p1.Properties.Resources.BG2;
                    flagBG = 1;
                }
                rectVueAutre.Width = 20;
                rectVueAutre.Height = 20;
                rectVueAutre.X = (int)((kinect.getHead().Z - ((kinect.getRHand().Z + kinect.getLHand().Z) / 2)) * 480) + 42;
                rectVueAutre.Y = (int)((kinect.getHead().Y - ((kinect.getRHand().Y + kinect.getLHand().Y) / 2)) * 250) + 83;
                brush = BRRougeClair;

                g.FillEllipse(brush, rectVueAutre);

                // HAUT
                rectVueAutre.X = 0;
                rectVueAutre.Y = 0;
                rectVueAutre.Height = 93 - (int)(kinect.getMargesPinceHaut() * 250);
                rectVueAutre.Width = p.Width;
                brush = BROrangeTransparent;
                g.FillRectangle(brush, rectVueAutre);

                // BAS
                rectVueAutre.X = 0;
                rectVueAutre.Y = 93 - (int)(kinect.getMargesPinceBas() * 250);
                rectVueAutre.Height = p.Height - (93 - (int)(kinect.getMargesPinceBas() * 250));
                rectVueAutre.Width = p.Width;
                g.FillRectangle(brush, rectVueAutre);

                // CLOSE
                rectVueAutre.X = 0;
                rectVueAutre.Y = 0;
                rectVueAutre.Height = p.Height;
                rectVueAutre.Width = 52 - (int)(kinect.getMargesPinceClose() * 480);
                brush = BRBleuTransparent;
                g.FillRectangle(brush, rectVueAutre);

                // CLOSE
                rectVueAutre.X = 52 - (int)(kinect.getMargesPinceOpen() * 480);
                rectVueAutre.Y = 0;
                rectVueAutre.Height = p.Height;
                rectVueAutre.Width = p.Width - (52 - (int)(kinect.getMargesPinceOpen() * 480));
                g.FillRectangle(brush, rectVueAutre);

                if (changeHaut == true)
                {
                    rectVueAutre.X = 0;
                    rectVueAutre.Y = 91 - (int)(kinect.getMargesPinceHaut() * 250);
                    rectVueAutre.Height = 4;
                    rectVueAutre.Width = p.Width;
                    brush = BROrange;
                    g.FillRectangle(brush, rectVueAutre);
                }
                if (changeBas == true)
                {
                    rectVueAutre.X = 0;
                    rectVueAutre.Y = 91 - (int)(kinect.getMargesPinceBas() * 250);
                    rectVueAutre.Height = 4;
                    rectVueAutre.Width = p.Width;
                    brush = BROrange;
                    g.FillRectangle(brush, rectVueAutre);
                }
                if (changeClose == true)
                {

                    rectVueAutre.X = 50 - (int)(kinect.getMargesPinceClose() * 480);
                    rectVueAutre.Y = 0;
                    rectVueAutre.Height = p.Height;
                    rectVueAutre.Width = 4;
                    brush = BRBleu;
                    g.FillRectangle(brush, rectVueAutre);
                }
                if (changeOpen == true)
                {

                    rectVueAutre.X = 50 - (int)(kinect.getMargesPinceOpen() * 480);
                    rectVueAutre.Y = 0;
                    rectVueAutre.Height = p.Height;
                    rectVueAutre.Width = 4;
                    brush = BRBleu;
                    g.FillRectangle(brush, rectVueAutre);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (kinect.getModePince() == true)
            {
                if (e.Y - 15 < 93 - (int)(kinect.getMargesPinceHaut() * 250))
                {
                    changeHaut = true;
                }
                else
                {
                    changeHaut = false;
                }
                if (e.Y + 15 > 93 - (int)(kinect.getMargesPinceBas() * 250))
                {
                    changeBas = true;
                }
                else
                {
                    changeBas = false;
                }
                if (e.X - 15 < 52 - (int)(kinect.getMargesPinceClose() * 480))
                {
                    changeClose = true;
                }
                else
                {
                    changeClose = false;
                }
                if (e.X + 15 > 52 - (int)(kinect.getMargesPinceOpen() * 480))
                {
                    changeOpen = true;
                }
                else
                {
                    changeOpen = false;
                }
                if (mouseDownYes == true)
                {
                    if (changeHaut == true)
                    {
                        kinect.setMargesPinceHaut((-e.Y + 93.0) / 250);
                    }
                    if (changeBas == true)
                    {
                        kinect.setMargesPinceBas((-e.Y + 93.0) / 250);
                    }
                    if (changeClose == true)
                    {
                        kinect.setMargesPinceClose((-e.X + 52.0) / 480);
                    }
                    if (changeOpen == true)
                    {
                        kinect.setMargesPinceOpen((-e.X + 52.0) / 480);
                    }
                }
            }
            else
            {
                if (e.Y + 12 > pbox_VUE_Autres.Height / 2 - (int)(kinect.getHead().X * 100) - (int)(kinect.getLargeurConduite()) && e.Y - 12 < pbox_VUE_Autres.Height / 2 - (int)(kinect.getHead().X * 100) + (int)(kinect.getLargeurConduite()))
                {
                    changeL = true;
                }
                else
                {
                    changeL = false;
                }
                if (mouseDownYes == true)
                {
                    if (changeL == true)
                    {
                        kinect.setLargeurConduite(Math.Abs((e.Y - pbox_VUE_Autres.Height / 2) + (int)(kinect.getHead().X * 100)));
                    }
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownYes = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownYes = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            changeHaut = false;
            changeBas = false;
            changeOpen = false;
            changeClose = false;
            changeL = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pbVitesse.Height = this.ClientSize.Height - 20;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        /// SIMULATION /// SIMULATION /// SIMULATION /// SIMULATION /// SIMULATION !!!!!
        /// /// SIMULATION /// SIMULATION /// SIMULATION /// SIMULATION /// SIMULATION !!!!!
        /// /// SIMULATION /// SIMULATION /// SIMULATION /// SIMULATION /// SIMULATION !!!!!
        /// /// SIMULATION /// SIMULATION /// SIMULATION /// SIMULATION /// SIMULATION !!!!!
        private void cbxModeSimluation_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxModeSimluation.Checked == true)
            {
                Width += 800;
                pboxSIM.Visible = true;
                pbCapteurs.Visible = false;
                lblSTAT1.Visible = false;
                lblSTAT2.Visible = false;
                lblSTAT3.Visible = false;
                lblSTAT4.Visible = false;
                lblSTAT5.Visible = false;
                lblSTAT6.Visible = false;
                lblSTAT7.Visible = false;
                lblSTAT8.Visible = false;
            }
            else
            {
                Width = 1075;
                pbCapteurs.Visible = true;
                pboxSIM.Visible = false;
                lblSTAT1.Visible = true;
                lblSTAT2.Visible = true;
                lblSTAT3.Visible = true;
                lblSTAT4.Visible = true;
                lblSTAT5.Visible = true;
                lblSTAT6.Visible = true;
                lblSTAT7.Visible = true;
                lblSTAT8.Visible = true;
            }
        }
        public static Bitmap RotateImage(Bitmap b, float angle, Graphics g)
        {
            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //make a graphics object from the empty bitmap
            using (g = Graphics.FromImage(returnBitmap))
            {
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
            }
            return returnBitmap;
        }

        private void pboxSIM_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Graphics g = e.Graphics;
            double a = (kinect.getVGLisse() - kinect.getVDLisse()) * 0.05;

            double v = (kinect.getVDLisse() + kinect.getVGLisse()) / 1;

            af += a;

            double cos = Math.Cos((Math.PI / 180) * af);
            double sin = Math.Sin((Math.PI / 180) * af);

            double Vx = cos * v * 0.1;
            double Vy = sin * v * 0.1;

            posX += Vx;
            posY += Vy;

            if (posX < -30) posX = -30;
            if (posY < -30) posY = -30;
            if (posX > 558) posX = 558;
            if (posY > 502) posY = 502;

            //Load an image in from a file
            Image tank;

            tank = RotateImage(new Bitmap(Properties.Resources.TANK), (float)af - 180, g);

            try
            {
                g.Clear(Color.White);
            }
            catch (System.NullReferenceException e1)
            { }

            //g.TranslateTransform((float));
            try
            {
                g.DrawImage(tank, new Point((int)posX, (int)posY));
            }
            catch (System.NullReferenceException e1) { }
        }

        private void pbCapteurs_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            Graphics g = e.Graphics;
            Brush brush;
            Rectangle R1 = new Rectangle();

            if (VoitureConnection == true)
            {
                // -- capteur gauche --
                // --------------------
                Image IMGcap;
                if (DetecObstacleGauche > 400)
                {

                    IMGcap = Properties.Resources.capG0;
                    g.DrawImage(IMGcap, rectCapGauche);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleGauche - 400) / 100.0);
                    IMGcap = Properties.Resources.capG1;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapGauche, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleGauche > 300 && DetecObstacleGauche < 400)
                {
                    IMGcap = Properties.Resources.capG1;
                    g.DrawImage(IMGcap, rectCapGauche);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleGauche - 300) / 100.0);
                    IMGcap = Properties.Resources.capG2;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapGauche, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleGauche > 200 && DetecObstacleGauche < 300)
                {
                    IMGcap = Properties.Resources.capG2;
                    g.DrawImage(IMGcap, rectCapGauche);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleGauche - 200) / 100.0);
                    IMGcap = Properties.Resources.capG3;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapGauche, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleGauche > 100 && DetecObstacleGauche < 200)
                {
                    IMGcap = Properties.Resources.capG3;
                    g.DrawImage(IMGcap, rectCapGauche);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleGauche - 100) / 100.0);
                    IMGcap = Properties.Resources.capG4;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapGauche, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else
                {
                    IMGcap = Properties.Resources.capGR;
                    g.DrawImage(IMGcap, rectCapGauche);
                }
                // -- capteur droite --
                // --------------------
                if (DetecObstacleDroite > 400)
                {

                    IMGcap = Properties.Resources.capD0;
                    g.DrawImage(IMGcap, rectCapDroit);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleDroite - 400) / 100.0);
                    IMGcap = Properties.Resources.capD1;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapDroit, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleDroite > 300 && DetecObstacleDroite < 400)
                {
                    IMGcap = Properties.Resources.capD1;
                    g.DrawImage(IMGcap, rectCapDroit);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleDroite - 300) / 100.0);
                    IMGcap = Properties.Resources.capD2;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapDroit, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleDroite > 200 && DetecObstacleDroite < 300)
                {
                    IMGcap = Properties.Resources.capD2;
                    g.DrawImage(IMGcap, rectCapDroit);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleDroite - 200) / 100.0);
                    IMGcap = Properties.Resources.capD3;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapDroit, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleDroite > 100 && DetecObstacleDroite < 200)
                {
                    IMGcap = Properties.Resources.capD3;
                    g.DrawImage(IMGcap, rectCapDroit);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleDroite - 100) / 100.0);
                    IMGcap = Properties.Resources.capD4;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapDroit, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else
                {
                    IMGcap = Properties.Resources.capDR;
                    g.DrawImage(IMGcap, rectCapDroit);
                }
                // -- capteur avant --
                // --------------------
                if (DetecObstacleAvant > 400)
                {

                    IMGcap = Properties.Resources.capH0;
                    g.DrawImage(IMGcap, rectCapHaut);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleAvant - 400) / 100.0);
                    IMGcap = Properties.Resources.capH1;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapHaut, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleAvant > 300 && DetecObstacleAvant < 400)
                {
                    IMGcap = Properties.Resources.capH1;
                    g.DrawImage(IMGcap, rectCapHaut);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleAvant - 300) / 100.0);
                    IMGcap = Properties.Resources.capH2;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapHaut, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleAvant > 200 && DetecObstacleAvant < 300)
                {
                    IMGcap = Properties.Resources.capH2;
                    g.DrawImage(IMGcap, rectCapHaut);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleAvant - 200) / 100.0);
                    IMGcap = Properties.Resources.capH3;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapHaut, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleAvant > 100 && DetecObstacleAvant < 200)
                {
                    IMGcap = Properties.Resources.capH3;
                    g.DrawImage(IMGcap, rectCapHaut);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleAvant - 100) / 100.0);
                    IMGcap = Properties.Resources.capH4;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapHaut, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else
                {
                    IMGcap = Properties.Resources.capHR;
                    g.DrawImage(IMGcap, rectCapHaut);
                }
                // -- capteur arriere --
                // ---------------------
                if (DetecObstacleArriere > 400)
                {

                    IMGcap = Properties.Resources.capB0;
                    g.DrawImage(IMGcap, rectCapBas);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleArriere - 400) / 100.0);
                    IMGcap = Properties.Resources.capB1;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapBas, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleArriere > 300 && DetecObstacleArriere < 400)
                {
                    IMGcap = Properties.Resources.capB1;
                    g.DrawImage(IMGcap, rectCapBas);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleArriere - 300) / 100.0);
                    IMGcap = Properties.Resources.capB2;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapBas, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleArriere > 200 && DetecObstacleArriere < 300)
                {
                    IMGcap = Properties.Resources.capB2;
                    g.DrawImage(IMGcap, rectCapBas);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleArriere - 200) / 100.0);
                    IMGcap = Properties.Resources.capB3;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapBas, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else if (DetecObstacleArriere > 100 && DetecObstacleArriere < 200)
                {
                    IMGcap = Properties.Resources.capB3;
                    g.DrawImage(IMGcap, rectCapBas);

                    cmx1.Matrix33 = (float)(1 - (DetecObstacleArriere - 100) / 100.0);
                    IMGcap = Properties.Resources.capB4;


                    ia.SetColorMatrix(cmx1, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(IMGcap, rectCapBas, 0, 0, IMGcap.Width, IMGcap.Height, GraphicsUnit.Pixel, ia);
                }
                else
                {
                    IMGcap = Properties.Resources.capBR;
                    g.DrawImage(IMGcap, rectCapBas);
                }
                Image Voiture;
                Voiture = Properties.Resources.voiture;
                g.DrawImage(Voiture, rectCapVoiture);
            }
            // EXTRACTION DES BITS DE LA DONNEE POUR AFFICHER LES VUS
            int E = StatuVoiture;
            Image IMGvu;
            if (E % 2 == 1)
            {
                IMGvu = Properties.Resources.nonVu;
                E -= 1;
            }
            else
            {
                IMGvu = Properties.Resources.Vu;
            }
            g.DrawImageUnscaled(IMGvu, new Point(100, 300));
            if (E % 4 == 2)
            {
                IMGvu = Properties.Resources.nonVu;
                E -= 2;
            }
            else
            {
                IMGvu = Properties.Resources.Vu;
            }
            g.DrawImageUnscaled(IMGvu, new Point(100, 325));
            if (E % 8 == 4)
            {
                IMGvu = Properties.Resources.nonVu;
                E -= 4;
            }
            else
            {
                IMGvu = Properties.Resources.Vu;
            }
            g.DrawImageUnscaled(IMGvu, new Point(100, 350));
            if (E % 16 == 8)
            {
                IMGvu = Properties.Resources.nonVu;
                E -= 8;
            }
            else
            {
                IMGvu = Properties.Resources.Vu;
            }
            g.DrawImageUnscaled(IMGvu, new Point(100, 375));
            if (E % 32 == 16)
            {
                IMGvu = Properties.Resources.nonVu;
                E -= 16;
            }
            else
            {
                IMGvu = Properties.Resources.Vu;
            }
            g.DrawImageUnscaled(IMGvu, new Point(100, 400));
            if (E % 64 == 32)
            {
                IMGvu = Properties.Resources.nonVu;
                E -= 32;
            }
            else
            {
                IMGvu = Properties.Resources.Vu;
            }
            g.DrawImageUnscaled(IMGvu, new Point(100, 425));
            if (E % 128 == 64)
            {
                IMGvu = Properties.Resources.nonVu;
                E -= 64;
            }
            else
            {
                IMGvu = Properties.Resources.Vu;
            }
            g.DrawImageUnscaled(IMGvu, new Point(100, 450));
            if (E % 256 == 128)
            {
                IMGvu = Properties.Resources.nonVu;
                E -= 128;
            }
            else
            {
                IMGvu = Properties.Resources.Vu;
            }
            g.DrawImageUnscaled(IMGvu, new Point(100, 475));
        }

        private void pbVitesse_Click(object sender, EventArgs e)
        {

        }

        private void btnSettingsZigBEE_Click(object sender, EventArgs e)
        {
            zigbeeSettings.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            zigbeeSettings.startTrans();
        }
    }
}
