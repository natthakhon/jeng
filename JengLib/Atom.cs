using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Atom
    {
        private int proton;
        private int electron;
        public Atom(int proton, int electron)
        {
            this.proton = proton;
            this.electron = electron;
        }
        public int Proton
        {
            get
            {
                return this.proton;
            }
        }
        public int Electron
        {
            get
            {
                return electron;
            }
        }
    }
    public class Hydrogen : Atom
    {
        public Hydrogen() : base(1, 1)
        {

        }
    }
}
