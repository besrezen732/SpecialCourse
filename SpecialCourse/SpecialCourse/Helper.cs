using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpecialCourse
{
    public class Helper
    {
        public string[] OpenFile(string filePath, out string fileString, ref Button Generate)
        {
            fileString = String.Empty;
            string[] baseTextMassive = File.ReadAllLines(filePath);
            foreach (string st in baseTextMassive)
            {
                fileString += st + "\r\n";
            }
            Generate.Enabled = true;
            return baseTextMassive;
        }

        public String Generator(String[] textMassive)
        {
            int check = 0; //чек элементов
            int window = 1; //первоначальный размер окна
            int i = 1; //окно движется с первого элемента
            string errorMessage = string.Empty;

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
                        i = 0;
                    }
                    else i++;
                }
            }
            return errorMessage + "Конечный размер окна " + window;
        }
    }
}
