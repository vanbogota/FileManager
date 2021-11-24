using Lesson_7.Interfaces;

namespace Lesson_7.Models
{
    public class BCoder : IСoder
    {
        public string Encode(string word)
        {
            string newString = null;

            for (int i = 0; i < word.Length; i++)
            {
                //upper letters
                if ((int)word[i] >= 65 && (int)word[i] <= 90)
                {
                    newString += (char)(90 - word[i] + 65);
                }
                //lower letters
                else if ((int)word[i] >= 97 && (int)word[i] <= 122)
                {
                    newString += (char)(122 - word[i] + 97);
                }
                //rus upper letters
                else if ((int)word[i] >= 1040 && (int)word[i] <= 1071)
                {
                    newString += (char)(1071 - word[i] + 1040);
                }
                //rus lower letters
                else if ((int)word[i] >= 1072 && (int)word[i] <= 1103)
                {
                    newString += (char)(1103 - word[i] + 1072);
                }
                //other symbols
                else
                {
                    newString += word[i];
                }
            }

            return newString; 
        }
        public string Decode(string word)
        {
            string newString = null;
            for (int i = 0; i < word.Length; i++)
            {
                //upper letters
                if ((int)word[i] >= 65 && (int)word[i] <= 90)
                {
                    newString += (char)(90 - word[i] + 65);
                }
                //lower letters
                else if ((int)word[i] >= 97 && (int)word[i] <= 122)
                {
                    newString += (char)(122 - word[i] + 97);
                }
                //rus upper letters
                else if ((int)word[i] >= 1040 && (int)word[i] <= 1071)
                {
                    newString += (char)(1071 - word[i] + 1040);
                }
                //rus lower letters
                else if ((int)word[i] >= 1072 && (int)word[i] <= 1103)
                {
                    newString += (char)(1103 - word[i] + 1072);
                }
                //other symbols
                else
                {
                    newString += word[i];
                }
            }
            return newString;
        }
    }
}
