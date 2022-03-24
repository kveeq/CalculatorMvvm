using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Data;

namespace CalculatorMvvm.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Expression { get => expression; set { expression = value; OnPropertyChanged("Expression"); } }
        public string expression = "0";
        public string Result { get => result; set {result = value; OnPropertyChanged("Result");}}
        public string result = "0";

        public ICommand EnterCharCommand { protected set; get; }
        public ICommand DeleteCharCommand { protected set; get; }
        public ICommand EnterAcCommand { protected set; get; }
        public ICommand CalculateCommand { protected set; get; }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public CalculatorViewModel()
        {
            EnterCharCommand = new Command(EnterChar);
            DeleteCharCommand = new Command(DeleteChar);
            EnterAcCommand = new Command(EnterAc);
            CalculateCommand = new Command(Calculate);
        }

        private void EnterChar(object exp)
        {
            var view = exp as Button;
            Expression += view.Text;
        }
        
        private void DeleteChar()
        {
            Expression = Expression.Remove(Expression.Length - 1);
        }

        private void EnterAc()
        {
            Expression = "";
        }

        private void Calculate()
        {
            if (Char.IsDigit(expression[expression.Length-1]))
            {
                Result = Convert.ToDouble(new DataTable().Compute(Expression, "")).ToString();
            }
        }
    }
}
