namespace ZigBee
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.serialPortXBEE = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.tB_MAC = new System.Windows.Forms.TextBox();
            this.tB_BAUD = new System.Windows.Forms.TextBox();
            this.btn_atcmd = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 200;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MAC :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "BAUD :";
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(71, 15);
            this.cmbCOMPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(344, 24);
            this.cmbCOMPort.TabIndex = 8;
            this.cmbCOMPort.SelectedIndexChanged += new System.EventHandler(this.cmbCOMPort_SelectedIndexChanged);
            // 
            // tB_MAC
            // 
            this.tB_MAC.Location = new System.Drawing.Point(71, 48);
            this.tB_MAC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_MAC.Name = "tB_MAC";
            this.tB_MAC.Size = new System.Drawing.Size(344, 22);
            this.tB_MAC.TabIndex = 9;
            // 
            // tB_BAUD
            // 
            this.tB_BAUD.Location = new System.Drawing.Point(71, 80);
            this.tB_BAUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_BAUD.Name = "tB_BAUD";
            this.tB_BAUD.Size = new System.Drawing.Size(344, 22);
            this.tB_BAUD.TabIndex = 10;
            // 
            // btn_atcmd
            // 
            this.btn_atcmd.Location = new System.Drawing.Point(20, 119);
            this.btn_atcmd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_atcmd.Name = "btn_atcmd";
            this.btn_atcmd.Size = new System.Drawing.Size(100, 28);
            this.btn_atcmd.TabIndex = 11;
            this.btn_atcmd.Text = "AT CMD";
            this.btn_atcmd.UseVisualStyleBackColor = true;
            this.btn_atcmd.Click += new System.EventHandler(this.btn_atcmd_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(316, 119);
            this.btn_annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(100, 28);
            this.btn_annuler.TabIndex = 12;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(208, 119);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 28);
            this.btn_ok.TabIndex = 13;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 162);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_atcmd);
            this.Controls.Add(this.tB_BAUD);
            this.Controls.Add(this.tB_MAC);
            this.Controls.Add(this.cmbCOMPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.Text = "Option ZigBee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.IO.Ports.SerialPort serialPortXBEE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCOMPort;
        private System.Windows.Forms.TextBox tB_MAC;
        private System.Windows.Forms.TextBox tB_BAUD;
        private System.Windows.Forms.Button btn_atcmd;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_ok;
    }
}

