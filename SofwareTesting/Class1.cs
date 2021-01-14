using System;

namespace SofwareTesting
{
    public class Calculator
    {
        public int Factor1 { get; set; }
        public int Factor2 { get; set; }
        public int Add()
        {
            return Factor1+Factor2;
        }

        public int Div() 
        {
            if (Factor2 == 0) {
                throw new DivideByZeroException();
            }
            return Factor1 / Factor2;
        }
    }
}
