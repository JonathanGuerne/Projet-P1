﻿namespace projet_p1
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
            this.Options = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbox_VUE_Autres = new System.Windows.Forms.PictureBox();
            this.lblDonneesMoteur = new System.Windows.Forms.Label();
            this.lblSTATUtitre = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbCapteurs = new System.Windows.Forms.PictureBox();
            this.pbVitesse = new System.Windows.Forms.PictureBox();
            this.pboxSIM = new System.Windows.Forms.PictureBox();
            this.tbChangementVitesse = new System.Windows.Forms.TrackBar();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_VUE_Autres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVitesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChangementVitesse)).BeginInit();
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
            this.cbxModeSimluation.Location = new System.Drawing.Point(308, 53);
            this.cbxModeSimluation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxModeSimluation.Name = "cbxModeSimluation";
            this.cbxModeSimluation.Size = new System.Drawing.Size(222, 32);
            this.cbxModeSimluation.TabIndex = 28;
            this.cbxModeSimluation.Text = "Mode simulation";
            this.cbxModeSimluation.UseVisualStyleBackColor = true;
            this.cbxModeSimluation.CheckedChanged += new System.EventHandler(this.cbxModeSimluation_CheckedChanged);
            // 
            // lblSTAT1
            // 
            this.lblSTAT1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSTAT1.AutoSize = true;
            this.lblSTAT1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSTAT1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblSTAT1.ForeColor = System.Drawing.Color.White;
            this.lblSTAT1.Location = new System.Drawing.Point(940, 489);
            this.lblSTAT1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT1.Name = "lblSTAT1";
            this.lblSTAT1.Size = new System.Drawing.Size(113, 28);
            this.lblSTAT1.TabIndex = 33;
            this.lblSTAT1.Text = "Moteur 1";
            // 
            // lblSTAT2
            // 
            this.lblSTAT2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSTAT2.AutoSize = true;
            this.lblSTAT2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSTAT2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblSTAT2.ForeColor = System.Drawing.Color.White;
            this.lblSTAT2.Location = new System.Drawing.Point(940, 519);
            this.lblSTAT2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT2.Name = "lblSTAT2";
            this.lblSTAT2.Size = new System.Drawing.Size(113, 28);
            this.lblSTAT2.TabIndex = 34;
            this.lblSTAT2.Text = "Moteur 2";
            // 
            // lblSTAT4
            // 
            this.lblSTAT4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSTAT4.AutoSize = true;
            this.lblSTAT4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSTAT4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblSTAT4.ForeColor = System.Drawing.Color.White;
            this.lblSTAT4.Location = new System.Drawing.Point(940, 585);
            this.lblSTAT4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT4.Name = "lblSTAT4";
            this.lblSTAT4.Size = new System.Drawing.Size(234, 28);
            this.lblSTAT4.TabIndex = 36;
            this.lblSTAT4.Text = "Capteur US arrière";
            // 
            // lblSTAT3
            // 
            this.lblSTAT3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSTAT3.AutoSize = true;
            this.lblSTAT3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSTAT3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblSTAT3.ForeColor = System.Drawing.Color.White;
            this.lblSTAT3.Location = new System.Drawing.Point(940, 554);
            this.lblSTAT3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT3.Name = "lblSTAT3";
            this.lblSTAT3.Size = new System.Drawing.Size(215, 28);
            this.lblSTAT3.TabIndex = 35;
            this.lblSTAT3.Text = "Capteur US avant";
            // 
            // lblSTAT6
            // 
            this.lblSTAT6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSTAT6.AutoSize = true;
            this.lblSTAT6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSTAT6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblSTAT6.ForeColor = System.Drawing.Color.White;
            this.lblSTAT6.Location = new System.Drawing.Point(940, 647);
            this.lblSTAT6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT6.Name = "lblSTAT6";
            this.lblSTAT6.Size = new System.Drawing.Size(263, 28);
            this.lblSTAT6.TabIndex = 38;
            this.lblSTAT6.Text = "Capteur US côté droit";
            // 
            // lblSTAT5
            // 
            this.lblSTAT5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSTAT5.AutoSize = true;
            this.lblSTAT5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSTAT5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblSTAT5.ForeColor = System.Drawing.Color.White;
            this.lblSTAT5.Location = new System.Drawing.Point(940, 617);
            this.lblSTAT5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT5.Name = "lblSTAT5";
            this.lblSTAT5.Size = new System.Drawing.Size(293, 28);
            this.lblSTAT5.TabIndex = 37;
            this.lblSTAT5.Text = "Capteur US côté gauche";
            // 
            // lblSTAT8
            // 
            this.lblSTAT8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSTAT8.AutoSize = true;
            this.lblSTAT8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSTAT8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblSTAT8.ForeColor = System.Drawing.Color.White;
            this.lblSTAT8.Location = new System.Drawing.Point(940, 705);
            this.lblSTAT8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT8.Name = "lblSTAT8";
            this.lblSTAT8.Size = new System.Drawing.Size(232, 28);
            this.lblSTAT8.TabIndex = 40;
            this.lblSTAT8.Text = "Servomoteur pince";
            // 
            // lblSTAT7
            // 
            this.lblSTAT7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSTAT7.AutoSize = true;
            this.lblSTAT7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSTAT7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblSTAT7.ForeColor = System.Drawing.Color.White;
            this.lblSTAT7.Location = new System.Drawing.Point(940, 677);
            this.lblSTAT7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTAT7.Name = "lblSTAT7";
            this.lblSTAT7.Size = new System.Drawing.Size(221, 28);
            this.lblSTAT7.TabIndex = 39;
            this.lblSTAT7.Text = "Servomoteur bras";
            // 
            // btnSettingsZigBEE
            // 
            this.btnSettingsZigBEE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsZigBEE.ForeColor = System.Drawing.Color.Black;
            this.btnSettingsZigBEE.Location = new System.Drawing.Point(31, 105);
            this.btnSettingsZigBEE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettingsZigBEE.Name = "btnSettingsZigBEE";
            this.btnSettingsZigBEE.Size = new System.Drawing.Size(283, 41);
            this.btnSettingsZigBEE.TabIndex = 41;
            this.btnSettingsZigBEE.Text = "Paramètres ZigBee";
            this.btnSettingsZigBEE.UseVisualStyleBackColor = true;
            this.btnSettingsZigBEE.Click += new System.EventHandler(this.btnSettingsZigBEE_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(349, 105);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(195, 41);
            this.btnConnect.TabIndex = 42;
            this.btnConnect.Text = "Connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbxSafetyMode
            // 
            this.cbxSafetyMode.AutoSize = true;
            this.cbxSafetyMode.Checked = true;
            this.cbxSafetyMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSafetyMode.Location = new System.Drawing.Point(31, 53);
            this.cbxSafetyMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSafetyMode.Name = "cbxSafetyMode";
            this.cbxSafetyMode.Size = new System.Drawing.Size(203, 32);
            this.cbxSafetyMode.TabIndex = 45;
            this.cbxSafetyMode.Text = "Mode sécurisé";
            this.cbxSafetyMode.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Options.Controls.Add(this.cbxSafetyMode);
            this.Options.Controls.Add(this.pictureBox1);
            this.Options.Controls.Add(this.btnConnect);
            this.Options.Controls.Add(this.cbxModeSimluation);
            this.Options.Controls.Add(this.btnSettingsZigBEE);
            this.Options.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.ForeColor = System.Drawing.Color.White;
            this.Options.Location = new System.Drawing.Point(16, 225);
            this.Options.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Options.Name = "Options";
            this.Options.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Options.Size = new System.Drawing.Size(573, 178);
            this.Options.TabIndex = 46;
            this.Options.TabStop = false;
            this.Options.Text = "Commandes et options";
            this.Options.Paint += new System.Windows.Forms.PaintEventHandler(this.Options_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(373, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 7);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.groupBox1.Controls.Add(this.pbox_VUE_Autres);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 421);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(573, 441);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position du pilote";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // pbox_VUE_Autres
            // 
            this.pbox_VUE_Autres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbox_VUE_Autres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pbox_VUE_Autres.BackgroundImage = global::projet_p1.Properties.Resources.BG1;
            this.pbox_VUE_Autres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbox_VUE_Autres.Location = new System.Drawing.Point(5, 33);
            this.pbox_VUE_Autres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbox_VUE_Autres.Name = "pbox_VUE_Autres";
            this.pbox_VUE_Autres.Size = new System.Drawing.Size(563, 402);
            this.pbox_VUE_Autres.TabIndex = 27;
            this.pbox_VUE_Autres.TabStop = false;
            this.pbox_VUE_Autres.Paint += new System.Windows.Forms.PaintEventHandler(this.pbVueAutrePaint);
            this.pbox_VUE_Autres.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbox_VUE_Autres.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pbox_VUE_Autres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbox_VUE_Autres.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // lblDonneesMoteur
            // 
            this.lblDonneesMoteur.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDonneesMoteur.AutoSize = true;
            this.lblDonneesMoteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblDonneesMoteur.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblDonneesMoteur.ForeColor = System.Drawing.Color.White;
            this.lblDonneesMoteur.Location = new System.Drawing.Point(844, 98);
            this.lblDonneesMoteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonneesMoteur.Name = "lblDonneesMoteur";
            this.lblDonneesMoteur.Size = new System.Drawing.Size(404, 28);
            this.lblDonneesMoteur.TabIndex = 48;
            this.lblDonneesMoteur.Text = "Capteurs de proximité & Connexion";
            // 
            // lblSTATUtitre
            // 
            this.lblSTATUtitre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSTATUtitre.AutoSize = true;
            this.lblSTATUtitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSTATUtitre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblSTATUtitre.ForeColor = System.Drawing.Color.White;
            this.lblSTATUtitre.Location = new System.Drawing.Point(844, 433);
            this.lblSTATUtitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSTATUtitre.Name = "lblSTATUtitre";
            this.lblSTATUtitre.Size = new System.Drawing.Size(271, 28);
            this.lblSTATUtitre.TabIndex = 49;
            this.lblSTATUtitre.Text = "Status de la connexion";
            // 
            // pbLogo
            // 
            this.pbLogo.ErrorImage = global::projet_p1.Properties.Resources.IconT;
            this.pbLogo.Location = new System.Drawing.Point(16, 12);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(207, 185);
            this.pbLogo.TabIndex = 43;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            this.pbLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLogo_Paint);
            // 
            // pbCapteurs
            // 
            this.pbCapteurs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbCapteurs.ErrorImage = global::projet_p1.Properties.Resources.BGBarresVitesses2;
            this.pbCapteurs.Location = new System.Drawing.Point(825, 86);
            this.pbCapteurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCapteurs.Name = "pbCapteurs";
            this.pbCapteurs.Size = new System.Drawing.Size(595, 729);
            this.pbCapteurs.TabIndex = 32;
            this.pbCapteurs.TabStop = false;
            this.pbCapteurs.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCapteurs_Paint);
            // 
            // pbVitesse
            // 
            this.pbVitesse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbVitesse.Location = new System.Drawing.Point(596, 12);
            this.pbVitesse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbVitesse.Name = "pbVitesse";
            this.pbVitesse.Size = new System.Drawing.Size(221, 850);
            this.pbVitesse.TabIndex = 31;
            this.pbVitesse.TabStop = false;
            this.pbVitesse.Click += new System.EventHandler(this.pbVitesse_Click);
            this.pbVitesse.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVitesse_Paint);
            // 
            // pboxSIM
            // 
            this.pboxSIM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxSIM.BackColor = System.Drawing.Color.White;
            this.pboxSIM.Location = new System.Drawing.Point(600, 38);
            this.pboxSIM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxSIM.Name = "pboxSIM";
            this.pboxSIM.Size = new System.Drawing.Size(600, 601);
            this.pboxSIM.TabIndex = 29;
            this.pboxSIM.TabStop = false;
            this.pboxSIM.Visible = false;
            this.pboxSIM.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxSIM_Paint);
            // 
            // tbChangementVitesse
            // 
            this.tbChangementVitesse.Location = new System.Drawing.Point(229, 164);
            this.tbChangementVitesse.Maximum = 20;
            this.tbChangementVitesse.Name = "tbChangementVitesse";
            this.tbChangementVitesse.Size = new System.Drawing.Size(355, 56);
            this.tbChangementVitesse.TabIndex = 50;
            this.tbChangementVitesse.Value = 10;
            this.tbChangementVitesse.ValueChanged += new System.EventHandler(this.tbChangementVitesse_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.tbChangementVitesse);
            this.Controls.Add(this.lblSTATUtitre);
            this.Controls.Add(this.lblDonneesMoteur);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.pbLogo);
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
            this.Controls.Add(this.pboxSIM);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "K-Driver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_VUE_Autres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVitesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChangementVitesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbox_VUE_Autres;
        private System.Windows.Forms.CheckBox cbxModeSimluation;
        private System.Windows.Forms.PictureBox pboxSIM;
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
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDonneesMoteur;
        private System.Windows.Forms.Label lblSTATUtitre;
        private System.Windows.Forms.TrackBar tbChangementVitesse;
    }
}

