using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Info
    {
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (value != "")
                {
                    text = value;
                }
                else
                {
                    throw new Exception("Error.");
                }
            }
        }
        public int spaces()
        {
            char[] charArr = text.ToCharArray();
            int count = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals(' '))
                {
                    count++;
                }
            }
            return count;
        }
        public int words()
        {
            char[] charArr = text.ToCharArray();
            int count = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals(' '))
                {
                    count++;
                }
            }
            return count + 1;
        }
        public int vowels()
        {
            char[] charArr = text.ToLower().ToCharArray();
            int count = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals('a') || charArr[i].Equals('e') || 
                    charArr[i].Equals('i') || charArr[i].Equals('o') ||
                    charArr[i].Equals('u'))
                {
                    count++;
                }
            }
            return count;
        }
        public int letters()
        {
            char[] charArr = text.ToCharArray();
            int count = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (!charArr[i].Equals(' '))
                {
                    count++;
                }
            }
            return count - 1;
        }
    }
}
