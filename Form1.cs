using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 工具箱
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\百度网盘\BaiduNetdisk\BaiduNetdisk.exe");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\BaiduNetdiskDownload\Cheat Engine 7.0\Cheat Engine.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\PS\Adobe Photoshop CC 2018\Photoshop.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DW\Adobe Dreamweaver 2020\Dreamweaver.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\FormatFactory\FormatFactory.exe");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\UU\Netease\UU");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"steam://rungameid/795630");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\QQ\Bin\QQScLauncher.exe");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\微信\WeChat\WeChat.exe");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\vs\Common7\IDE\devenv.exe");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\steam\Steam.exe");
        }

        private void button13_Click(object sender, EventArgs e)
        {//???
            Process.Start(@"D:\网易云音乐\CloudMusic\cloudmusic.exe");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\腾讯课堂\TXEDU\2.0.0.17\bin\TXEDU.exe");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\LR\Adobe Lightroom Classic CC\Lightroom.exe");
        }

        private void button15_Click(object sender, EventArgs e)
        {
           //后续添加
        }
    }
}
