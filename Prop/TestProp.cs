using System;

namespace Prop
{
    public class TestProp
    {
        // data = membre de la classe
        private decimal nb1;
        private decimal nb2 = 20;

        public decimal Nb1
        {
            get
            {
                return nb1;
            }
            set
            {
                if (value == 0)
                    nb1 = 1;
                else
                    nb1 = value;
            }
        } // propriete Nb1

        public decimal Nb2 {
            get
            {
                return nb2;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Division par 0");
                   
                   
                else
                    nb2 = value;
            }
         } // propriete Nb2

        public decimal Somme()
        {
            return Nb1 + Nb2;
        }
        public decimal Quotient()
        {
            if (Nb2 == 0) return 0;
            else return Nb1 / Nb2;
        }


    }
}
