using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialCourse
{
    public class Helper
    {
        public string[] OpenFile(string filePath, out string fileString)
        {
            fileString = String.Empty;
            string[] baseTextMassive = File.ReadAllLines(filePath);
            for (int i = 0; i < baseTextMassive.Length; i++)
            {
                fileString += baseTextMassive[i] + "\r\n";
            }
            return baseTextMassive;
        }

        public String Generator(String[] textMassive)
        {
            int check = 0;
            int window = 1;
            string stringLine = string.Empty;

            for (; window <= textMassive.Length - window; window++) // размера окна
            {
                for (int i = 1; i < textMassive.Length - window; i++)// окно движется по массиву
                {
                    for (int j = 0; j < window; j++)// прогонка по окну
                    {
                        stringLine = textMassive[j];
                        if (textMassive[j] == textMassive[j + i])
                        {
                            check++;
                        }
                    }
                    if (check == window)//если все элеметы совпали, то расширяем окно, и начинаем заново
                    {
                        window++;
                        int numDuplicate = i;
                        i = 0;
                        return "Последовательность: " + stringLine + "повторяется с " + numDuplicate + " строки";
                    }
                }
            }
            return "Конечный размер окна " + window;
        }
    }
}
