using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal struct ComplexNumber
    {
        double Real;
        double Imag;

        public ComplexNumber(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        public ComplexNumber Sum(ComplexNumber n)
        {
            double r = Real + n.Real;
            double i = Imag + n.Imag;
            return new ComplexNumber(r, i);
        }
        public ComplexNumber Subtract(ComplexNumber n)
        {
            double r = Real - n.Real;
            double i = Imag - n.Imag;
            return new ComplexNumber(r, i);
        }
        public ComplexNumber Multiply(ComplexNumber n)
        {
            double r = Real * n.Real - (Imag * n.Imag);
            double i = Real * n.Imag + (Imag * n.Real);
            return new ComplexNumber(r, i);
        }
    }
}
