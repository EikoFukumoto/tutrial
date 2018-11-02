namespace MovieCap
{
    partial class WMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMain));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnCapture = new System.Windows.Forms.Button();
            this.textFromFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileDialog1 = new System.Windows.Forms.Button();
            this.textToFilePath = new System.Windows.Forms.TextBox();
            this.btnFileDialog2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(960, 605);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.axWindowsMediaPlayer1_OpenStateChange);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(223, 573);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(67, 25);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "キャプチャ";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // textFromFilePath
            // 
            this.textFromFilePath.AllowDrop = true;
            this.textFromFilePath.Location = new System.Drawing.Point(97, 13);
            this.textFromFilePath.Name = "textFromFilePath";
            this.textFromFilePath.Size = new System.Drawing.Size(507, 19);
            this.textFromFilePath.TabIndex = 2;
            this.textFromFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textFromFilePath_DragDrop);
            this.textFromFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textFromFilePath_DragEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileDialog1
            // 
            this.btnFileDialog1.Location = new System.Drawing.Point(622, 9);
            this.btnFileDialog1.Name = "btnFileDialog1";
            this.btnFileDialog1.Size = new System.Drawing.Size(54, 23);
            this.btnFileDialog1.TabIndex = 3;
            this.btnFileDialog1.Text = "参照";
            this.btnFileDialog1.UseVisualStyleBackColor = true;
            this.btnFileDialog1.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // textToFilePath
            // 
            this.textToFilePath.Location = new System.Drawing.Point(97, 47);
            this.textToFilePath.Name = "textToFilePath";
            this.textToFilePath.ReadOnly = true;
            this.textToFilePath.Size = new System.Drawing.Size(507, 19);
            this.textToFilePath.TabIndex = 4;
            // 
            // btnFileDialog2
            // 
            this.btnFileDialog2.Location = new System.Drawing.Point(622, 45);
            this.btnFileDialog2.Name = "btnFileDialog2";
            this.btnFileDialog2.Size = new System.Drawing.Size(105, 23);
            this.btnFileDialog2.TabIndex = 5;
            this.btnFileDialog2.Text = "Capフォルダを開く";
            this.btnFileDialog2.UseVisualStyleBackColor = true;
            this.btnFileDialog2.Click += new System.EventHandler(this.btnFileDialog2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFileDialog2);
            this.panel1.Controls.Add(this.textFromFilePath);
            this.panel1.Controls.Add(this.textToFilePath);
            this.panel1.Controls.Add(this.btnFileDialog1);
            this.panel1.Location = new System.Drawing.Point(12, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 83);
            this.panel1.TabIndex = 6;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(12, 43);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 8;
            this.btnConfig.Text = "環境設定";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "映像ファイル";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(773, 668);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(874, 668);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 35);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // WMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 715);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WMain";
            this.Text = "MovieCap";
            this.Load += new System.EventHandler(this.WMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TextBox textFromFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileDialog1;
        private System.Windows.Forms.TextBox textToFilePath;
        private System.Windows.Forms.Button btnFileDialog2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnEnd;
    }
}