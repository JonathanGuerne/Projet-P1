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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblGAUCHE1 = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.lblDROITE1 = new System.Windows.Forms.Label();
            this.lblGAUCHEref = new System.Windows.Forms.Label();
            this.lblDROITEref = new System.Windows.Forms.Label();
            this.lblGAUCHEv = new System.Windows.Forms.Label();
            this.lblDROITEv = new System.Windows.Forms.Label();
            this.lblDROITEx = new System.Windows.Forms.Label();
            this.lblGAUCHEx = new System.Windows.Forms.Label();
            this.lblHEADx = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.lblPINCEupdown = new System.Windows.Forms.Label();
            this.lblPINCEopenclose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVitesse = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(525, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 414);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(454, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 414);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblGAUCHE1
            // 
            this.lblGAUCHE1.AutoSize = true;
            this.lblGAUCHE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGAUCHE1.Location = new System.Drawing.Point(721, 9);
            this.lblGAUCHE1.Name = "lblGAUCHE1";
            this.lblGAUCHE1.Size = new System.Drawing.Size(121, 20);
            this.lblGAUCHE1.TabIndex = 1;
            this.lblGAUCHE1.Text = "position gauche";
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnD.Enabled = false;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnD.FlatAppearance.BorderSize = 5;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Location = new System.Drawing.Point(525, 12);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(68, 393);
            this.btnD.TabIndex = 7;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnG.Enabled = false;
            this.btnG.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnG.FlatAppearance.BorderSize = 5;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG.Location = new System.Drawing.Point(454, 12);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(68, 393);
            this.btnG.TabIndex = 6;
            this.btnG.UseVisualStyleBackColor = false;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(615, 5);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(79, 23);
            this.btnGO.TabIndex = 8;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            // 
            // lblDROITE1
            // 
            this.lblDROITE1.AutoSize = true;
            this.lblDROITE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDROITE1.Location = new System.Drawing.Point(848, 9);
            this.lblDROITE1.Name = "lblDROITE1";
            this.lblDROITE1.Size = new System.Drawing.Size(108, 20);
            this.lblDROITE1.TabIndex = 9;
            this.lblDROITE1.Text = "position droite";
            // 
            // lblGAUCHEref
            // 
            this.lblGAUCHEref.AutoSize = true;
            this.lblGAUCHEref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGAUCHEref.Location = new System.Drawing.Point(721, 101);
            this.lblGAUCHEref.Name = "lblGAUCHEref";
            this.lblGAUCHEref.Size = new System.Drawing.Size(108, 20);
            this.lblGAUCHEref.TabIndex = 11;
            this.lblGAUCHEref.Text = "position droite";
            // 
            // lblDROITEref
            // 
            this.lblDROITEref.AutoSize = true;
            this.lblDROITEref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDROITEref.Location = new System.Drawing.Point(848, 101);
            this.lblDROITEref.Name = "lblDROITEref";
            this.lblDROITEref.Size = new System.Drawing.Size(121, 20);
            this.lblDROITEref.TabIndex = 10;
            this.lblDROITEref.Text = "position gauche";
            // 
            // lblGAUCHEv
            // 
            this.lblGAUCHEv.AutoSize = true;
            this.lblGAUCHEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGAUCHEv.Location = new System.Drawing.Point(721, 160);
            this.lblGAUCHEv.Name = "lblGAUCHEv";
            this.lblGAUCHEv.Size = new System.Drawing.Size(108, 20);
            this.lblGAUCHEv.TabIndex = 13;
            this.lblGAUCHEv.Text = "position droite";
            // 
            // lblDROITEv
            // 
            this.lblDROITEv.AutoSize = true;
            this.lblDROITEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDROITEv.Location = new System.Drawing.Point(848, 160);
            this.lblDROITEv.Name = "lblDROITEv";
            this.lblDROITEv.Size = new System.Drawing.Size(121, 20);
            this.lblDROITEv.TabIndex = 12;
            this.lblDROITEv.Text = "position gauche";
            // 
            // lblDROITEx
            // 
            this.lblDROITEx.AutoSize = true;
            this.lblDROITEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDROITEx.Location = new System.Drawing.Point(848, 39);
            this.lblDROITEx.Name = "lblDROITEx";
            this.lblDROITEx.Size = new System.Drawing.Size(108, 20);
            this.lblDROITEx.TabIndex = 15;
            this.lblDROITEx.Text = "position droite";
            // 
            // lblGAUCHEx
            // 
            this.lblGAUCHEx.AutoSize = true;
            this.lblGAUCHEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGAUCHEx.Location = new System.Drawing.Point(721, 39);
            this.lblGAUCHEx.Name = "lblGAUCHEx";
            this.lblGAUCHEx.Size = new System.Drawing.Size(121, 20);
            this.lblGAUCHEx.TabIndex = 14;
            this.lblGAUCHEx.Text = "position gauche";
            // 
            // lblHEADx
            // 
            this.lblHEADx.AutoSize = true;
            this.lblHEADx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEADx.Location = new System.Drawing.Point(787, 68);
            this.lblHEADx.Name = "lblHEADx";
            this.lblHEADx.Size = new System.Drawing.Size(77, 20);
            this.lblHEADx.TabIndex = 16;
            this.lblHEADx.Text = "lblHEADx";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(615, 396);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 17;
            this.btnrefresh.Text = "refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            // 
            // lblPINCEupdown
            // 
            this.lblPINCEupdown.AutoSize = true;
            this.lblPINCEupdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPINCEupdown.Location = new System.Drawing.Point(744, 291);
            this.lblPINCEupdown.Name = "lblPINCEupdown";
            this.lblPINCEupdown.Size = new System.Drawing.Size(33, 46);
            this.lblPINCEupdown.TabIndex = 21;
            this.lblPINCEupdown.Text = "-";
            // 
            // lblPINCEopenclose
            // 
            this.lblPINCEopenclose.AutoSize = true;
            this.lblPINCEopenclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPINCEopenclose.Location = new System.Drawing.Point(798, 291);
            this.lblPINCEopenclose.Name = "lblPINCEopenclose";
            this.lblPINCEopenclose.Size = new System.Drawing.Size(33, 46);
            this.lblPINCEopenclose.TabIndex = 22;
            this.lblPINCEopenclose.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(454, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 5);
            this.label1.TabIndex = 23;
            this.label1.Text = "_____________________________________________________________";
            // 
            // panelVitesse
            // 
            this.panelVitesse.Location = new System.Drawing.Point(5, 5);
            this.panelVitesse.Name = "panelVitesse";
            this.panelVitesse.Size = new System.Drawing.Size(165, 600);
            this.panelVitesse.TabIndex = 24;
            this.panelVitesse.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVitesse_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(963, 635);
            this.Controls.Add(this.panelVitesse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPINCEopenclose);
            this.Controls.Add(this.lblPINCEupdown);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.lblHEADx);
            this.Controls.Add(this.lblDROITEx);
            this.Controls.Add(this.lblGAUCHEx);
            this.Controls.Add(this.lblGAUCHEv);
            this.Controls.Add(this.lblDROITEv);
            this.Controls.Add(this.lblGAUCHEref);
            this.Controls.Add(this.lblDROITEref);
            this.Controls.Add(this.lblDROITE1);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.lblGAUCHE1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "K-Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGAUCHE1;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Label lblDROITE1;
        private System.Windows.Forms.Label lblGAUCHEref;
        private System.Windows.Forms.Label lblDROITEref;
        private System.Windows.Forms.Label lblGAUCHEv;
        private System.Windows.Forms.Label lblDROITEv;
        private System.Windows.Forms.Label lblDROITEx;
        private System.Windows.Forms.Label lblGAUCHEx;
        private System.Windows.Forms.Label lblHEADx;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPINCEupdown;
        private System.Windows.Forms.Label lblPINCEopenclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVitesse;
        private System.Windows.Forms.Timer timer1;
    }
}

