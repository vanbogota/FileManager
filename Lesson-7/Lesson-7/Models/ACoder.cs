using Lesson_7.Interfaces;

namespace Lesson_7.Models
{
    public class ACoder : IСoder
    {           
        public string Encode(string word)
        {
            string newString = null;

            for (int i = 0; i < word.Length; i++)
            {
                switch ((int)word[i])
                {
                    case 90:
                        newString += (char)65;
                        break;
                    case 122:
                        newString += (char)97;
                        break;
                    case 1103:
                        newString += (char)1072;
                        break;
                    case 1071:
                        newString += (char)1040;
                        break;
                    default:
                        newString += (char)((int)word[i] + 1);
                        break;
                }
            }            
            return newString;            
        }

        public string Decode(string word)
        {
            string newString = null;

            for (int i = 0; i < word.Length; i++)
            {
                switch ((int)word[i])
                {
                    case 65:
                        newString += (char)90;
                        break;
                    case 97:
                        newString += (char)122;
                        break;
                    case 1072:
                        newString += (char)1103;
                        break;
                    case 1040:
                        newString += (char)1071;
                        break;
                    default:
                        newString += (char)((int)word[i] - 1);
                        break;
                }
            }
            return newString;            
        }        
    }
}
