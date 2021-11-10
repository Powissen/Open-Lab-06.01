using System;

namespace Open_Lab_06._01
{
    public class Challenge
    {
        public string MysteryFunc(string str)
        {
            string output = "";
            for (int letter = 0; letter < str.Length; letter += 2)
            {
                for (int repeats = 0; repeats < Convert.ToInt32(str[letter + 1].ToString()); repeats++) 
                { output += str[letter]; }
            }
            return output;
        }
    }
}
