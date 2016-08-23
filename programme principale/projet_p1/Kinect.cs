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

        SkeletonPoint Head;
        SkeletonPoint RHand;
        SkeletonPoint LHand;
        double vGauche;
        double vDroite;
        double vGLisse = 0;
        double vDLisse = 0;
        double refGauche = 0;
        double refDroite = 0;
        Boolean modePince;
        Boolean modePinceOld;
        int pinceUpDown = 0;
        int pinceOpenClose = 0;

        double margeChangementMode = 0.12;

        double margesPinceH = -0.15;
        double margesPinceB = -0.6;
        double margesPinceC = -0.25;
        double margesPinceO = -0.43;
        int largeurConduite = 40;

        public double getVGLisse()
        {
            return vGLisse;
        }
        public double getReferenceDroite()
        {
            return refDroite;
        }
        public double getReferenceGauche()
        {
            return refGauche;
        }
        public double getVDLisse()
        {
            return vDLisse;
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
            return margesPinceH;
        }
        public void setMargesPinceH(double A1)
        {
            margesPinceH = A1;
        }
        public double getMargesPinceB()
        {
            return margesPinceB;
        }
        public void setMargesPinceB(double A1)
        {
            margesPinceB = A1;
        }
        public double getMargesPinceC()
        {
            return margesPinceC;
        }
        public void setMargesPinceC(double A1)
        {
            margesPinceC = A1;
        }
        public double getMargesPinceO()
        {
            return margesPinceO;
        }
        public void setMargesPinceO(double A1)
        {
            margesPinceO = A1;
        }
        public int getLargeurConduite()
        {
            return largeurConduite;
        }
        public void setLargeurConduite(int A1)
        {
            largeurConduite = A1;
        }
        public void refreshAccAB(Skeleton sk)
        {

            if (modePinceOld == false)//VERIFIE LE DERNIER ETAT POUR NE PAS CHANGER DE MODE EN CONTINUE QUAND LES BRAS SONT CROISES
            {
                if (RHand.X + margeChangementMode <= LHand.X)//CHANGEMENT DE MODE  
                {
                    modePinceOld = true;
                    modePince = !modePince;//remplace la méthode SwitchMode
                }
            }
            if (RHand.X + margeChangementMode > LHand.X)
            {
                modePinceOld = false;
            }


            //MODE PILOTE
            if (modePince == false)
            {

                if (RHand.X * 100 < Head.X * 100 + largeurConduite)          // vérifie la position d'arrête (30 cm sur les côtés) (si c'est à l'arrête, peut importe la positions l'acceleration = 0)
                {
                    if (refDroite == 0)     // vérifie si la reference est déjà définie ou si on doit la redéfinir (donc si on rentre dans le camp de contrôle)
                    {
                        refDroite = RHand.Z * 100;   // redéfini la référence)
                    }
                    vDroite = refDroite - RHand.Z * 100;     // redéfini la vitesse par rapport à la référence
                }
                else
                {
                    refDroite = 0;
                    vDroite = 0;
                    vDLisse = 0;
                }


                //même processus à gauche 
                if (LHand.X * 100 > Head.X * 100 - largeurConduite)
                {
                    if (refGauche == 0)
                    {
                        refGauche = LHand.Z * 100;
                    }
                    vGauche = refGauche - LHand.Z * 100;
                }
                else
                {
                    vGauche = 0;
                    vGLisse = 0;
                    refGauche = 0;
                }


                //lblPINCEopenclose.Text = "-";
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
                double MoyenneY = (RHand.Y + LHand.Y) / 2;
                double MoyenneZ = (RHand.Z + LHand.Z) / 2;

                //TEST JAUNE
                if (MoyenneY > Head.Y + margesPinceH)
                {
                    //lblPINCEupdown.Text = "▲";
                    pinceUpDown = 1;
                }
                else
                {
                    if (MoyenneY < Head.Y + margesPinceB)
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
                if (MoyenneZ > Head.Z + margesPinceC)
                {
                    //lblPINCEopenclose.Text = "→←";
                    pinceOpenClose = -1;
                }
                else
                {
                    if (MoyenneZ < Head.Z + margesPinceO)
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
            if (vDLisse == 0)
            {
                vDLisse = vDroite;
            }
            else
            {
                if (Math.Abs(vDLisse - vDroite) < 3)
                {
                    vDLisse = (vDLisse + vDroite) / 2;
                }
                else
                {
                    vDLisse = (5 * vDLisse + vDroite) / 6;
                }
            }
            if (vGLisse == 0)
            {
                vGLisse = vGauche;
            }
            else
            {
                if (Math.Abs(vGLisse - vGauche) < 3)
                {
                    vGLisse = (vGLisse + vGauche) / 2;
                }
                else
                {
                    vGLisse = (5 * vGLisse + vGauche) / 6;
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
                    
                    Head = skel.Joints[JointType.Head].Position;
                    RHand = skel.Joints[JointType.HandRight].Position;
                    LHand = skel.Joints[JointType.HandLeft].Position;
                    refreshAccAB(skel);
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
