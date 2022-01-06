using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryBind
{
    public class VM_s : INotifyPropertyChanged
    {
        string _name;
        public string XYXY
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("XYXY"); }
        }

        string QQS;
        public string Name_
        {
            get { return QQS; }
            set { QQS = value; OnPropertyChanged("Name_"); }
        }



        List<string> QQQ;
        public List<string> QAQA
        {
            get { return QQQ; }
            set { QQQ = value; OnPropertyChanged("QAQA"); }
        }


        protected internal virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
       

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
