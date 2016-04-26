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
        Point[] points = new Point[4];
        Point[] pointsH = new Point[3];
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

            points[0].X = 10;
            points[0].Y = 0;
            points[1].X = 10;
            points[1].Y = p.Height;
            points[2].X = (p.Width / 2) - 10;
            points[2].Y = p.Height;
            points[3].X = (p.Width / 2) - 10;
            points[3].Y = 0;

            Brush brush = new SolidBrush(GrisFonce);

            g.FillPolygon(brush, points);

            points[0] = new Point((p.Width / 2) + 10, 0);
            points[1] = new Point((p.Width / 2) + 10, p.Height);
            points[2] = new Point((p.Width) - 10, p.Height);
            points[3] = new Point((p.Width) - 10, 0);

            brush = new SolidBrush(GrisFonce);

            g.FillPolygon(brush, points);


            double facteur = 7;//p.Height / 20;
            
            points[0] = new Point(14, p.Height / 2);
            points[1] = new Point(14, (int)((p.Height / 2) - (kinect.getVGauche() * facteur)));
            points[2] = new Point((p.Width / 2) - 14, (int)((p.Height / 2) - (kinect.getVGauche() * facteur)));
            points[3] = new Point((p.Width / 2) - 14, p.Height / 2);
            if((int)(Math.Abs(kinect.getVGauche()) * 255) / 50 < 255 && (int)((-Math.Abs(kinect.getVGauche()) * 255) / 50) + 255 < 255)
            {
                brush = new SolidBrush(Color.FromArgb(255, (int)(Math.Abs(kinect.getVGauche()) * 255) / 50, (int)((-Math.Abs(kinect.getVGauche()) * 255) / 50) + 255,0));
            }
            else
            {
                brush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
            }
            
            //brush = new SolidBrush(Color.FromArgb(255, 0, 100, 0));
            g.FillPolygon(brush, points);

            points[0] = new Point((p.Width / 2) + 14, p.Height / 2);
            points[1] = new Point((p.Width / 2) + 14, (int)((p.Height / 2) - (kinect.getVDroite() * facteur)));
            points[2] = new Point(p.Width - 14, (int)((p.Height / 2) - (kinect.getVDroite() * facteur)));
            points[3] = new Point(p.Width - 14, p.Height / 2);
            if((int)(Math.Abs(kinect.getVDroite()) * 255) / 50<255 && (int)((-Math.Abs(kinect.getVDroite()) * 255) / 50) + 255<255)
            {
                brush = new SolidBrush(Color.FromArgb(255, (int)(Math.Abs(kinect.getVDroite()) * 255) / 50, (int)((-Math.Abs(kinect.getVDroite()) * 255) / 50) + 255,0));
            }
            else
            {
                brush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
            }
            
            
            //brush = new SolidBrush(Color.FromArgb(255, 0, 100, 0));
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
            panelKVueDessus.Refresh();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void panelKVueDessus_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            Graphics g = e.Graphics;
            

            pointsH[0].X = 10;
            pointsH[0].Y = p.Height / 2;
            pointsH[2].X = (p.Width) - 10;
            pointsH[2].Y = p.Height;
            pointsH[1].X = (p.Width) - 10;
            pointsH[1].Y = 0;

            Brush brush = new SolidBrush(GrisFonce);

            g.FillPolygon(brush, pointsH);

            // tête
            R.Width = 30;
            R.Height = 30;
            R.X = (int)(kinect.getHead().Z * 100)-15;
            R.Y = (p.Height / 2) + (int)(kinect.getHead().X * 100)-15;
            //R = new Rectangle((int)(kinect.getHead().Z * 100), (p.Height/2)+(int)(kinect.getHead().X*100) ,40,40);
            brush = new SolidBrush(Color.FromArgb(255, 0 , 150, 255));

            g.FillEllipse(brush, R);

            // main gauche
            R.Width = 20;
            R.Height = 20;
            R.X = (int)(kinect.getLHand().Z * 100)-10;
            R.Y = (p.Height / 2) + (int)(kinect.getLHand().X * 100)-10;
            //R = new Rectangle((int)(kinect.getLHand().Z * 100), (p.Height / 2) + (int)(kinect.getLHand().X * 100), 30, 30);
            brush = new SolidBrush(Color.FromArgb(255, 255, 50, 50));

            g.FillEllipse(brush, R);

            // main gauche
            R.Width = 20;
            R.Height = 20;
            R.X = (int)(kinect.getRHand().Z * 100) - 10;
            R.Y = (p.Height / 2) + (int)(kinect.getRHand().X * 100) - 10;
            //R = new Rectangle((int)(kinect.getRHand().Z * 100), (p.Height / 2) + (int)(kinect.getRHand().X * 100), 30, 30);

            g.FillEllipse(brush, R);
        }
    }
}
