﻿using System;
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

        SkeletonPoint Head;
        SkeletonPoint RHand;
        SkeletonPoint LHand;
        double vGauche;
        double vDroite;
        double vG = 0;
        double vD = 0;
        double refGauche = 0;
        double refDroite = 0;
        Boolean modePince;
        Boolean modePinceOld;
        int pinceUpDown = 0;
        int pinceOpenClose = 0;

        double MargesPinceH = -0.15;
        double MargesPinceB = -0.6;
        double MargesPinceC = -0.25;
        double MargesPinceO = -0.43;
        int largeurConduite = 30;

        public double getVGauche()
        {
            return vG;
        }
        public double getReferenceDroite()
        {
            return refDroite;
        }
        public double getReferenceGauche()
        {
            return refGauche;
        }
        public double getVDroite()
        {
            return vD;
        }
        public SkeletonPoint getHead()
        {
            return Head;
        }
        public SkeletonPoint getLHand()
        {
            return LHand;
        }
        public SkeletonPoint getRHand()
        {
            return RHand;
        }
        public Boolean getModePince()
        {
            return modePince;
        }
        public int getPinceUpDown()
        {
            return pinceUpDown;
        }
        public int getPinceOpenClose()
        {
            return pinceOpenClose;
        }
        public double getMargesPinceH()
        {
            return MargesPinceH;
        }
        public void setMargesPinceH(double A1)
        {
            MargesPinceH = A1;
        }
        public double getMargesPinceB()
        {
            return MargesPinceB;
        }
        public void setMargesPinceB(double A1)
        {
            MargesPinceB = A1;
        }
        public double getMargesPinceC()
        {
            return MargesPinceC;
        }
        public void setMargesPinceC(double A1)
        {
            MargesPinceC = A1;
        }
        public double getMargesPinceO()
        {
            return MargesPinceO;
        }
        public void setMargesPinceO(double A1)
        {
            MargesPinceO = A1;
        }
        public int getLargeurConduite()
        {
            return largeurConduite;
        }
        public void setLargeurConduite(int A1)
        {
            largeurConduite = A1;
        }
        public void SwitchMode()
        {
            if (modePince == true)
            {
                modePince = false;
            }
            else
            {
                modePince = true;
            }
        }
        public void refreshAccAB(Skeleton sk)
        {
            SkeletonPoint p_MainDroite = sk.Joints[JointType.HandRight].Position;
            SkeletonPoint p_MainGauche = sk.Joints[JointType.HandLeft].Position;
            SkeletonPoint p_TETE = sk.Joints[JointType.Head].Position;

            if (modePinceOld == false)
            {
                if (p_MainDroite.X + 0.12 <= p_MainGauche.X)
                {
                    modePinceOld = true;
                    SwitchMode();
                }
            }
            if (p_MainDroite.X + 0.12 > p_MainGauche.X)
            {
                modePinceOld = false;
            }
            if (modePince == false)
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

                if (p_MainDroite.X * 100 < p_TETE.X * 100 + largeurConduite)          // vérifie la position d'arrête (30 cm sur les côtés) (si c'est à l'arrête, peut importe la positions l'acceleration = 0)
                {
                    if (refDroite == 0)     // vérifie si la reference est déjà définie ou si on doit la redéfinir (donc si on rentre dans le camp de contrôle)
                    {
                        refDroite = p_MainDroite.Z * 100;   // redéfini la référence)
                    }
                    vDroite = refDroite - p_MainDroite.Z * 100;     // redéfini la vitesse par rapport à la référence
                }
                else
                {
                    refDroite = 0;
                    vDroite = 0;
                    vD = 0;
                }

                if (p_MainGauche.X * 100 > p_TETE.X * 100 - largeurConduite)
                {
                    if (refGauche == 0)
                    {
                        refGauche = p_MainGauche.Z * 100;
                    }
                    vGauche = refGauche - p_MainGauche.Z * 100;
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
                double MoyenneY = (p_MainDroite.Y + p_MainGauche.Y) / 2;
                double MoyenneZ = (p_MainDroite.Z + p_MainGauche.Z) / 2;

                //TEST JAUNE
                if (MoyenneY > p_TETE.Y + MargesPinceH)
                {
                    //lblPINCEupdown.Text = "▲";
                    pinceUpDown = 1;
                }
                else
                {
                    if (MoyenneY < p_TETE.Y + MargesPinceB)
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
                if (MoyenneZ > p_TETE.Z + MargesPinceC)
                {
                    //lblPINCEopenclose.Text = "→←";
                    pinceOpenClose = -1;
                }
                else
                {
                    if (MoyenneZ < p_TETE.Z + MargesPinceO)
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
                    Head = skel.Joints[JointType.Head].Position;
                    RHand = skel.Joints[JointType.HandRight].Position;
                    LHand = skel.Joints[JointType.HandLeft].Position;
                    break;
                }
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
