using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpecialCourse
{
    public class Helper
    {
        public string[] OpenFile(string filePath,ref RichTextBox rtbBaseFile)
        {
            StringBuilder fileString = new StringBuilder();

            int numberString = 0;
            string[] baseTextMassive = File.ReadAllLines(filePath);
            foreach (string st in baseTextMassive)
            {
                fileString.AppendLine(numberString+") "+st);
                numberString++;
            }
            rtbBaseFile.Text = fileString.ToString();
            return baseTextMassive;
        }

        public String Generator(String[] textMassive,ref TextBox resultTb, ref RichTextBox rtbBaseFile, ref double qStep, int level = 0, bool needQuantizationСheckBox = false)
        {


            int check = 0; //чек элементов
            int window = 1; //первоначальный размер окна
            int i = 1; //окно движется с первого элемента
            string errorMessage = string.Empty;
            double[] qMassive = new double[textMassive.Length];
           



            #region //Переквантовка

            if (needQuantizationСheckBox)
            {
                StringBuilder qFileString = new StringBuilder();
                for (int j = 0; j < qMassive.Length; j++)
                {
                    string convertString = textMassive[j].Replace(".", ",");
                    if (convertString == string.Empty)
                        convertString = "0";
                    qMassive[j] = double.Parse(convertString);

                }
                double min = qMassive.Min();
                double max = qMassive.Max();
                var levelStep = (max - min) / level;
                qStep = levelStep;


                for (int j = 0; j < qMassive.Length; j++)
                {
                    textMassive[j] = ((int)(Math.Round((qMassive[j]- min) / levelStep))).ToString(CultureInfo.InvariantCulture);
                    qFileString.AppendLine(j + ") " + qMassive[j] + " --> " + textMassive[j]);
                }
                rtbBaseFile.Clear();
                rtbBaseFile.Text = qFileString.ToString();
            }


            #endregion

            #region // цикл
            if (window <= textMassive.Length - window && i <= textMassive.Length - window)
            {
                while (i < textMassive.Length - window)
                {
                    string[] stringLineMassive = new string[window];
                    for (int j = 0; j < window; j++)
                    {
                        Array.Copy(textMassive, i, stringLineMassive, 0, window);
                        if (textMassive[j] != textMassive[j + i])
                        {
                            break;
                        }
                        check++;
                    }
                    if (check == window)
                    {
                        window++;
                        int numDuplicate = i; // номер дублирующего элемента
                        var errorLine = String.Join(",", stringLineMassive
                            .Select(s => s.ToString())
                            .ToArray()); //строка элементов с повторением
                        errorMessage += "Последовательность: " + errorLine + " повторяется с " + numDuplicate +
                                        " строки \r\n";
                        check = 0;
                        i = 1;
                    }
                    else i++;
                }
            }
            #endregion
            resultTb.Text = window.ToString();
            return errorMessage + "Конечный размер окна " + window;
        }
    }
}
