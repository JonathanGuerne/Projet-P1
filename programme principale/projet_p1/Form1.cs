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
        Rectangle R;
        int flagBG = 0;
        Point[] points = new Point[4];
        Point[] pointsH = new Point[4];
        //Color BRGrisFonce = 
        //Color BRvertclaire = Color.FromArgb(255, 0, 192, 0);
        //Color BRJaunePetant = Color.FromArgb(255, 255, 255, 0);
        Brush BRGrisFonce = new SolidBrush(Color.FromArgb(255, 64, 64, 64));
        Brush BRVertClaire = new SolidBrush(Color.FromArgb(255, 0, 192, 0));
        Brush BRJaunePetant = new SolidBrush(Color.FromArgb(255, 255, 255, 0));
        Brush BRRougePetant = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
        Brush BRRougeClair = new SolidBrush(Color.FromArgb(255, 255, 50, 50));
        Brush BRBleuTurquoise = new SolidBrush(Color.FromArgb(255, 0, 150, 255));
        Brush BROrangeTransparent = new SolidBrush(Color.FromArgb(50, 250, 125, 0));
        Brush BROrange = new SolidBrush(Color.FromArgb(255, 250, 125, 0));
        Brush BRBleuTransparent = new SolidBrush(Color.FromArgb(50, 0, 50, 250));
        Brush BRBleu = new SolidBrush(Color.FromArgb(255, 0, 50, 250));
        Boolean changeH = false;
        Boolean changeB = false;
        Boolean changeC = false;
        Boolean changeO = false;
        Boolean changeL = false;
        Boolean mouseDownYes = false;


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

        private void btnD_Click(object sender, EventArgs e)
        {

        }

        private void panelVitesse_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            Graphics g = e.Graphics;
            //Brush brush;
            
            points[0].X = 10;
            points[0].Y = 0;
            points[1].X = 10;
            points[1].Y = p.Height;
            points[2].X = (p.Width / 2) - 10;
            points[2].Y = p.Height;
            points[3].X = (p.Width / 2) - 10;
            points[3].Y = 0;

            Brush brush = BRGrisFonce;

            g.FillPolygon(brush, points);

            points[0].X = (p.Width / 2) + 10;
            points[0].Y = 0;
            points[1].X = (p.Width / 2) + 10;
            points[1].Y =  p.Height;
            points[2].X = (p.Width) - 10;
            points[2].Y = p.Height;
            points[3].X = (p.Width) - 10;
            points[3].Y = 0;

            brush = BRGrisFonce;

            g.FillPolygon(brush, points);


            double facteur = 7;//p.Height / 20;
            
            points[0].X = 14;
            points[0].Y = p.Height / 2;
            points[1].X = 14;
            points[1].Y = (int)((p.Height / 2) - (kinect.getVGauche() * facteur));
            points[2].X = (p.Width / 2) - 14;
            points[2].Y = (int)((p.Height / 2) - (kinect.getVGauche() * facteur));
            points[3].X = (p.Width / 2) - 14;
            points[3].Y = p.Height / 2;
            if ((int)(Math.Abs(kinect.getVGauche()) * 255) / 50 < 255 && (int)((-Math.Abs(kinect.getVGauche()) * 255) / 50) + 255 < 255)
            {
                brush = new SolidBrush(Color.FromArgb(255, 0, (int)((-Math.Abs(kinect.getVGauche()) * 255) / 100) + 255, (int)(Math.Abs(kinect.getVGauche()) * 255) / 50));
            }
            else
            {
                brush = BRRougePetant;
            }
            
            //brush = new SolidBrush(Color.FromArgb(255, 0, 100, 0));
            g.FillPolygon(brush, points);

            points[0].X = (p.Width / 2) + 14;
            points[0].Y = p.Height / 2;
            points[1].X = (p.Width / 2) + 14;
            points[1].Y = (int)((p.Height / 2) - (kinect.getVDroite() * facteur));
            points[2].X = p.Width - 14;
            points[2].Y = (int)((p.Height / 2) - (kinect.getVDroite() * facteur));
            points[3].X = p.Width - 14;
            points[3].Y = p.Height / 2;
            if ((int)(Math.Abs(kinect.getVDroite()) * 255) / 50<255 && (int)((-Math.Abs(kinect.getVDroite()) * 255) / 50) + 255<255)
            {
                brush = new SolidBrush(Color.FromArgb(255, 0, (int)((-Math.Abs(kinect.getVDroite()) * 255) / 100) + 255, (int)(Math.Abs(kinect.getVDroite()) * 255) / 50));
            }
            else
            {
                brush = BRRougePetant;
            }
            
            
            //brush = new SolidBrush(Color.FromArgb(255, 0, 100, 0));
            g.FillPolygon(brush, points);

            points[0].X = 10;
            points[0].Y = (p.Height / 2) - 2;
            points[1].X = 10;
            points[1].Y = (p.Height / 2) + 2;
            points[2].X = (p.Width / 2) - 10;
            points[2].Y = (p.Height / 2) + 2;
            points[3].X = (p.Width / 2) - 10;
            points[3].Y = (p.Height / 2) - 2;

            brush = BRJaunePetant;

            g.FillPolygon(brush, points);

            points[0].X = (p.Width / 2) + 10;
            points[0].Y = (p.Height / 2) - 2;
            points[1].X = (p.Width / 2) + 10;
            points[1].Y = (p.Height / 2) + 2;
            points[2].X = p.Width - 10;
            points[2].Y = (p.Height / 2) + 2;
            points[3].X = p.Width - 10;
            points[3].Y = (p.Height / 2) - 2;

            brush = BRJaunePetant;

            g.FillPolygon(brush, points);

            if(kinect.getVGauche() != 0)
            {
                Console.WriteLine("Vgauche : " + kinect.getVGauche());
            }
            if (kinect.getVDroite() != 0)
            {
                Console.WriteLine("Vdroite : " + kinect.getVDroite());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelVitesse.Refresh();
            panelKVueDessus.Refresh();
            pbox_VUE_Autres.Refresh();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void panelKVueDessus_Paint(object sender, PaintEventArgs e)
        {
            /*Panel p = sender as Panel;
            Graphics g = e.Graphics;
            Brush brush;
            
            if (kinect.getHead().Z != 0 && kinect.getModePince()==false)
            {
                if (flagBG == 1)
                {
                    p.BackgroundImage = projet_p1.Properties.Resources.BG1;
                    flagBG = 0;
                }
                pointsH[0].X = 0;
                pointsH[0].Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) + 30;
                pointsH[1].X = 0;
                pointsH[1].Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) - 30;
                pointsH[2].X = p.Width;
                pointsH[2].Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) - 30;
                pointsH[3].X = p.Width;
                pointsH[3].Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) + 30;


                brush = BROrangeTransparent;

                g.FillPolygon(brush, pointsH);

                // tête
                R.Width = 30;
                R.Height = 30;
                R.X = (int)(kinect.getHead().Z * 100) - 15;
                R.Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) - 15;
                //R = new Rectangle((int)(kinect.getHead().Z * 100), (p.Height/2)+(int)(kinect.getHead().X*100) ,40,40);
                brush = BRBleuTurquoise;

                g.FillEllipse(brush, R);

                // main gauche
                R.Width = 20;
                R.Height = 20;
                R.X = (int)(kinect.getLHand().Z * 100) - 10;
                R.Y = (p.Height / 2) + (int)(kinect.getLHand().X * 100) - 10;
                //R = new Rectangle((int)(kinect.getLHand().Z * 100), (p.Height / 2) + (int)(kinect.getLHand().X * 100), 30, 30);
                brush = BRRougeClair;

                g.FillEllipse(brush, R);

                // main gauche
                R.Width = 20;
                R.Height = 20;
                R.X = (int)(kinect.getRHand().Z * 100) - 10;
                R.Y = (p.Height / 2) + (int)(kinect.getRHand().X * 100) - 10;
                //R = new Rectangle((int)(kinect.getRHand().Z * 100), (p.Height / 2) + (int)(kinect.getRHand().X * 100), 30, 30);

                g.FillEllipse(brush, R);
            }
            else if(kinect.getModePince() == false)
            {
                if (flagBG == 0)
                {
                    p.BackgroundImage = projet_p1.Properties.Resources.BG2;
                    flagBG = 1;

                    
                }
                R.Width = 20;
                R.Height = 20;
                R.X = (int)(kinect.getHead().Z - kinect.getLHand().Z * 250) + 42;
                R.Y = (int)(kinect.getHead().Y - kinect.getLHand().Y * 250) + 133;
                //R = new Rectangle((int)(kinect.getLHand().Z * 100), (p.Height / 2) + (int)(kinect.getLHand().X * 100), 30, 30);
                brush = BRRougeClair;

                g.FillEllipse(brush, R);

                // HAUT
                R.X = 0;
                R.Y = 0;
                R.Height = 143 - (int)(kinect.getMargesPinceH()*250);
                R.Width = p.Width;
                brush = BROrangeTransparent;
                g.FillRectangle(brush, R);

                // BAS
                R.X = 0;
                R.Y = 143 - (int)(kinect.getMargesPinceB() * 250);
                R.Height = p.Height - (143 - (int)(kinect.getMargesPinceB() * 250));
                R.Width = p.Width;
                g.FillRectangle(brush, R);

                // CLOSE
                R.X = 0;
                R.Y = 0;
                R.Height = p.Height;
                R.Width = 52 - (int)(kinect.getMargesPinceC() * 250);
                brush = BRBleuTransparent;
                g.FillRectangle(brush, R);

                // CLOSE
                R.X = 52 - (int)(kinect.getMargesPinceO() * 250);
                R.Y = 0;
                R.Height = p.Height;
                R.Width = p.Width - (52 - (int)(kinect.getMargesPinceO() * 250));
                g.FillRectangle(brush, R);

                if (changeH == true)
                {
                    R.X = 0;
                    R.Y = 141 - (int)(kinect.getMargesPinceH() * 250);
                    R.Height = 4;
                    R.Width = p.Width;
                    brush = BROrange;
                    g.FillRectangle(brush, R);
                }
                if (changeB == true)
                {
                    R.X = 0;
                    R.Y = 141 - (int)(kinect.getMargesPinceB() * 250);
                    R.Height = 4;
                    R.Width = p.Width;
                    brush = BROrange;
                    g.FillRectangle(brush, R);
                }
                if (changeC == true)
                {

                    R.X = 50 - (int)(kinect.getMargesPinceC() * 250);
                    R.Y = 0;
                    R.Height = p.Height;
                    R.Width = 4;
                    brush = BRBleu;
                    g.FillRectangle(brush, R);
                }
                if (changeO == true)
                {
                    
                    R.X = 50 - (int)(kinect.getMargesPinceO() * 250);
                    R.Y = 0;
                    R.Height = p.Height;
                    R.Width = 4;
                    brush = BRBleu;
                    g.FillRectangle(brush, R);
                }
                
            }*/
        }

        private void panelKVueDessus_MouseHover(object sender, EventArgs e)
        {

        }

        private void panelKVueDessus_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y-15 < 143 - (int)(kinect.getMargesPinceH() * 250))
            {
                changeH = true;
            }
            else
            {
                changeH = false;
            }
            if (e.Y+15 > 143 - (int)(kinect.getMargesPinceB() * 250))
            {
                changeB = true;
            }
            else
            {
                changeB = false;
            }
            if (e.X-15 < 52 - (int)(kinect.getMargesPinceC() * 250))
            {
                changeC = true;
            }
            else
            {
                changeC = false;
            }
            if (e.X+15 > 52 - (int)(kinect.getMargesPinceO() * 250))
            {
                changeO = true;
            }
            else
            {
                changeO = false;
            }
            if (mouseDownYes == true)
            {
                if (changeH == true)
                {
                    kinect.setMargesPinceH((-e.Y + 143.0) / 250);
                    lblDROITE1.Text = "H : " + kinect.getMargesPinceH().ToString() ;
                }
                if (changeB == true)
                {
                    kinect.setMargesPinceB((-e.Y + 143.0) / 250);
                    lblDROITEref.Text = "B : " + kinect.getMargesPinceB().ToString();
                }
                if (changeC == true)
                {
                    kinect.setMargesPinceC((-e.X + 52.0) / 250);
                    lblDROITEv.Text = "C : " + kinect.getMargesPinceC().ToString();
                }
                if (changeO == true)
                {
                    kinect.setMargesPinceO((-e.X + 52.0) / 250);
                   lblDROITEx.Text  = "O : " + kinect.getMargesPinceO().ToString();
                }
            }
        }

        private void panelKVueDessus_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownYes = true;
        }

        private void panelKVueDessus_MouseLeave(object sender, EventArgs e)
        {
            changeH = false;
            changeB = false;
            changeO = false;
            changeC = false;
            changeL = false;
        }

        private void panelKVueDessus_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownYes = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            Graphics g = e.Graphics;
            Brush brush;

            if (kinect.getHead().Z != 0 && kinect.getModePince() == false)
            {
                if (flagBG == 1)
                {
                    p.BackgroundImage = projet_p1.Properties.Resources.BG1;
                    flagBG = 0;
                }
                pointsH[0].X = 0;
                pointsH[0].Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) + kinect.getLargeurConduite();
                pointsH[1].X = 0;
                pointsH[1].Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) - kinect.getLargeurConduite();
                pointsH[2].X = p.Width;
                pointsH[2].Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) - kinect.getLargeurConduite();
                pointsH[3].X = p.Width;
                pointsH[3].Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) + kinect.getLargeurConduite();


                brush = BROrangeTransparent;

                g.FillPolygon(brush, pointsH);

                // tête
                R.Width = 30;
                R.Height = 30;
                R.X = (int)(kinect.getHead().Z * 100) - 15;
                R.Y = (p.Height / 2) + (int)(kinect.getHead().X * 100) - 15;
                //R = new Rectangle((int)(kinect.getHead().Z * 100), (p.Height/2)+(int)(kinect.getHead().X*100) ,40,40);
                brush = BRBleuTurquoise;

                g.FillEllipse(brush, R);

                // main gauche
                R.Width = 20;
                R.Height = 20;
                R.X = (int)(kinect.getLHand().Z * 100) - 10;
                R.Y = (p.Height / 2) + (int)(kinect.getLHand().X * 100) - 10;
                //R = new Rectangle((int)(kinect.getLHand().Z * 100), (p.Height / 2) + (int)(kinect.getLHand().X * 100), 30, 30);
                brush = BRRougeClair;

                g.FillEllipse(brush, R);

                // main gauche
                R.Width = 20;
                R.Height = 20;
                R.X = (int)(kinect.getRHand().Z * 100) - 10;
                R.Y = (p.Height / 2) + (int)(kinect.getRHand().X * 100) - 10;
                //R = new Rectangle((int)(kinect.getRHand().Z * 100), (p.Height / 2) + (int)(kinect.getRHand().X * 100), 30, 30);

                g.FillEllipse(brush, R);

                if (changeL == true)
                {
                    R.X = 0;
                    R.Y = pbox_VUE_Autres.Height / 2 + (int)(kinect.getHead().X * 100) - (int)(kinect.getLargeurConduite()) -2;
                    R.Height = 4;
                    R.Width = p.Width;
                    brush = BROrange;
                    g.FillRectangle(brush, R);

                    R.X = 0;
                    R.Y = pbox_VUE_Autres.Height / 2 + (int)(kinect.getHead().X * 100) + (int)(kinect.getLargeurConduite()) -2;
                    R.Height = 4;
                    R.Width = p.Width;
                    g.FillRectangle(brush, R);
                }
            }
            else if (kinect.getModePince() == true)
            {
                if (flagBG == 0)
                {
                    p.BackgroundImage = projet_p1.Properties.Resources.BG2;
                    flagBG = 1;


                }
                R.Width = 20;
                R.Height = 20;
                R.X = (int)(kinect.getHead().Z - kinect.getLHand().Z * 250) + 42;
                R.Y = (int)(kinect.getHead().Y - kinect.getLHand().Y * 250) + 133;
                //R = new Rectangle((int)(kinect.getLHand().Z * 100), (p.Height / 2) + (int)(kinect.getLHand().X * 100), 30, 30);
                brush = BRRougeClair;

                g.FillEllipse(brush, R);

                // HAUT
                R.X = 0;
                R.Y = 0;
                R.Height = 143 - (int)(kinect.getMargesPinceH() * 250);
                R.Width = p.Width;
                brush = BROrangeTransparent;
                g.FillRectangle(brush, R);

                // BAS
                R.X = 0;
                R.Y = 143 - (int)(kinect.getMargesPinceB() * 250);
                R.Height = p.Height - (143 - (int)(kinect.getMargesPinceB() * 250));
                R.Width = p.Width;
                g.FillRectangle(brush, R);

                // CLOSE
                R.X = 0;
                R.Y = 0;
                R.Height = p.Height;
                R.Width = 52 - (int)(kinect.getMargesPinceC() * 250);
                brush = BRBleuTransparent;
                g.FillRectangle(brush, R);

                // CLOSE
                R.X = 52 - (int)(kinect.getMargesPinceO() * 250);
                R.Y = 0;
                R.Height = p.Height;
                R.Width = p.Width - (52 - (int)(kinect.getMargesPinceO() * 250));
                g.FillRectangle(brush, R);

                if (changeH == true)
                {
                    R.X = 0;
                    R.Y = 141 - (int)(kinect.getMargesPinceH() * 250);
                    R.Height = 4;
                    R.Width = p.Width;
                    brush = BROrange;
                    g.FillRectangle(brush, R);
                }
                if (changeB == true)
                {
                    R.X = 0;
                    R.Y = 141 - (int)(kinect.getMargesPinceB() * 250);
                    R.Height = 4;
                    R.Width = p.Width;
                    brush = BROrange;
                    g.FillRectangle(brush, R);
                }
                if (changeC == true)
                {

                    R.X = 50 - (int)(kinect.getMargesPinceC() * 250);
                    R.Y = 0;
                    R.Height = p.Height;
                    R.Width = 4;
                    brush = BRBleu;
                    g.FillRectangle(brush, R);
                }
                if (changeO == true)
                {

                    R.X = 50 - (int)(kinect.getMargesPinceO() * 250);
                    R.Y = 0;
                    R.Height = p.Height;
                    R.Width = 4;
                    brush = BRBleu;
                    g.FillRectangle(brush, R);
                }

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (kinect.getModePince() == true)
            {
                if (e.Y - 15 < 143 - (int)(kinect.getMargesPinceH() * 250))
                {
                    changeH = true;
                }
                else
                {
                    changeH = false;
                }
                if (e.Y + 15 > 143 - (int)(kinect.getMargesPinceB() * 250))
                {
                    changeB = true;
                }
                else
                {
                    changeB = false;
                }
                if (e.X - 15 < 52 - (int)(kinect.getMargesPinceC() * 250))
                {
                    changeC = true;
                }
                else
                {
                    changeC = false;
                }
                if (e.X + 15 > 52 - (int)(kinect.getMargesPinceO() * 250))
                {
                    changeO = true;
                }
                else
                {
                    changeO = false;
                }
                if (mouseDownYes == true)
                {
                    if (changeH == true)
                    {
                        kinect.setMargesPinceH((-e.Y + 143.0) / 250);
                        lblDROITE1.Text = "H : " + kinect.getMargesPinceH().ToString();
                    }
                    if (changeB == true)
                    {
                        kinect.setMargesPinceB((-e.Y + 143.0) / 250);
                        lblDROITEref.Text = "B : " + kinect.getMargesPinceB().ToString();
                    }
                    if (changeC == true)
                    {
                        kinect.setMargesPinceC((-e.X + 52.0) / 250);
                        lblDROITEv.Text = "C : " + kinect.getMargesPinceC().ToString();
                    }
                    if (changeO == true)
                    {
                        kinect.setMargesPinceO((-e.X + 52.0) / 250);
                        lblDROITEx.Text = "O : " + kinect.getMargesPinceO().ToString();
                    }
                }
            }
            else
            {
                if (e.Y + 12 > pbox_VUE_Autres.Height / 2 + (int)(kinect.getHead().X * 100) - (int)(kinect.getLargeurConduite()) && e.Y - 12 < pbox_VUE_Autres.Height / 2 + (int)(kinect.getHead().X * 100) + (int)(kinect.getLargeurConduite()))
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
                        kinect.setLargeurConduite(Math.Abs((e.Y - pbox_VUE_Autres.Height / 2) - (int)(kinect.getHead().X * 100)));
                        lblGAUCHEref.Text = "O : " + kinect.getLargeurConduite().ToString();
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
            changeH = false;
            changeB = false;
            changeO = false;
            changeC = false;
            changeL = false;
        }
    }
}
