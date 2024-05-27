using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Giới Thiệu"; //hiển thị tên cho form
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e) {}
        private void button1_Click(object sender, EventArgs e)
        {
            InputMatrix f = new InputMatrix(); //tạo biến f là form nhập ma trận
            f.Show(); //mở form nhập ma trận ra
            //this.Close();
        }
        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = "C:/Hướng dẫn – FordBellman – Nhóm Sunflower.docx"; //đường dẫn tới tệp hướng dẫn sử dụng
            Process.Start(a); //mở tệp
        }
    }
}
