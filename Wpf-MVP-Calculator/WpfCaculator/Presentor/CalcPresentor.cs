using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculator.Presentor
{
    public class CalcPresentor
    {
        ICalculator Calculator;
        public CalcPresentor(ICalculator calculator)
        {
            Calculator = calculator;
        }
        public void AddZero()
        {
            Calculator.Result += "0";
        }
        public void AddOne()
        {
            Calculator.Result += "1";
        }
        public void AddTwo()
        {
            Calculator.Result += "2";
        }
        public void AddThree()
        {
            Calculator.Result += "3";
        }
        public void AddFour()
        {
            Calculator.Result += "4";
        }
        public void AddFive()
        {
            Calculator.Result += "5";
        }
        public void AddSix()
        {
            Calculator.Result += "6";
        }
        public void AddSeven()
        {
            Calculator.Result += "7";
        }
        public void AddEight()
        {
            Calculator.Result += "8";
        }
        public void AddNine()
        {
            Calculator.Result += "9";
        }
        public void AddPlus()
        {
            Calculator.Result += "+";
        }
        public void AddSubtract()
        {
            Calculator.Result += "-";
        }
        public void AddMultiply()
        {
            Calculator.Result += "*";
        }
        public void AddDivide()
        {
            Calculator.Result += "/";
        }
        public void DeleteAll()
        {
            Calculator.Result = "";
        }
        public void CalcResult()
        {
            Calculator.Result = new DataTable().Compute(Calculator.Result, null).ToString();
        }
        public void R()
        {
            CalcResult();
            Calculator.Result = (1 / double.Parse(Calculator.Result)).ToString();
        }
    }
}
