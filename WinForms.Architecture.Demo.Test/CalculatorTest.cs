using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms.Architecture.Demo.Application.Contract;
using WinForms.Architecture.Demo.Infra;
using Xunit;
using Xunit.Abstractions;

namespace WinForms.Architecture.Demo.Test
{
    public class CalculatorTest
    {
        private readonly ICalculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TestingCalculator()
        {
            var result = _calculator.Add(53, 23);

            Assert.Equal(53 + 23, result.ResultValue);
        }

        [Fact]
        public void Minus_Test2ingCalculator()
        {
            var result = _calculator.Minus(53, 23);

            Assert.Equal(53 - 23, result.ResultValue);
        }

        [Fact]
        public void Multply_Test2ingCalculator()
        {
            var result = _calculator.Multply(53, 23);

            Assert.Equal(53 * 23, result.ResultValue);
        }

        [Fact]
        public void Divide_Test2ingCalculator()
        {
            var result = _calculator.Divide(53, 23);

            Assert.Equal(53.0 / 23.0, result.ResultValue);
        }
    }
}
