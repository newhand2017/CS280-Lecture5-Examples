using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyee
{
    public class Emplyee
    {
        public string Name;

        //-------------------------------------------------
        private int baseSalary;

        public int BaseSalary
        {
            set { this.baseSalary = value; }
            get { return this.baseSalary; }
        }

        //-------------------------------------------------
        private int benefit;

        public int Benefit
        {
            set { this.benefit = value; }
            get { return this.benefit; }
        }

        //-------------------------------------------------

        //-------------------------------------------------
    }
}