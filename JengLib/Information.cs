using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Information
    {
        private string line;
        private string phone;
        private string name;
        private string lastName;
        public Information(string line)
        { 
            this.line = line;
            this.ExtractPhone();
            this.ExtractName();
            this.ExtractLastName();
        }
        public Information(string name, string lastName, string phone)
        {
            this.name = name;
            this.lastName = lastName;
            this.phone = phone;
        }
        public string Line
        {
            get
            {
                return line;
            }
        }
        private void ExtractPhone()
        {
            char[] charArr = line.ToCharArray();
            int keeper = 0;
            bool phone = false;
            List<char> Phone = new List<char>();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals('['))
                {
                    phone = true;
                    keeper = i + 1;
                }
            }
            if (phone == true)
            {
                for (int y = keeper; y < charArr.Length; y++)
                {
                    if (charArr[y].Equals(']'))
                    {
                        break;
                    }
                    Phone.Add(charArr[y]);
                }
            }
            string phone2 = string.Join("", Phone);
            this.phone = phone2;
        }
        private void ExtractName()
        {
            char[] charArr = line.ToCharArray();
            bool name = false;
            int keeper = 0;
            List<char> Name = new List<char>();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals('<'))
                {
                    name = true;
                    keeper = i + 1;
                }
            }
            if (name == true)
            {
                for (int y = keeper; y < charArr.Length; y++)
                {
                    if (charArr[y].Equals(' '))
                    {
                        break;
                    }
                    Name.Add(charArr[y]);
                }
            }
            string name2 = string.Join("", Name);
            this.name = name2;
        }
        private void ExtractLastName()
        {
            char[] charArr = line.ToCharArray();
            int keeper = 0;
            int keeper2 = 0;
            bool Last_Name = false;
            List<char> LastName = new List<char>();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals(' '))
                {
                    keeper2++;
                }
                if (keeper2 == 2)
                {
                    Last_Name = true;
                    keeper = i + 1;
                    break;
                }
            }
            if (Last_Name == true)
            {
                for (int y = keeper; y < charArr.Length; y++)
                {
                    if (charArr[y].Equals('>'))
                    {
                        break;
                    }
                    LastName.Add(charArr[y]);
                }
            }
            string LastName2 = string.Join("", LastName);
            this.lastName = LastName2;
        }
        public string ReGroup()
        {
            string OutPut = "[" + phone + "]" + " <" + name + " " + lastName + ">";
            return OutPut;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }
    }
}
