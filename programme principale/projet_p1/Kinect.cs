using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using System.IO;

namespace projet_p1
{
    class Kinect    //testCommitDeniiiiiiiiiiiiiiiiiiiiii!i!i!i!i!
    {
        private KinectSensor sensor;
        public Form1 form;


        double vGauche;
        double vDroite;
        double vG = 0;
        double vD = 0;
        double refGauche = 0;
        double refDroite = 0;
        Boolean modePince;
        int pinceUpDown = 0;
        int pinceOpenClose = 0;




        public void refreshAccAB(Skeleton sk)
        {
            SkeletonPoint p_MainDroite = sk.Joints[JointType.HandRight].Position;
            SkeletonPoint p_MainGauche = sk.Joints[JointType.HandLeft].Position;
            SkeletonPoint p_TETE = sk.Joints[JointType.Head].Position;
            if (p_MainDroite.X + 0.12 > p_MainGauche.X)
            {
                modePince = false;
                if (refDroite == 0)
                {
                    //refDroite = p_TETE.X * 100;
                }
                if (refGauche == 0)
                {
                    //refGauche = p_TETE.X * 100;
                }

                if (p_MainDroite.X * 100 < p_TETE.X * 100 + 30)          // vérifie la position d'arrête (30 cm sur les côtés) (si c'est à l'arrête, peut importe la positions l'acceleration = 0)
                {
                    if (refDroite == 0)     // vérifie si la reference est déjà définie ou si on doit la redéfinir (donc si on rentre dans le camp de contrôle)
                    {
                        refDroite = p_MainDroite.Z * 100;   // redéfini la référence)
                    }
                    vDroite = refDroite - p_MainDroite.Z * 100;     // redéfini la vitesse par rapport à la référence
                    refreshBTN2(form.getBtnD(), Convert.ToInt32(vDroite * 4));
                }
                else
                {
                    refDroite = 0;
                    vDroite = 0;
                    vD = 0;
                }

                if (p_MainGauche.X * 100 > p_TETE.X * 100 - 30)
                {
                    if (refGauche == 0)
                    {
                        refGauche = p_MainGauche.Z * 100;
                    }
                    vGauche = refGauche - p_MainGauche.Z * 100;
                    refreshBTN2(form.getBtnG(), Convert.ToInt32(vGauche * 4));
                }
                else
                {
                    vGauche = 0;
                    vG = 0;
                    refGauche = 0;
                }
                //lblPINCEopenclose.Text = "-";
                pinceOpenClose = 0;
                //lblPINCEupdown.Text = "-";
                pinceOpenClose = 0;
            }
            else
            {
                modePince = true;
                refDroite = 0;
                refGauche = 0;
                vDroite = 0;
                vGauche = 0;
                refreshBTN(form.getBtnG(), 0);
                refreshBTN(form.getBtnD(), 0);
                double MoyenneY = p_MainDroite.Y + p_MainGauche.Y;
                double MoyenneZ = (p_MainDroite.Z + p_MainGauche.Z) / 2;

                //TEST JAUNE
                if (MoyenneY > p_TETE.Y + 0.1)
                {
                    //lblPINCEupdown.Text = "▲";
                    pinceUpDown = 1;
                }
                else
                {
                    if (MoyenneY < p_TETE.Y - 0.6)
                    {
                        //lblPINCEupdown.Text = "▼";
                        pinceUpDown = -1;
                    }
                    else
                    {
                        //lblPINCEupdown.Text = "○";
                        pinceUpDown = 0;
                    }
                }
                //TEST ROUGE
                if (MoyenneZ > p_TETE.Z - 0.25)
                {
                    //lblPINCEopenclose.Text = "→←";
                    pinceOpenClose = -1;
                }
                else
                {
                    if (MoyenneZ < p_TETE.Z - 0.43)
                    {
                        //lblPINCEopenclose.Text = "←→";
                        pinceOpenClose = 1;
                    }
                    else
                    {
                        //lblPINCEopenclose.Text = "○";
                        pinceOpenClose = 0;
                    }
                }
            }
            // stabilisation
            if (vD == 0)
            {
                vD = vDroite;
            }
            else
            {
                if (Math.Abs(vD - vDroite) < 3)
                {
                    vD = (vD + vDroite) / 2;
                }
                else
                {
                    vD = (5 * vD + vDroite) / 6;
                }
            }
            if (vG == 0)
            {
                vG = vGauche;
            }
            else
            {
                if (Math.Abs(vG - vGauche) < 3)
                {
                    vG = (vG + vGauche) / 2;
                }
                else
                {
                    vG = (5 * vG + vGauche) / 6;
                }
            }

            //Vitesse Max : 40
            if (vD > 40)
            {
                form.getBtnD().FlatAppearance.BorderColor = Color.FromArgb(255, 0, 255, 0);
                form.getBtnD().BackColor = Color.FromArgb(255, 192, 0, 0);
                vD = 40;
            }
            else if (form.getBtnD().BackColor == Color.FromArgb(255, 192, 0, 0))
            {
                form.getBtnD().FlatAppearance.BorderColor = Color.Lime;
                form.getBtnD().BackColor = Color.FromArgb(255, 0, 192, 0);
            }
            if (vD < -40)
            {
                form.getBtnD().FlatAppearance.BorderColor = Color.FromArgb(255, 0, 255, 0);
                form.getBtnD().BackColor = Color.FromArgb(255, 192, 0, 0);
                vD = -40;
            }
            else if (form.getBtnD().BackColor == Color.FromArgb(255, 192, 0, 0))
            {
                form.getBtnD().FlatAppearance.BorderColor = Color.Lime;
                form.getBtnD().BackColor = Color.FromArgb(255, 0, 192, 0);
            }
            if (vG > 40)
            {
                form.getBtnG().FlatAppearance.BorderColor = Color.FromArgb(255, 0, 255, 0);
                form.getBtnG().BackColor = Color.FromArgb(255, 192, 0, 0);
                vG = 40;
            }
            else if (form.getBtnG().BackColor == Color.FromArgb(255, 192, 0, 0))
            {
                form.getBtnG().FlatAppearance.BorderColor = Color.Lime;
                form.getBtnG().BackColor = Color.FromArgb(255, 0, 192, 0);
            }
            if (vG < -40)
            {
                form.getBtnG().FlatAppearance.BorderColor = Color.FromArgb(255, 0, 255, 0);
                form.getBtnG().BackColor = Color.FromArgb(255, 192, 0, 0);
                vG = -40;
            }
            else if (form.getBtnG().BackColor == Color.FromArgb(255, 192, 0, 0))
            {
                form.getBtnG().FlatAppearance.BorderColor = Color.Lime;
                form.getBtnG().BackColor = Color.FromArgb(255, 0, 192, 0);
            }
            refreshBTN2(form.getBtnG(), Convert.ToInt32(vG * 6));
            refreshBTN2(form.getBtnD(), Convert.ToInt32(vD * 6));
        }

        private void SensorSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            Skeleton[] skeletons = new Skeleton[0];

            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    // lblNbPlayer.Text = skeletonFrame.SkeletonArrayLength+"";
                    skeletonFrame.CopySkeletonDataTo(skeletons);
                    //refreshAccAB(skeletons[0]);
                }
            }

            foreach (Skeleton skel in skeletons)
            {
                if (skel.TrackingState == SkeletonTrackingState.Tracked)
                {
                    refreshAccAB(skel);
                    break;
                }
            }
        }

        //private void btnGO_Click(object sender, EventArgs e)
        //{
        //    if (btnGO.Text == "GO")
        //    {
        //        refreshBTN2(btnD, 1);
        //        refreshBTN2(btnG, 1);
        //        btnGO.Text = "STOP";
        //    }
        //    else
        //    {
        //        btnGO.Text = "GO";
        //        refreshBTN2(btnD, 0);
        //        refreshBTN2(btnG, 0);
        //    }
        //}

        public void refreshBTN(Button Btn, int T) //rafraichit la taille des "bouttons" oui, désolé ce sont des buttons qui indiquent la vitesse ... ><
        {
            Btn.Height = T;
            Btn.Top = 250 - T + 4;

        }
        public void refreshBTN2(Button Btn, int T) // idem mais avec des nombres positifs et négatifs (2ème sorte de bouttons)
        {
            if (T >= 0)
            {
                Btn.Height = T;
                Btn.Top = 250 - T + 4;
            }
            if (T < 0)
            {
                Btn.Height = -T;
                Btn.Top = 250 + 4;
            }
        }

        public void launch()
        {
            foreach (var potentialSensor in KinectSensor.KinectSensors)
            {
                if (potentialSensor.Status == KinectStatus.Connected)
                {
                    this.sensor = potentialSensor;
                    break;
                }
            }
            if (null != this.sensor)
            {
                // Turn on the skeleton stream to receive skeleton frames
                this.sensor.SkeletonStream.Enable();

                // Add an event handler to be called whenever there is new color frame data 
                this.sensor.SkeletonFrameReady += this.SensorSkeletonFrameReady;

                // Start the sensor!
                try
                {
                    this.sensor.Start();
                }
                catch (IOException)
                {
                    this.sensor = null;
                }
            }

            if (null == this.sensor)
            {
                //this.statusBarText.Text = Properties.Resources.NoKinectReady;
            }
        }
        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != this.sensor)
            {
                this.sensor.Stop();
            }
        }
    }
}
