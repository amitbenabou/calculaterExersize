using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace calculaterExersize
{
    internal class CalculatorBrain : INotifyPropertyChanged
    {
      #region INotifyPropertyChanged

      public event PropertyChangedEventHandler PropertyChanged;

      void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
      {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }


       #endregion
      public CalculatorBrain()
      {
            ButtonComand = new Command<string>((p) => Calculate(p));
      }

      private string calculatorResult;
      public string CalculatorResult
        {
         get
         {
            return this.calculatorResult;
         }
         set
         {
            this.calculatorResult = value;
            OnPropertyChanged();
         }
      }
        public Command<string> ButtonComand { get; set; }
        private void Calculate(string p)
        {
            calculatorResult = p;
        }

    }
}

