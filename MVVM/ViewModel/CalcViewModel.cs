using System;
using System.Windows.Input;
using Dangl.Calculator;
using Microsoft.Maui.Controls;
using PropertyChanged;

namespace MAUICalculator.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CalcViewModel
    {
        public string Formula { get; set; }
        public string Result { get; set; } = "0";

        public ICommand OperationCommand =>
            new Command((number) =>
            {
                Formula += number?.ToString();
            });

        public ICommand ResetCommand =>
            new Command(() =>
            {
                Result = "0";
                Formula = "";
            });

        public ICommand BackspaceCommand =>
            new Command(() =>
            {

                if (Formula.Length > 0)
                {
                    Formula = Formula.Substring(0, Formula.Length - 1);
                }
            });

        public ICommand CalculateCommand => new Command(() =>
        {
            if (Formula.Length == 0)
            {
                return;
            }

            var calculation = Calculator.Calculate(Formula);
            Result = calculation.Result.ToString();
        });
    }
}