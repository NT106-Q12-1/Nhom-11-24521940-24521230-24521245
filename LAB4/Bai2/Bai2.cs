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

namespace Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
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
                return string.Empty; // Trả về chuỗi rỗng khi lỗi
            }
            catch (WebException ex)
            {
                // Hiển thị thông báo lỗi mạng (404, không kết nối, timeout...)
                MessageBox.Show($"Lỗi kết nối hoặc HTTP: {ex.Message}", "Lỗi WebException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            catch (Exception ex)
            {
                // Bắt các lỗi chung khác
                MessageBox.Show($"Đã xảy ra lỗi không xác định: {ex.Message}", "Lỗi Chung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;

            }
        }
        private void Download(string url, string fileurl)
        {
            WebClient client = new WebClient();
            client.DownloadFile(url, fileurl);
        }
        private void btn_Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            try
            {
                Download(tb_URL.Text, saveFileDialog.FileName + ".html");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex}");
                return;
            }
        }

        private void tb_URL_KeyDown(object sender, KeyEventArgs e)
        {
            string text = tb_URL.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (string.IsNullOrEmpty(tb_URL.Text))
                {
                    MessageBox.Show("Vui lòng nhập URL trước khi nhấn Enter.");
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
                rtb_html.Text = getHTML(tb_URL.Text);
            }
        }

    }
}
