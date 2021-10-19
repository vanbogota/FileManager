using System.Collections.Generic;
using System.IO;

namespace WorkWithStringsInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //заполнения исходного файла информацией
            string inputFile = "FileWithFIOandMail.txt";
                       
            List<string> stringsWithFIOandMail = new List<string>();
            stringsWithFIOandMail.Add("Кучма Андрей Витальевич & Kuchma@mail.ru");
            stringsWithFIOandMail.Add("Мизинцев Павел Николаевич & Pasha@mail.ru");
            
            if (!File.Exists(inputFile))
            {
                File.WriteAllLines(inputFile, stringsWithFIOandMail);
            }
            //выполнение по заданию
            else
            {
                string mailsList = "FileWithMails.txt";

                List<string> stringsWithMail = new List<string>();

                string[] stringsFromFile = File.ReadAllLines(inputFile);

                for(int i =0; i< stringsFromFile.Length; i++ )
                {
                    SearchMail(ref stringsFromFile[i]);

                    stringsWithMail.Add(stringsFromFile[i]);
                }

                File.AppendAllLines(mailsList, stringsWithMail);
            }            
        }

        public static void SearchMail(ref string s) 
        {
            string[] strings = s.Split("&");
            foreach (string item in strings)
            {
                if (item.Contains('@'))
                {
                    s = item.Trim(' ');
                }                    
            }
        }
    }
}
