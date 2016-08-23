namespace projet_p1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxModeSimluation = new System.Windows.Forms.CheckBox();
            this.pboxSIM = new System.Windows.Forms.PictureBox();
            this.pbox_VUE_Autres = new System.Windows.Forms.PictureBox();
            this.lblKinectControlView = new System.Windows.Forms.Label();
            this.pbVitesse = new System.Windows.Forms.PictureBox();
            this.pbCapteurs = new System.Windows.Forms.PictureBox();
            this.lblSTAT1 = new System.Windows.Forms.Label();
            this.lblSTAT2 = new System.Windows.Forms.Label();
            this.lblSTAT4 = new System.Windows.Forms.Label();
            this.lblSTAT3 = new System.Windows.Forms.Label();
            this.lblSTAT6 = new System.Windows.Forms.Label();
            this.lblSTAT5 = new System.Windows.Forms.Label();
            this.lblSTAT8 = new System.Windows.Forms.Label();
            this.lblSTAT7 = new System.Windows.Forms.Label();
            this.btnSettingsZigBEE = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_VUE_Autres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 37;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbxModeSimluation
            // 
            this.cbxModeSimluation.AutoSize = true;
            this.cbxModeSimluation.Location = new System.Drawing.Point(619, 8);
            this.cbxModeSimluation.Name = "cbxModeSimluation";
            this.cbxModeSimluation.Size = new System.Drawing.Size(104, 17);
            this.cbxModeSimluation.TabIndex = 28;
            this.cbxModeSimluation.Text = "Mode Simulation";
            this.cbxModeSimluation.UseVisualStyleBackColor = true;
            this.cbxModeSimluation.CheckedChanged += new System.EventHandler(this.cbxModeSimluation_CheckedChanged);
            // 
            // pboxSIM
            // 
            this.pboxSIM.BackColor = System.Drawing.Color.White;
            this.pboxSIM.Location = new System.Drawing.Point(619, 31);
            this.pboxSIM.Name = "pboxSIM";
            this.pboxSIM.Size = new System.Drawing.Size(648, 592);
            this.pboxSIM.TabIndex = 29;
            this.pboxSIM.TabStop = false;
            this.pboxSIM.Visible = false;
            this.pboxSIM.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxSIM_Paint);
            // 
            // pbox_VUE_Autres
            // 
            this.pbox_VUE_Autres.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbox_VUE_Autres.BackgroundImage = global::projet_p1.Properties.Resources.BG1;
            this.pbox_VUE_Autres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_VUE_Autres.Location = new System.Drawing.Point(12, 313);
            this.pbox_VUE_Autres.Name = "pbox_VUE_Autres";
            this.pbox_VUE_Autres.Size = new System.Drawing.Size(430, 310);
            this.pbox_VUE_Autres.TabIndex = 27;
            this.pbox_VUE_Autres.TabStop = false;
            this.pbox_VUE_Autres.Paint += new System.Windows.Forms.PaintEventHandler(this.pbVueAutrePaint);
            this.pbox_VUE_Autres.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbox_VUE_Autres.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pbox_VUE_Autres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbox_VUE_Autres.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // lblKinectControlView
            // 
            this.lblKinectControlView.AutoSize = true;
            this.lblKinectControlView.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKinectControlView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblKinectControlView.Location = new System.Drawing.Point(116, 313);
            this.lblKinectControlView.Name = "lblKinectControlView";
            this.lblKinectControlView.Size = new System.Drawing.Size(213, 23);
            this.lblKinectControlView.TabIndex = 30;
            this.lblKinectControlView.Text = "Vue du dessus - mode conduite";
            this.lblKinectControlView.Visible = false;
            // 
            // pbVitesse
            // 
            this.pbVitesse.Location = new System.Drawing.Point(447, 10);
            this.pbVitesse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbVitesse.Name = "pbVitesse";
            this.pbVitesse.Size = new System.Drawing.Size(166, 613);
            this.pbVitesse.TabIndex = 31;
            this.pbVitesse.TabStop = false;
            this.pbVitesse.Click += new System.EventHandler(this.pbVitesse_Click);
            this.pbVitesse.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVitesse_Paint);
            // 
            // pbCapteurs
            // 
            this.pbCapteurs.ErrorImage = global::projet_p1.Properties.Resources.Vu;
            this.pbCapteurs.Location = new System.Drawing.Point(619, 31);
            this.pbCapteurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCapteurs.Name = "pbCapteurs";
            this.pbCapteurs.Size = new System.Drawing.Size(446, 592);
            this.pbCapteurs.TabIndex = 32;
            this.pbCapteurs.TabStop = false;
            this.pbCapteurs.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCapteurs_Paint);
            // 
            // lblSTAT1
            // 
            this.lblSTAT1.AutoSize = true;
            this.lblSTAT1.Location = new System.Drawing.Point(749, 334);
            this.lblSTAT1.Name = "lblSTAT1";
            this.lblSTAT1.Size = new System.Drawing.Size(49, 13);
            this.lblSTAT1.TabIndex = 33;
            this.lblSTAT1.Text = "Moteur 1";
            // 
            // lblSTAT2
            // 
            this.lblSTAT2.AutoSize = true;
            this.lblSTAT2.Location = new System.Drawing.Point(749, 359);
            this.lblSTAT2.Name = "lblSTAT2";
            this.lblSTAT2.Size = new System.Drawing.Size(49, 13);
            this.lblSTAT2.TabIndex = 34;
            this.lblSTAT2.Text = "Moteur 2";
            // 
            // lblSTAT4
            // 
            this.lblSTAT4.AutoSize = true;
            this.lblSTAT4.Location = new System.Drawing.Point(749, 412);
            this.lblSTAT4.Name = "lblSTAT4";
            this.lblSTAT4.Size = new System.Drawing.Size(94, 13);
            this.lblSTAT4.TabIndex = 36;
            this.lblSTAT4.Text = "Capteur US arrière";
            // 
            // lblSTAT3
            // 
            this.lblSTAT3.AutoSize = true;
            this.lblSTAT3.Location = new System.Drawing.Point(749, 387);
            this.lblSTAT3.Name = "lblSTAT3";
            this.lblSTAT3.Size = new System.Drawing.Size(92, 13);
            this.lblSTAT3.TabIndex = 35;
            this.lblSTAT3.Text = "Capteur US avant";
            // 
            // lblSTAT6
            // 
            this.lblSTAT6.AutoSize = true;
            this.lblSTAT6.Location = new System.Drawing.Point(749, 463);
            this.lblSTAT6.Name = "lblSTAT6";
            this.lblSTAT6.Size = new System.Drawing.Size(109, 13);
            this.lblSTAT6.TabIndex = 38;
            this.lblSTAT6.Text = "Capteur US côté droit";
            // 
            // lblSTAT5
            // 
            this.lblSTAT5.AutoSize = true;
            this.lblSTAT5.Location = new System.Drawing.Point(749, 438);
            this.lblSTAT5.Name = "lblSTAT5";
            this.lblSTAT5.Size = new System.Drawing.Size(125, 13);
            this.lblSTAT5.TabIndex = 37;
            this.lblSTAT5.Text = "Capteur US côté gauche";
            // 
            // lblSTAT8
            // 
            this.lblSTAT8.AutoSize = true;
            this.lblSTAT8.Location = new System.Drawing.Point(749, 510);
            this.lblSTAT8.Name = "lblSTAT8";
            this.lblSTAT8.Size = new System.Drawing.Size(96, 13);
            this.lblSTAT8.TabIndex = 40;
            this.lblSTAT8.Text = "Servomoteur pince";
            // 
            // lblSTAT7
            // 
            this.lblSTAT7.AutoSize = true;
            this.lblSTAT7.Location = new System.Drawing.Point(749, 487);
            this.lblSTAT7.Name = "lblSTAT7";
            this.lblSTAT7.Size = new System.Drawing.Size(90, 13);
            this.lblSTAT7.TabIndex = 39;
            this.lblSTAT7.Text = "Servomoteur bras";
            // 
            // btnSettingsZigBEE
            // 
            this.btnSettingsZigBEE.Location = new System.Drawing.Point(729, 4);
            this.btnSettingsZigBEE.Name = "btnSettingsZigBEE";
            this.btnSettingsZigBEE.Size = new System.Drawing.Size(110, 22);
            this.btnSettingsZigBEE.TabIndex = 41;
            this.btnSettingsZigBEE.Text = "paramètres ZigBEE";
            this.btnSettingsZigBEE.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(845, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(106, 22);
            this.btnConnect.TabIndex = 42;
            this.btnConnect.Text = "connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(963, 635);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSettingsZigBEE);
            this.Controls.Add(this.lblSTAT8);
            this.Controls.Add(this.lblSTAT7);
            this.Controls.Add(this.lblSTAT6);
            this.Controls.Add(this.lblSTAT5);
            this.Controls.Add(this.lblSTAT4);
            this.Controls.Add(this.lblSTAT3);
            this.Controls.Add(this.lblSTAT2);
            this.Controls.Add(this.lblSTAT1);
            this.Controls.Add(this.pbCapteurs);
            this.Controls.Add(this.pbVitesse);
            this.Controls.Add(this.lblKinectControlView);
            this.Controls.Add(this.pboxSIM);
            this.Controls.Add(this.cbxModeSimluation);
            this.Controls.Add(this.pbox_VUE_Autres);
            this.Name = "Form1";
            this.Text = "K-Driver";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_VUE_Autres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbox_VUE_Autres;
        private System.Windows.Forms.CheckBox cbxModeSimluation;
        private System.Windows.Forms.PictureBox pboxSIM;
        private System.Windows.Forms.Label lblKinectControlView;
        private System.Windows.Forms.PictureBox pbVitesse;
        private System.Windows.Forms.PictureBox pbCapteurs;
        private System.Windows.Forms.Label lblSTAT1;
        private System.Windows.Forms.Label lblSTAT2;
        private System.Windows.Forms.Label lblSTAT4;
        private System.Windows.Forms.Label lblSTAT3;
        private System.Windows.Forms.Label lblSTAT6;
        private System.Windows.Forms.Label lblSTAT5;
        private System.Windows.Forms.Label lblSTAT8;
        private System.Windows.Forms.Label lblSTAT7;
        private System.Windows.Forms.Button btnSettingsZigBEE;
        private System.Windows.Forms.Button btnConnect;
    }
}

