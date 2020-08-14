using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementMVVM.Model
{

    class Customer : ObservableObject
    {
        public int CustCode;
        public string CustName;
        public int CustomerCode {
            get;
            set;
        }
        public string CustomerName {

            get;
            set;

        }
        
       // public event PropertyChangedEventHandler PropertyChanged;

       // private void RaisePropertyChanged(string property)
      //  {
       //     if (PropertyChanged != null)
       //     {
       //        PropertyChanged(this, new PropertyChangedEventArgs(property));
        //    }
      //  }
    }
}
