using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Architecture.Demo.Domain.Model
{
    public class Result
    {
        private Result() { }

        public Result(double resultValue)
        {
            ResultValue = resultValue;
        }

        public double ResultValue { get; private set; }

        public override string ToString() => $"The Result is {ResultValue}";
    }
}
