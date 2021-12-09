using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_1204007_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((lk.Checked == true || pr.Checked == true) && NIM.Text != "" && nama.Text != "" && alamat.Text != "" && progcb.Text != "" && thak.Text != "" && semes.Text != "")
            {
                Size = new Size(710, 607);
                if (k2006.Checked == true)
                {
                    matkul.Enabled = true;
                    checkBox12.Enabled = false;
                    checkBox9.Enabled = false;
                }
                else if (k2010.Checked == true)
                {
                    matkul.Enabled = true;
                    mtk.Enabled = false;
                    checkBox9.Enabled = false;
                }

                else if (k2014.Checked == true)
                {
                    matkul.Enabled = true;
                    mtk.Enabled = false;
                    checkBox12.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kelas = " ";
            if (mtk.Checked) { kelas += mtk.Text; }
            if (pem1.Checked) { kelas += pem1.Text; }
            if (checkBox10.Checked) { kelas += checkBox10.Text; }
            if (checkBox11.Checked) { kelas += checkBox11.Text; }
            if (checkBox12.Checked) { kelas += checkBox12.Text; }
            if (checkBox3.Checked) { kelas += checkBox3.Text; }
            if (checkBox4.Checked) { kelas += checkBox4.Text; }
            if (checkBox5.Checked) { kelas += checkBox5.Text; }
            if (checkBox6.Checked) { kelas += checkBox6.Text; }
            if (checkBox7.Checked) { kelas += checkBox7.Text; }
            if (checkBox8.Checked) { kelas += checkBox8.Text; }
            if (checkBox9.Checked) { kelas += checkBox9.Text; }
            string jk = lk.Checked == true ? lk.Text : pr.Text;
            string kuri = "";
            if (k2006.Checked) { kuri = k2006.Text; } else if (k2010.Checked) { kuri = k2010.Text; } else if (k2014.Checked) { kuri = k2014.Text; }
            string message = String.Format("NIM : {0}\nNama : {1}\nJenis Kelamin : {2}\nAlamat : {3}\nProgram Studi : {4}\nTahun Akademik : {5}\nSemester : {6}\nKurikulum : {7}\nKelas : {8}\n", NIM.Text, nama.Text, jk, alamat.Text, pr.Text, thak.Text, semes.Text, kuri, kelas);
            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
