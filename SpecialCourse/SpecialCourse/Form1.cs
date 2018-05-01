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

namespace SpecialCourse
{
    public partial class BaseForm : Form
    {
        String[] baseText;
        string fileName = String.Empty;
        string fileString = String.Empty;
        Helper Help = new Helper();


        public BaseForm()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Filter = "text files | *.txt;| All files(*.*)|*.*"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    rtbBaseFile.Clear();
                    fileName = dialog.FileName;
                    baseText = Help.OpenFile(fileName, out fileString);
                    fileWayText.Text = fileName;
                    rtbBaseFile.Text = fileString;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки файла");
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                rtbBaseFile.Clear();
                fileName = fileWayText.Text;
                baseText = Help.OpenFile(fileName, out fileString);
                rtbBaseFile.Text = fileString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки файла");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Help.Generator(baseText);
        }
    }
}
