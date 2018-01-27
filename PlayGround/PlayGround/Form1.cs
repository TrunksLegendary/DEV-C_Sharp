using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PlayGround
{
    public partial class MyC_PlayGround : Form
    {
        public MyC_PlayGround()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_FileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtB_Output.Text = File.ReadAllText(openFileDialog1.FileName);
            }



        }

        private void TxtB_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtB_Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_Output_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Input_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Process_Click(object sender, EventArgs e)
        {
            TxtB_Output.Text = TxtB_Input.Text;
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            TxtB_Input.Text = "";
            TxtB_Output.Text = "";
        }
    }

}
