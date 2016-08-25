namespace ZigBee
{
    partial class DebugForm
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
            this.rTb_out = new System.Windows.Forms.RichTextBox();
            this.rTb_in = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_out = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTb_out
            // 
            this.rTb_out.Location = new System.Drawing.Point(12, 43);
            this.rTb_out.Name = "rTb_out";
            this.rTb_out.Size = new System.Drawing.Size(200, 250);
            this.rTb_out.TabIndex = 0;
            this.rTb_out.Text = "";
            // 
            // rTb_in
            // 
            this.rTb_in.Location = new System.Drawing.Point(218, 43);
            this.rTb_in.Name = "rTb_in";
            this.rTb_in.Size = new System.Drawing.Size(200, 250);
            this.rTb_in.TabIndex = 1;
            this.rTb_in.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "In";
            // 
            // tB_out
            // 
            this.tB_out.Location = new System.Drawing.Point(12, 300);
            this.tB_out.Name = "tB_out";
            this.tB_out.Size = new System.Drawing.Size(318, 20);
            this.tB_out.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(343, 297);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(12, 329);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 23);
            this.btn_quit.TabIndex = 7;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 364);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tB_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTb_in);
            this.Controls.Add(this.rTb_out);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugForm";
            this.Text = "Debug ZigBee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTb_out;
        private System.Windows.Forms.RichTextBox rTb_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_out;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_quit;
    }
}