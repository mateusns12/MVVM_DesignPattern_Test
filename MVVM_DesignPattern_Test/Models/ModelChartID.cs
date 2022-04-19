using System;
using System.ComponentModel;

namespace MVVM_DesignPattern_Test.Models
{
    internal class ModelChartID : INotifyPropertyChanged, IDataErrorInfo
    {
        public ModelChartID(string material)
        {
            Material = material;
        }

        public String material;

        public String Material
        {
            get { return material; }
            set {
                material = value;
                OnPropertyChanged("Material");
            }
        }

        #region IDataErrorInfo Members
        public string Error {
            get;
            private set;            
        }   

        public string this[string columnName]
        {
            get
            {
                if(columnName == "Material")
                {
                    if (String.IsNullOrWhiteSpace(Material))
                    {
                        Error = "Material nao pode estar vazio";
                    }
                    else
                    {
                        Error = null;
                    }
                }
                return Error;
            }
        }
        #endregion

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
