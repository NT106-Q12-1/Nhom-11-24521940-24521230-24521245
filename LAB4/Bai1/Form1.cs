using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getHTML(string szUrl)
        {
            try
            {
                WebRequest request = WebRequest.Create(szUrl);
                // Get the response.
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Close the response.
                response.Close();
                return responseFromServer;
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Địa chỉ URL không hợp lệ. Vui lòng kiểm tra lại định dạng.", "Lỗi URI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            catch (WebException ex)
            {
                MessageBox.Show($"Lỗi kết nối hoặc HTTP: {ex.Message}", "Lỗi WebException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi không xác định: {ex.Message}", "Lỗi Chung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }



        private void btn_Get_Click(object sender, EventArgs e)
        {
            string text = tb_URL.Text.Trim();
            if (string.IsNullOrEmpty(tb_URL.Text))
            {
                MessageBox.Show("Chưa Nhập Địa Chỉ Đường Dẫn", "Thiếu Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int Index = text.IndexOf("://");

            if (Index > 0)
            {
                tb_URL.Text = "https://" + text.Substring(Index + 3);
            }
            else
            {
                tb_URL.Text = "https://" + text;
            }
            rtb_html.Clear();
            rtb_html.AppendText(getHTML(tb_URL.Text));
        }
    }
}
