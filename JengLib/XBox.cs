using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class XBox
    {
        private string number;
        private string type;
        public XBox(string number)
        {
            this.number = number;
            this.Extract();
        }
        private void Extract()
        {
            if (number.Length == 5)
            {
                this.type = "Zip code";
            }
            else if (number.Length == 10)
            {
                this.type = "Cell phone";
            }
            else if (number.Length == 9)
            {
                this.type = "Home phone";
            }
            else this.type = "Unknown";
        }
        public string Number
        {
            get
            {
                return this.number;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
        }
    }
}
