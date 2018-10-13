using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    class Account
    {
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string FatherName { get; set; }
        private double _balance { get; set; }

        public double Balance //{ get; set; }
        {
            get {
                return _balance;
            }

            set
            {
                _balance = value;
            }

        }
               
        public virtual double GetBalance()
        {
            return _balance;        
        }
    }
}
