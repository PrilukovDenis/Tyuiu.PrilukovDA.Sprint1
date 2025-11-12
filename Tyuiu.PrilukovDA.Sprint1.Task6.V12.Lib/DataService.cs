using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PrilukovDA.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            value = value.Trim();
            string[] words = value.Split(new char [] {' ', ',', '.', '!', '?'});

            if (words.Length < 2) return false;

            string lastWord = words[words.Length - 1];

            int count = 0;
            foreach (string word in words) { 
            if(string.Equals(word, lastWord))
                {
                    count++;
                }
            }
            return count > 1;
        }
    }
}
