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

        Color GrisFonce = Color.FromArgb(255, 64, 64, 64);
        Color clair = Color.FromArgb(255, 0, 192, 0);
        Color jaune = Color.FromArgb(255, 255, 255, 0);

        public Form1()
        {
            InitializeComponent();
            kinect = new Kinect();
            kinect.form = this;
            kinect.launch();
            timer1.Start();
            
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

        private void panelVitesse_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            Graphics g = e.Graphics;



            Point[] points = new Point[4];

            points[0] = new Point(10, 0);
            points[1] = new Point(10, p.Height);
            points[2] = new Point((p.Width / 2) - 10, p.Height);
            points[3] = new Point((p.Width / 2) - 10, 0);

            Brush brush = new SolidBrush(GrisFonce);

            g.FillPolygon(brush, points);

            points[0] = new Point((p.Width / 2) + 10, 0);
            points[1] = new Point((p.Width / 2) + 10, p.Height);
            points[2] = new Point((p.Width) - 10, p.Height);
            points[3] = new Point((p.Width) - 10, 0);

            brush = new SolidBrush(GrisFonce);

            g.FillPolygon(brush, points);


            double facteur = 8;//p.Height / 20;
            
            points[0] = new Point(14, p.Height / 2);
            points[1] = new Point(14, (int)((p.Height / 2) - (kinect.getVGauche() * facteur)));
            points[2] = new Point((p.Width / 2) - 14, (int)((p.Height / 2) - (kinect.getVGauche() * facteur)));
            points[3] = new Point((p.Width / 2) - 14, p.Height / 2);

            brush = new SolidBrush(Color.FromArgb(255, (int)(Math.Abs(kinect.getVGauche()) * 255) / 50, (int)((-Math.Abs(kinect.getVGauche()) * 255) / 50) + 255, 0));

            g.FillPolygon(brush, points);

            points[0] = new Point((p.Width / 2) + 14, p.Height / 2);
            points[1] = new Point((p.Width / 2) + 14, (int)((p.Height / 2) - (kinect.getVDroite() * facteur)));
            points[2] = new Point(p.Width - 14, (int)((p.Height / 2) - (kinect.getVDroite() * facteur)));
            points[3] = new Point(p.Width - 14, p.Height / 2);

            brush = new SolidBrush(Color.FromArgb(255,(int)(Math.Abs(kinect.getVDroite())*255)/50, (int)((-Math.Abs(kinect.getVDroite()) * 255) / 50)+255,0));

            g.FillPolygon(brush, points);

            points[0] = new Point(10, (p.Height / 2) - 2);
            points[1] = new Point(10, (p.Height / 2) + 2);
            points[2] = new Point((p.Width / 2) - 10, (p.Height / 2) + 2);
            points[3] = new Point((p.Width / 2) - 10, (p.Height / 2) - 2);

            brush = new SolidBrush(jaune);

            g.FillPolygon(brush, points);

            points[0] = new Point((p.Width / 2) + 10, (p.Height / 2) - 2);
            points[1] = new Point((p.Width / 2) + 10, (p.Height / 2) + 2);
            points[2] = new Point(p.Width - 10, (p.Height / 2) + 2);
            points[3] = new Point(p.Width - 10, (p.Height / 2) - 2);

            brush = new SolidBrush(jaune);

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
        }
    }
}
