using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_DesignPattern_Test.ViewModel
{
    internal class ChartIDInfoViewModel : INotifyPropertyChanged
    {
        private String info;
        public String Info
        {
            get { return info; }
            set 
            { 
                info = value;
                OnPropertyChanged("Info");
            }
        }

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
