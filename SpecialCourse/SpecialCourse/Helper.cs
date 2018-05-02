using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpecialCourse
{
    public class Helper
    {
        public string[] OpenFile(string filePath, out string fileString, ref Button Generate )
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
            int check = 0;//чек элементов
            int window = 1;//первоначальный размер окна
            int i = 1; //окно движется с первого элемента
            string errorLine = string.Empty;//строка элементов с повторением
            string result = string.Empty;// результирующее окно

            string errorMessage = string.Empty;


            for (; window <= textMassive.Length - window; window++)
            {

                for (; i < textMassive.Length - window; i++) 
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
                    if (check != window) continue;

                    window++;
                    int numDuplicate = i;
                    check = 0;
                    i = 0;

                    errorLine = String.Join(",", stringLineMassive
                        .Select(s => s.ToString())
                        .ToArray());
                    errorMessage += "Последовательность: " + errorLine + "повторяется с " + numDuplicate + " строки \r\n";
                }
                string[] resultWindowMassive = new string[window];
                Array.Copy(textMassive, i, resultWindowMassive, 0, window);
                result = String.Join(",", resultWindowMassive
                    .Select(s => s.ToString())
                    .ToArray());
            }
            return (errorMessage + "Конечный размер окна " + window + " Окно " + result ).ToString();
        }
    }
}
