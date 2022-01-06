using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryBind
{
    public class VM_sList: INotifyPropertyChanged
    {
        private ObservableCollection<VM_s> _SList;
        public ObservableCollection<VM_s> SList
        {
            get
            {
                return this._SList;
            }
            set
            {
                if (this._SList != value)
                {
                    this._SList = value;
                    OnPropertyChanged("SList");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
