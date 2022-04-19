using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_DesignPattern_Test.Models;
using MVVM_DesignPattern_Test.Commands;

namespace MVVM_DesignPattern_Test.ViewModel
{
    internal class ViewModelChartID
    {
        public ModelChartID modelChartID;
        public ChartIDInfoViewModel chartIDInfo;

        public ViewModelChartID()
        {
            modelChartID = new ModelChartID("Titanio");
            chartIDInfo = new ChartIDInfoViewModel();
            UpdateCommand = new ChartIDUpdateCommand(this);
        }        

        public ModelChartID ModelChartID
        {
            get { return modelChartID; }
        }

        public ICommand UpdateCommand
        {
            get;
            set;
        }

        public void SaveChanges()
        {
            System.Diagnostics.Debug.Assert(false,String.Format("{0}",ModelChartID.Material));
        }
    }
}
