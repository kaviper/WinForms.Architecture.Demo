using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Architecture.Demo.Application.Contract;
using WinForms.Architecture.Demo.Domain.Model;
using WinForms.Architecture.Demo.Forms.Extensions;
using WinForms.Architecture.Demo.Infra;

namespace WinForms.Architecture.Demo.Forms
{
    public partial class Form1 : Form
    {
        private readonly ICalculator _calculator;

        public Form1(ICalculator calculator)
        {
            InitializeComponent();
            _calculator = calculator;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Result? result = null;

            if (rbPlus.Checked)
                result = _calculator.Add(txtNum1.ToDouble(), txtNum2.ToDouble());

            else if (rbMinus.Checked)
                result = _calculator.Minus(txtNum1.ToDouble(), txtNum2.ToDouble());

            else if (rbMulti.Checked)
                result = _calculator.Multply(txtNum1.ToDouble(), txtNum2.ToDouble());

            else if (rbDivide.Checked)
                result = _calculator.Divide(txtNum1.ToDouble(), txtNum2.ToDouble());

            if(result != null)
                MessageBox.Show(result.ToString());

            else
                MessageBox.Show("Somthing Went Wrong!");
        }
    }
}
