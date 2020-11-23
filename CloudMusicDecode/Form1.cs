using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudMusicDecode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseInputPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "选择文件";
            fileDialog.Filter = "uc缓存文件(*.uc)|*.uc";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                inputPath.Text = fileDialog.FileName;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void chooseOutPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "选择保存路径";
            fileDialog.Filter = "音频文件(*.mp4)|*.mp4";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                outPath.Text = fileDialog.FileName;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                outPath.Enabled = false;
                if(inputPath.Text != "")
                {
                    int length = inputPath.Text.Length;
                    string str = inputPath.Text.Substring(0, length-3);
                    outPath.Text = str + ".mp4";
                }      
            }
            else
            {
                outPath.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            

            if (inputPath.Text == "" || outPath.Text == "")
            {
                MessageBox.Show("请选择正确的文件路径！", "错误", MessageBoxButtons.OK);
            }
            else
            {
                FileStream inputFile = new FileStream(inputPath.Text, FileMode.Open);
                FileStream outputFile = new FileStream(outPath.Text, FileMode.Create, FileAccess.Write);
                byte[] buf = new byte[1024];

                progressBar1.Visible = true;
                progressBar1.Minimum = 1;
                progressBar1.Maximum = (int)new FileInfo(inputPath.Text).Length;
                progressBar1.Step = 1024;

                while (true)
                {
                    int len = inputFile.Read(buf, 0, buf.Length);
                    if(len > 0)
                    {
                        for (int i = 0; i < len; i++)
                        {
                            buf[i] ^= 0xa3;
                        }
                        outputFile.Write(buf, 0, len);
                    }
                    else
                    {
                        break;
                    }
                    startProgress();
                }
                outputFile.Close();
                inputFile.Close();
                
            }
        }

        private void startProgress()
        {
            progressBar1.PerformStep();
        }
    }
}
