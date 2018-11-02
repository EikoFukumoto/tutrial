using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCap
{
    public partial class WConfig : Form
    {
        public WConfig()
        {
            InitializeComponent();
        }

        private void WConfig_Load(object sender, EventArgs e)
        {
            textFfmpegPath.Text = "";
            textFfmpegPath.Text = Convert.ToString(Properties.Settings.Default["FfmpegPath"]);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["FfmpegPath"] = textFfmpegPath.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("変更しました。アプリケーションを再起動してください。");
        }
    }
}
