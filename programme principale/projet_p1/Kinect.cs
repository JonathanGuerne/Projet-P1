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

        double FacteurVitesse = 1;

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

        double margesPinceHaut = -0.15;
        double margesPinceBas = -0.536;
        double margesPinceClose = -0.225;
        double margesPinceOpen = -0.543;

        bool flagPallierPince=false;

        int largeurConduite = 40;

        public double getVGLisse()
        {
            double Vg = vGLisse * FacteurVitesse;
            if(vGLisse * FacteurVitesse > 100)
            {
                Vg = 100;
            }
            return Vg;
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
            double Vd = vDLisse * FacteurVitesse;
            if (vDLisse * FacteurVitesse > 100)
            {
                Vd = 100;
            }
            return Vd;
        }
        public SkeletonPoint getHead()
        {
            return Head;
        }

        public void setFacteurVitesse(double facteur)
        {
            FacteurVitesse = facteur;
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
        public double getMargesPinceHaut()
        {
            return margesPinceHaut;
        }
        public void setMargesPinceHaut(double A1)
        {
            margesPinceHaut = A1;
        }
        public double getMargesPinceBas()
        {
            return margesPinceBas;
        }
        public void setMargesPinceBas(double A1)
        {
            margesPinceBas = A1;
        }
        public double getMargesPinceClose()
        {
            return margesPinceClose;
        }
        public void setMargesPinceClose(double A1)
        {
            margesPinceClose = A1;
        }
        public double getMargesPinceOpen()
        {
            return margesPinceOpen;
        }
        public void setMargesPinceOpen(double A1)
        {
            margesPinceOpen = A1;
        }
        public int getLargeurConduite()
        {
            return largeurConduite;
        }
        public void setLargeurConduite(int A1)
        {
            largeurConduite = A1;
        }

        public bool getFlagPallier()
        {
            return flagPallierPince;
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
                //pinceOpenClose = 0;
            }
            else
            {
                refDroite = 0;
                refGauche = 0;
                vDroite = 0;
                vGauche = 0;
                double MoyenneY = (RHand.Y + LHand.Y) / 2;
                double MoyenneZ = (RHand.Z + LHand.Z) / 2;

                //TEST JAUNE
                if (MoyenneZ < Head.Z + margesPinceClose && MoyenneZ > Head.Z + margesPinceOpen)
                {
                    if (!flagPallierPince)
                    {
                        if (MoyenneY > Head.Y + margesPinceHaut && pinceUpDown > 0)
                        {
                            pinceUpDown -= 15;
                            if (pinceUpDown < 0)
                                pinceUpDown = 0;

                            flagPallierPince = true;
                            WaitAndChangeFlag(750);
                        }
                        else if (MoyenneY < Head.Y + margesPinceBas && pinceUpDown < 70)
                        {
                            pinceUpDown += 15;
                            if (pinceUpDown > 50)
                                pinceUpDown = 50;

                            flagPallierPince = true;
                            WaitAndChangeFlag(750);
                        }
                    }
                }
                //TEST ROUGE

                if (MoyenneZ > Head.Z + margesPinceClose && pinceOpenClose < 100)
                {
                    pinceOpenClose += 5;
                }
                else if (MoyenneZ < Head.Z + margesPinceOpen && pinceOpenClose > 0)
                {
                    pinceOpenClose -= 5;
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

        public async void WaitAndChangeFlag(int timeoutInMilliseconds)
        {
            await Task.Delay(timeoutInMilliseconds);
            flagPallierPince = false;
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
