using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace CalculatorMvvm.ViewModel
{
    internal class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand Add { protected set; get; }
        public ICommand Minus { protected set; get; }
        public ICommand Delenie { protected set; get; }
        public ICommand Umn { protected set; get; }
    }
}
