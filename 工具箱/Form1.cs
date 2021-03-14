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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("程序将最小化到系统托盘区");
            e.Cancel = true; // 取消关闭窗体 
            this.Hide();
            this.ShowInTaskbar = false;//取消窗体在任务栏的显示 
            this.notifyIcon1.Visible = true;//显示托盘图标 

        }

        private void TransForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
                this.Hide();
                this.ShowInTaskbar = false;
            }
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
        {
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

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("maker:vapts");
            MessageBox.Show("因为路径不同，有需求的话请自行修改");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎使用工具箱！");
        }

        private void 关于本程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("maker:vapts");
            MessageBox.Show("因为路径不同，有需求的话请自行修改");
        }

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\工作\DEV\Dev-Cpp");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\python\idlelib_v3.7\idlelib");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Process.Start(@"E:\Program Files (x86)\Tencent\QMProxyAccelerator\3.0.8801.134");
        }
    }

}
