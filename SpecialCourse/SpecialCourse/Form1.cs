using System;
using System.Windows.Forms;

namespace SpecialCourse
{
    public partial class BaseForm : Form
    {
        String[] baseText;
        string _fileName = String.Empty;
        string _fileString = String.Empty;
        readonly Helper _help = new Helper();


        public BaseForm()
        {
            InitializeComponent();
            Generate.Enabled = false;
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
                    _fileName = dialog.FileName;
                    baseText = _help.OpenFile(_fileName, out _fileString, ref Generate);
                    fileWayText.Text = _fileName;
                    rtbBaseFile.Text = _fileString;
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
                _fileName = fileWayText.Text;
                baseText = _help.OpenFile(_fileName, out _fileString, ref Generate);
                rtbBaseFile.Text = _fileString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки файла");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _help.Generator(baseText);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа ревализована в целях спецкурса и не несет в себе практического смысла");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
