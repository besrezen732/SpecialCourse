using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpecialCourse
{
    public class Helper
    {
        public string[] OpenFile(string filePath, out string fileString)
        {
            fileString = String.Empty;
            string[] baseTextMassive = File.ReadAllLines(filePath);
            foreach (string st in baseTextMassive)
            {
                fileString += st + "\r\n";
            }
            return baseTextMassive;
        }

        public String Generator(String[] textMassive,ref TextBox resultTb, int level = 0, bool needQuantizationСheckBox = false)
        {


            int check = 0; //чек элементов
            int window = 1; //первоначальный размер окна
            int i = 1; //окно движется с первого элемента
            string errorMessage = string.Empty;
            double[] qMassive = new double[textMassive.Length];
            double[] levelMassive = new double[level];




            #region //Переквантовка

            if (needQuantizationСheckBox)
            {
                for (int j = 0; j < qMassive.Length; j++)
                {
                    string convertString = textMassive[j].Replace(".", ",");
                    qMassive[j] = double.Parse(convertString);

                }
                var levelStep = (qMassive.Max() - qMassive.Min()) / level;

                for (int j = 0; j < level; j++)
                {
                    levelMassive[j] = qMassive.Min() + (levelStep * j);
                }
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
