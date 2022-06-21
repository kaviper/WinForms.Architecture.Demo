using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Architecture.Demo.Domain.Model;

namespace WinForms.Architecture.Demo.Application.Contract
{
    public interface ICalculator
    {
        public Result Add(double num1, double num2);
        public Result Minus(double num1, double num2);
        public Result Multply(double num1, double num2);
        public Result Divide(double num1, double num2);
    }
}
