using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Numbers
    {
        private string line;
        private List<XBox> xboxes2 = new List<XBox>();
        public Numbers(string line)
        {
            this.line = line;
            this.Extract();
        }
        public string Line
        {
            get
            {
                return line;
            }
        }
        private void Extract()
        {
            //List<XBox> xboxes = new List<XBox>();
            string[] numbers = line.Split(',');
            for (int i = 0; i < numbers.Length; i++)
            {
                XBox xbox = new XBox(numbers[i]);
                this.xboxes2.Add(xbox);
            }
        }
        public List<XBox> Get_Xboxes
        {
            get
            {
                return this.xboxes2;
            }
        }
    }
}
