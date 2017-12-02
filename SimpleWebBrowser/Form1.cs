using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWebBrowser {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void GoToSite(string url) {
            if (url == null || url.Equals("")) {
                MessageBox.Show("URL 이 올바르지 않습니다.");
                return;
            }
            if (!url.StartsWith("http://")) {
                url = "http://" + url;
            }
            this.Browser.Url = new Uri(url);
        }

        private void ExitBox_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void SearchBox_Click(object sender, EventArgs e) {
            GoToSite("http://search.google.com/?q=" + this.UrlBox.Text);
        }

        private void GoBox_Click(object sender, EventArgs e) {
            GoToSite(this.UrlBox.Text);
        }

        private void HomeBox_Click(object sender, EventArgs e) {
            this.Browser.Url = new Uri("http://www.naver.com");
        }

        private void RefreshBox_Click(object sender, EventArgs e) {
            string url;
            Uri uri = this.Browser.Url;
            if (uri == null || uri.ToString().Equals("")) {
                url = "http://www.naver.com";
            } else {
                url = uri.ToString();
            }
            GoToSite(url);
        }

        private void UrlBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                GoToSite(this.UrlBox.Text);
            }
        }

        private void PreviousBox_Click(object sender, EventArgs e) {
            if (Browser.CanGoBack) {
                Browser.GoBack();
            } else {
                MessageBox.Show("더 이상 뒤로갈 수 없습니다.");
            }
        }

        private void NextBox_Click(object sender, EventArgs e) {
            if (Browser.CanGoForward) {
                Browser.GoForward();
            } else {
                MessageBox.Show("더 이상 뒤로갈 수 없습니다.");
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            GoToSite("http://www.google.com/");
        }

        private void CaptureBox_Click(object sender, EventArgs e) {
            string path = @"C:\";
            FolderBrowserDialog file = new FolderBrowserDialog();
            if (file.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(file.SelectedPath)) {
                path = file.SelectedPath;
                path = path + DateTime.Now.ToString("yyyy_mm_dd_hh_MM_ss") + ".png";

                // path -> save

                MessageBox.Show("\"" + path + "\"에 저장하였습니다!");
            } else {
                MessageBox.Show("취소되었습니다!");
            }
        }
    }
}
