using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;

namespace MovieCap
{
    public partial class WMain : Form
    {
        public WMain()
        {
            InitializeComponent();
        }
        public enum WMPPlayState
        {
            wmppsUndefined = 0,
            wmppsStopped = 1,
            wmppsPaused = 2,
            wmppsPlaying = 3,
            wmppsScanForward = 4,
            wmppsScanReverse = 5,
            wmppsBuffering = 6,
            wmppsWaiting = 7,
            wmppsMediaEnded = 8,
            wmppsTransitioning = 9,
            wmppsReady = 10,
            wmppsReconnecting = 11,
            wmppsLast = 12,
        }

        static string InputMoviePath;
        static string OutputCapPath;

        //ffmpeg
        //static readonly string FfmpegPath = @"E:\Lib\ffmpeg-3.4.2-win64-static\bin\ffmpeg.exe";
        static string FfmpegPath;


        public class ImageExtractor
        {

            /// <summary>動画ファイルからパイプを用いて画像を抽出する</summary> 
            public Image ExtractImageByPipe(string inputMoviePath, TimeSpan extractTime)
            {
                var arguments = $"-ss {extractTime.TotalSeconds} -i \"{inputMoviePath}\" -vframes 1 -f image2 pipe:1";


                using (var process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = FfmpegPath,
                        Arguments = arguments,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                    };
                    process.Start();
                    var image = Image.FromStream(process.StandardOutput.BaseStream);
                    process.WaitForExit();
                    return image;
                }
            }
        }

        private void WMain_Load(object sender, EventArgs e)
        {
            FfmpegPath = Convert.ToString(Properties.Settings.Default["FfmpegPath"]);

            //Ffmpegのファイルの存在チェック
            if (System.IO.File.Exists(FfmpegPath))
            {
                //URLプロパティが指定されたら自動的に再生されないようにする
                axWindowsMediaPlayer1.settings.autoStart = false;
            }
            else
            {
                MessageBox.Show("Ffmegファイルが見つかりません　" + FfmpegPath);
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

            //キャプチャ位置のポジション（秒）を取得
            double mm = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            //キャプチャ位置のポジション（mm:ss）を取得
            string ss = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

            //1時間以内のポジションの場合頭にに00をつける
            if (ss.Length == 5)
                ss = "00:" + ss;

            if (System.IO.Directory.Exists(OutputCapPath))
            {
            }
            else
            {
                //DirectoryInfoオブジェクトを作成する
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@OutputCapPath);
                //フォルダを作成する
                di.Create();
            }

            // パイプを使って指定時間の画像を一枚抽出する 
            var image = new ImageExtractor().ExtractImageByPipe(InputMoviePath, TimeSpan.FromSeconds(mm));
            image.Save(@OutputCapPath + "\\Cap_" + ss.Replace(':', '-') + ".jpg");


        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            //キャプチャ元のファイルを選択する
            openFileDialog1.FileName = "";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                @textFromFilePath.Text = openFileDialog1.FileName;

                //Capフォルダの作成
                CapFolderCreate();
            }
        }

        private void textFromFilePath_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void textFromFilePath_DragDrop(object sender, DragEventArgs e)
        {
            //コントロール内にドロップされたとき実行される
            //ドロップされたすべてのファイル名を取得する
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string f in fileName)
            {
                textFromFilePath.Text = f;
                break;  //はじめの１つのみ
            }

            //Capフォルダの作成
            CapFolderCreate();
        }

        void CapFolderCreate()
        {
            InputMoviePath = @textFromFilePath.Text;
            string FolderName = (System.DateTime.Now).ToString("yyyyMMddHHmm");

            //フォルダ名を取得
            @textToFilePath.Text = System.IO.Path.GetDirectoryName(InputMoviePath) + @"\Cap" + FolderName;
            //オーディオファイルを指定する（自動的に再生される）
            axWindowsMediaPlayer1.URL = InputMoviePath;

            OutputCapPath = @textToFilePath.Text;

        }

        private void btnFileDialog2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXPLORER.EXE", @OutputCapPath);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InputMoviePath = "";
            OutputCapPath = "";

            textToFilePath.Text = "";
            textFromFilePath.Text = "";

            axWindowsMediaPlayer1.currentPlaylist.clear();

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            //環境設定画面開く
            WConfig frm = new WConfig();
            frm.ShowDialog();

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void axWindowsMediaPlayer1_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            //動画の長さを取得
            switch(e.newState)
            {
                case 13:    //メディアが開いている状態
                    string aa = axWindowsMediaPlayer1.currentMedia.durationString;
                    break;
                    

            } 


        }
    }
}
