using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class PhotoBook
    {
        private int pages;
        public PhotoBook(int pages)
        {
            Pages = pages;
        }
        public PhotoBook()
        {
            pages = 16;
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }
        public int GetNumberPages()
        {
            return pages;
        }
    }
}
