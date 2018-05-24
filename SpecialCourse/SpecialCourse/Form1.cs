using System;
using System.Windows.Forms;

namespace SpecialCourse
{
    public partial class BaseForm : Form
    {
        String[] baseText;
        string _fileName = String.Empty;
       

        private int level = 0;
        readonly Helper _help = new Helper();


        public BaseForm()
        {
            InitializeComponent();
            Generate.Enabled = false;
            needQuantizationСheckBox.Enabled = false;
            richTextBox1.Enabled = false;
            answerTextBox.Enabled = false;
            qStepTb.Enabled = false;
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
                    baseText = _help.OpenFile(_fileName, ref rtbBaseFile);
                    if (baseText != null)
                    {
                        Generate.Enabled = true;
                        needQuantizationСheckBox.Enabled = true;
                    }
                    fileWayText.Text = _fileName;
                  
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
                baseText = _help.OpenFile(_fileName, ref rtbBaseFile);
                if (baseText != null)
                {
                    Generate.Enabled = true;
                    needQuantizationСheckBox.Enabled = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки файла");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double qStep = 0.0;
            if (needQuantizationСheckBox.Checked)
            {
                level = Convert.ToInt32(levelNumberTextBox.Text);
                if (level > 1000)
                    MessageBox.Show("Число уровней квантования не должно превышать 1000");
                else
                    richTextBox1.Text = _help.Generator(baseText, ref answerTextBox, ref rtbBaseFile, ref qStep, level,
                        needQuantizationСheckBox.Checked);
                qStepTb.Text = qStep.ToString();
            }
            else
                richTextBox1.Text = _help.Generator(baseText, ref answerTextBox,ref rtbBaseFile,ref qStep);

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа ревализована в целях спецкурса и не несет в себе практического смысла");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void needQuantizationСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            levelNumberTextBox.Enabled = needQuantizationСheckBox.Checked;
        }

        private void levelNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((!Char.IsDigit(number)))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == (char) Keys.Back) || e.KeyChar == (char) Keys.Delete)
            {
                e.Handled = false;
            }
        }

       

        private void сохранитьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                SaveFileDialog save = new SaveFileDialog();
                save.Title = ("Сохранить как...");
                save.Filter = "Text Document (*.txt) | *.txt| All Files (*.*)|*.*";
                save.OverwritePrompt = true;
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = save.FileName;
                }
         

        }
    }
}
