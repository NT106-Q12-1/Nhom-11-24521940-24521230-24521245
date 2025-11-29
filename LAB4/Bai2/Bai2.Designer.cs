namespace Bai2
{
    partial class Bai2
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
            this.btn_Download = new System.Windows.Forms.Button();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.rtb_html = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(626, 30);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(108, 42);
            this.btn_Download.TabIndex = 8;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // tb_URL
            // 
            this.tb_URL.Location = new System.Drawing.Point(26, 38);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(540, 26);
            this.tb_URL.TabIndex = 7;
            this.tb_URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_URL_KeyDown);
            // 
            // rtb_html
            // 
            this.rtb_html.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_html.Location = new System.Drawing.Point(12, 120);
            this.rtb_html.Name = "rtb_html";
            this.rtb_html.ReadOnly = true;
            this.rtb_html.Size = new System.Drawing.Size(776, 301);
            this.rtb_html.TabIndex = 6;
            this.rtb_html.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.tb_URL);
            this.Controls.Add(this.rtb_html);
            this.Name = "Bai2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.TextBox tb_URL;
        private System.Windows.Forms.RichTextBox rtb_html;
    }
}

