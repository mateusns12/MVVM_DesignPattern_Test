using MVVM_DesignPattern_Test.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_DesignPattern_Test.Commands
{
    internal class ChartIDUpdateCommand:ICommand
    {
        public ChartIDUpdateCommand(ViewModelChartID viewModel)
        {
            this.viewModel = viewModel;
        }

        private ViewModelChartID viewModel;

        #region ICommand members
        public event System.EventHandler? CanExecuteChanged
        {
            add {CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return String.IsNullOrWhiteSpace(viewModel.ModelChartID.Error);
        }

        public void Execute(object? parameter)
        {
            //viewModel.SaveChanges();
        }
        #endregion
    }
}
