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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(963, 635);
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
    }
}

