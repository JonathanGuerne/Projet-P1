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
            this.lblKinectControlView = new System.Windows.Forms.Label();
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
            this.cbxSafetyMode = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbCapteurs = new System.Windows.Forms.PictureBox();
            this.pbVitesse = new System.Windows.Forms.PictureBox();
            this.pboxSIM = new System.Windows.Forms.PictureBox();
            this.pbox_VUE_Autres = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_VUE_Autres)).BeginInit();
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
            this.cbxModeSimluation.Location = new System.Drawing.Point(160, 13);
            this.cbxModeSimluation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxModeSimluation.Name = "cbxModeSimluation";
            this.cbxModeSimluation.Size = new System.Drawing.Size(134, 21);
            this.cbxModeSimluation.TabIndex = 28;
            this.cbxModeSimluation.Text = "Mode Simulation";
            this.cbxModeSimluation.UseVisualStyleBackColor = true;
            this.cbxModeSimluation.CheckedChanged += new System.EventHandler(this.cbxModeSimluation_CheckedChanged);
            // 
            // lblKinectControlView
            // 
            this.lblKinectControlView.AutoSize = true;
            this.lblKinectControlView.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKinectControlView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblKinectControlView.Location = new System.Drawing.Point(155, 385);
            this.lblKinectControlView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKinectControlView.Name = "lblKinectControlView";
            this.lblKinectControlView.Size = new System.Drawing.Size(272, 29);
            this.lblKinectControlView.TabIndex = 30;
            this.lblKinectControlView.Text = "Vue du dessus - mode conduite";
            this.lblKinectControlView.Visible = false;
            // 
            // lblSTAT1
            // 
            this.lblSTAT1.AutoSize = true;
            this.lblSTAT1.Location = new System.Drawing.Point(999, 411);
            this.lblSTAT1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT1.Name = "lblSTAT1";
            this.lblSTAT1.Size = new System.Drawing.Size(64, 17);
            this.lblSTAT1.TabIndex = 33;
            this.lblSTAT1.Text = "Moteur 1";
            // 
            // lblSTAT2
            // 
            this.lblSTAT2.AutoSize = true;
            this.lblSTAT2.Location = new System.Drawing.Point(999, 442);
            this.lblSTAT2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT2.Name = "lblSTAT2";
            this.lblSTAT2.Size = new System.Drawing.Size(64, 17);
            this.lblSTAT2.TabIndex = 34;
            this.lblSTAT2.Text = "Moteur 2";
            // 
            // lblSTAT4
            // 
            this.lblSTAT4.AutoSize = true;
            this.lblSTAT4.Location = new System.Drawing.Point(999, 507);
            this.lblSTAT4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT4.Name = "lblSTAT4";
            this.lblSTAT4.Size = new System.Drawing.Size(127, 17);
            this.lblSTAT4.TabIndex = 36;
            this.lblSTAT4.Text = "Capteur US arrière";
            // 
            // lblSTAT3
            // 
            this.lblSTAT3.AutoSize = true;
            this.lblSTAT3.Location = new System.Drawing.Point(999, 476);
            this.lblSTAT3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT3.Name = "lblSTAT3";
            this.lblSTAT3.Size = new System.Drawing.Size(120, 17);
            this.lblSTAT3.TabIndex = 35;
            this.lblSTAT3.Text = "Capteur US avant";
            // 
            // lblSTAT6
            // 
            this.lblSTAT6.AutoSize = true;
            this.lblSTAT6.Location = new System.Drawing.Point(999, 570);
            this.lblSTAT6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT6.Name = "lblSTAT6";
            this.lblSTAT6.Size = new System.Drawing.Size(144, 17);
            this.lblSTAT6.TabIndex = 38;
            this.lblSTAT6.Text = "Capteur US côté droit";
            // 
            // lblSTAT5
            // 
            this.lblSTAT5.AutoSize = true;
            this.lblSTAT5.Location = new System.Drawing.Point(999, 539);
            this.lblSTAT5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT5.Name = "lblSTAT5";
            this.lblSTAT5.Size = new System.Drawing.Size(163, 17);
            this.lblSTAT5.TabIndex = 37;
            this.lblSTAT5.Text = "Capteur US côté gauche";
            // 
            // lblSTAT8
            // 
            this.lblSTAT8.AutoSize = true;
            this.lblSTAT8.Location = new System.Drawing.Point(999, 628);
            this.lblSTAT8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT8.Name = "lblSTAT8";
            this.lblSTAT8.Size = new System.Drawing.Size(127, 17);
            this.lblSTAT8.TabIndex = 40;
            this.lblSTAT8.Text = "Servomoteur pince";
            // 
            // lblSTAT7
            // 
            this.lblSTAT7.AutoSize = true;
            this.lblSTAT7.Location = new System.Drawing.Point(999, 599);
            this.lblSTAT7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT7.Name = "lblSTAT7";
            this.lblSTAT7.Size = new System.Drawing.Size(121, 17);
            this.lblSTAT7.TabIndex = 39;
            this.lblSTAT7.Text = "Servomoteur bras";
            // 
            // btnSettingsZigBEE
            // 
            this.btnSettingsZigBEE.Location = new System.Drawing.Point(972, 5);
            this.btnSettingsZigBEE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettingsZigBEE.Name = "btnSettingsZigBEE";
            this.btnSettingsZigBEE.Size = new System.Drawing.Size(147, 27);
            this.btnSettingsZigBEE.TabIndex = 41;
            this.btnSettingsZigBEE.Text = "paramètres ZigBEE";
            this.btnSettingsZigBEE.UseVisualStyleBackColor = true;
            this.btnSettingsZigBEE.Click += new System.EventHandler(this.btnSettingsZigBEE_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1127, 5);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 27);
            this.btnConnect.TabIndex = 42;
            this.btnConnect.Text = "connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbxSafetyMode
            // 
            this.cbxSafetyMode.AutoSize = true;
            this.cbxSafetyMode.Checked = true;
            this.cbxSafetyMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSafetyMode.Location = new System.Drawing.Point(16, 13);
            this.cbxSafetyMode.Name = "cbxSafetyMode";
            this.cbxSafetyMode.Size = new System.Drawing.Size(122, 21);
            this.cbxSafetyMode.TabIndex = 45;
            this.cbxSafetyMode.Text = "Mode sécurisé";
            this.cbxSafetyMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(390, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.ErrorImage = global::projet_p1.Properties.Resources.IconT;
            this.pbLogo.Location = new System.Drawing.Point(16, 59);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(280, 231);
            this.pbLogo.TabIndex = 43;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            this.pbLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLogo_Paint);
            // 
            // pbCapteurs
            // 
            this.pbCapteurs.ErrorImage = global::projet_p1.Properties.Resources.BGBarresVitesses2;
            this.pbCapteurs.Location = new System.Drawing.Point(825, 38);
            this.pbCapteurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCapteurs.Name = "pbCapteurs";
            this.pbCapteurs.Size = new System.Drawing.Size(595, 729);
            this.pbCapteurs.TabIndex = 32;
            this.pbCapteurs.TabStop = false;
            this.pbCapteurs.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCapteurs_Paint);
            // 
            // pbVitesse
            // 
            this.pbVitesse.Location = new System.Drawing.Point(596, 12);
            this.pbVitesse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbVitesse.Name = "pbVitesse";
            this.pbVitesse.Size = new System.Drawing.Size(221, 754);
            this.pbVitesse.TabIndex = 31;
            this.pbVitesse.TabStop = false;
            this.pbVitesse.Click += new System.EventHandler(this.pbVitesse_Click);
            this.pbVitesse.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVitesse_Paint);
            // 
            // pboxSIM
            // 
            this.pboxSIM.BackColor = System.Drawing.Color.White;
            this.pboxSIM.Location = new System.Drawing.Point(825, 38);
            this.pboxSIM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxSIM.Name = "pboxSIM";
            this.pboxSIM.Size = new System.Drawing.Size(864, 729);
            this.pboxSIM.TabIndex = 29;
            this.pboxSIM.TabStop = false;
            this.pboxSIM.Visible = false;
            this.pboxSIM.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxSIM_Paint);
            // 
            // pbox_VUE_Autres
            // 
            this.pbox_VUE_Autres.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbox_VUE_Autres.BackgroundImage = global::projet_p1.Properties.Resources.BG1;
            this.pbox_VUE_Autres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbox_VUE_Autres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox_VUE_Autres.Location = new System.Drawing.Point(16, 385);
            this.pbox_VUE_Autres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbox_VUE_Autres.Name = "pbox_VUE_Autres";
            this.pbox_VUE_Autres.Size = new System.Drawing.Size(573, 381);
            this.pbox_VUE_Autres.TabIndex = 27;
            this.pbox_VUE_Autres.TabStop = false;
            this.pbox_VUE_Autres.Paint += new System.Windows.Forms.PaintEventHandler(this.pbVueAutrePaint);
            this.pbox_VUE_Autres.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbox_VUE_Autres.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pbox_VUE_Autres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbox_VUE_Autres.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.cbxSafetyMode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLogo);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "K-Driver";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_VUE_Autres)).EndInit();
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
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbxSafetyMode;
    }
}

