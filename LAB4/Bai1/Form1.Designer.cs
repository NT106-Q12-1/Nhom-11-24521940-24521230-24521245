namespace Bai1
{
    partial class Form1
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
            this.btn_Get = new System.Windows.Forms.Button();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.rtb_html = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(634, 18);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(108, 42);
            this.btn_Get.TabIndex = 5;
            this.btn_Get.Text = "GET";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // tb_URL
            // 
            this.tb_URL.Location = new System.Drawing.Point(30, 26);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(540, 26);
            this.tb_URL.TabIndex = 4;
            // 
            // rtb_html
            // 
            this.rtb_html.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_html.Location = new System.Drawing.Point(12, 82);
            this.rtb_html.Name = "rtb_html";
            this.rtb_html.ReadOnly = true;
            this.rtb_html.Size = new System.Drawing.Size(776, 351);
            this.rtb_html.TabIndex = 3;
            this.rtb_html.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Get);
            this.Controls.Add(this.tb_URL);
            this.Controls.Add(this.rtb_html);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.TextBox tb_URL;
        private System.Windows.Forms.RichTextBox rtb_html;
    }
}

