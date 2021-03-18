using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class EncryptDecrypt
    {
        private int encr_decr_key = -1;
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public string text;
        public int Encr_decr_key
        {
            get
            {
                if (encr_decr_key == -1)
                {
                    throw new Exception("Error.");
                }
                return encr_decr_key;
            }
            set
            {
                if (value >= 1 && value <=26)
                {
                    encr_decr_key = value;
                }
                else
                {
                    throw new Exception("Error.");
                }
            }
        }
        public string encrypt()
        {
            char[] charArr = alphabet.ToCharArray();
            List<char> list = new List<char>();
            int sum = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                sum = i + encr_decr_key;
                if (sum > 25)
                {
                    sum = 0 + sum - encr_decr_key;
                }
                list.Add(charArr[sum]);
            }
            string Output = string.Join("", list);
            return Output;
        }
    }
}
