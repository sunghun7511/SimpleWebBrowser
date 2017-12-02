namespace SimpleWebBrowser {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PreviousBox = new System.Windows.Forms.PictureBox();
            this.NextBox = new System.Windows.Forms.PictureBox();
            this.RefreshBox = new System.Windows.Forms.PictureBox();
            this.HomeBox = new System.Windows.Forms.PictureBox();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.SearchBox = new System.Windows.Forms.PictureBox();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.CaptureBox = new System.Windows.Forms.PictureBox();
            this.DownloadBox = new System.Windows.Forms.PictureBox();
            this.GoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviousBox
            // 
            this.PreviousBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PreviousBox.Image = ((System.Drawing.Image)(resources.GetObject("PreviousBox.Image")));
            this.PreviousBox.Location = new System.Drawing.Point(12, 12);
            this.PreviousBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PreviousBox.Name = "PreviousBox";
            this.PreviousBox.Size = new System.Drawing.Size(29, 29);
            this.PreviousBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviousBox.TabIndex = 0;
            this.PreviousBox.TabStop = false;
            this.PreviousBox.Click += new System.EventHandler(this.PreviousBox_Click);
            // 
            // NextBox
            // 
            this.NextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.NextBox.Image = ((System.Drawing.Image)(resources.GetObject("NextBox.Image")));
            this.NextBox.Location = new System.Drawing.Point(47, 12);
            this.NextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextBox.Name = "NextBox";
            this.NextBox.Size = new System.Drawing.Size(29, 29);
            this.NextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextBox.TabIndex = 3;
            this.NextBox.TabStop = false;
            this.NextBox.Click += new System.EventHandler(this.NextBox_Click);
            // 
            // RefreshBox
            // 
            this.RefreshBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.RefreshBox.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBox.Image")));
            this.RefreshBox.Location = new System.Drawing.Point(82, 12);
            this.RefreshBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshBox.Name = "RefreshBox";
            this.RefreshBox.Size = new System.Drawing.Size(29, 29);
            this.RefreshBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RefreshBox.TabIndex = 4;
            this.RefreshBox.TabStop = false;
            this.RefreshBox.Click += new System.EventHandler(this.RefreshBox_Click);
            // 
            // HomeBox
            // 
            this.HomeBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.HomeBox.Image = ((System.Drawing.Image)(resources.GetObject("HomeBox.Image")));
            this.HomeBox.Location = new System.Drawing.Point(117, 12);
            this.HomeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeBox.Name = "HomeBox";
            this.HomeBox.Size = new System.Drawing.Size(29, 29);
            this.HomeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBox.TabIndex = 5;
            this.HomeBox.TabStop = false;
            this.HomeBox.Click += new System.EventHandler(this.HomeBox_Click);
            // 
            // UrlBox
            // 
            this.UrlBox.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UrlBox.Location = new System.Drawing.Point(152, 12);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(904, 29);
            this.UrlBox.TabIndex = 6;
            this.UrlBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlBox_KeyDown);
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(12, 48);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(1229, 655);
            this.Browser.TabIndex = 7;
            // 
            // SearchBox
            // 
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchBox.Image")));
            this.SearchBox.Location = new System.Drawing.Point(1107, 12);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(29, 29);
            this.SearchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchBox.TabIndex = 8;
            this.SearchBox.TabStop = false;
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            // 
            // ExitBox
            // 
            this.ExitBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitBox.Image")));
            this.ExitBox.Location = new System.Drawing.Point(1212, 12);
            this.ExitBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(29, 29);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBox.TabIndex = 9;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // CaptureBox
            // 
            this.CaptureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CaptureBox.Image = ((System.Drawing.Image)(resources.GetObject("CaptureBox.Image")));
            this.CaptureBox.Location = new System.Drawing.Point(1142, 12);
            this.CaptureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CaptureBox.Name = "CaptureBox";
            this.CaptureBox.Size = new System.Drawing.Size(29, 29);
            this.CaptureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CaptureBox.TabIndex = 10;
            this.CaptureBox.TabStop = false;
            this.CaptureBox.Click += new System.EventHandler(this.CaptureBox_Click);
            // 
            // DownloadBox
            // 
            this.DownloadBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DownloadBox.Image = ((System.Drawing.Image)(resources.GetObject("DownloadBox.Image")));
            this.DownloadBox.Location = new System.Drawing.Point(1177, 12);
            this.DownloadBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DownloadBox.Name = "DownloadBox";
            this.DownloadBox.Size = new System.Drawing.Size(29, 29);
            this.DownloadBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownloadBox.TabIndex = 11;
            this.DownloadBox.TabStop = false;
            // 
            // GoBox
            // 
            this.GoBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.GoBox.Image = ((System.Drawing.Image)(resources.GetObject("GoBox.Image")));
            this.GoBox.Location = new System.Drawing.Point(1062, 13);
            this.GoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoBox.Name = "GoBox";
            this.GoBox.Size = new System.Drawing.Size(29, 29);
            this.GoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoBox.TabIndex = 12;
            this.GoBox.TabStop = false;
            this.GoBox.Click += new System.EventHandler(this.GoBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 715);
            this.Controls.Add(this.GoBox);
            this.Controls.Add(this.DownloadBox);
            this.Controls.Add(this.CaptureBox);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.HomeBox);
            this.Controls.Add(this.RefreshBox);
            this.Controls.Add(this.NextBox);
            this.Controls.Add(this.PreviousBox);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "SimpleWebBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviousBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PreviousBox;
        private System.Windows.Forms.PictureBox NextBox;
        private System.Windows.Forms.PictureBox RefreshBox;
        private System.Windows.Forms.PictureBox HomeBox;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.PictureBox SearchBox;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.PictureBox CaptureBox;
        private System.Windows.Forms.PictureBox DownloadBox;
        private System.Windows.Forms.PictureBox GoBox;
    }
}

