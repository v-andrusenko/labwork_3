using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_3_2
{
    class Model
    {
        public string sign;
        public string Add(double firstValue, double secondValue)
        {
            sign = "+";
            return (firstValue+secondValue).ToString();
        }
        public string Subtract(double firstValue, double secondValue)
        {
            sign = "-";
            return (firstValue - secondValue).ToString();
        }
        public string Multiply(double firstValue, double secondValue)
        {
            sign = "×";
            return (firstValue * secondValue).ToString();
        }
        public string Divide(double firstValue, double secondValue)
        {
            sign = "÷";
            return (firstValue / secondValue).ToString();
        }
        public void Clear()
        {
            sign = "";
        }
    }
}
