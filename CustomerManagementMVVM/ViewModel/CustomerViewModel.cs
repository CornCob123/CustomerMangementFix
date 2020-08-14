using CustomerManagementMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CustomerManagementMVVM.ViewModel
{
    class CustomerViewModel : ObservableObject
    {
        private ICommand _saveContactCommand = null;
        private ICommand _saveCustomerCommand = null;
		ObservableCollection<Contact> loadcollectionData = new ObservableCollection<Contact>();
		public int _CustCode=2;
        public string _CustName="Jane";
        public int _ContactCode = 3;
        public string _ContactName = "Jean";

        public int customercode
        {
            get { return _CustCode; }
            set
            {
                if (_CustCode != value)
                {
                    _CustCode = value;
                    RaisePropertyChanged("customercode");
                }

            }
        }
        public string customername
        {

            get { return _CustName; }
            set
            {
                if (_CustName != value)
                {
                    _CustName = value;
                    RaisePropertyChanged("customername");
                }
            }

        }
        
        public string contactname
        {

            get { return _ContactName; }
            set
            {
                if (_ContactName != value)
                {
                    _ContactName = value;
                    RaisePropertyChanged("contactname");
                }
            }

        }
        public int contactcode
        {

            get { return _ContactCode; }
            set
            {
                if (_ContactCode != value)
                {
                    _ContactCode = value;
                    RaisePropertyChanged("contactcode");
                }
            }

        }
		public ObservableCollection<Contact> LoadCollectionData {

			get { return loadcollectionData; }

			set { if (loadcollectionData != value) {
					loadcollectionData = value;
					RaisePropertyChanged("LoadCollectionData");
				}

			}
		}


		public CustomerViewModel()
        {
            LoadStudents();
         
        }
        public ObservableCollection<Customer> Customers
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

            customers.Add(new Customer { CustomerCode = 1, CustomerName = "Allain" });
            customers.Add(new Customer { CustomerCode = 2, CustomerName = "Brown" });
            customers.Add(new Customer { CustomerCode = 3, CustomerName = "Hamerski" });

            Customers = customers;
			loadcollectionData.Add(new Contact { ContactCode = 1, ContactName = "kel" });

		}
        public ICommand SaveCustomerCommand
        {
            get
            {
                if (_saveCustomerCommand == null)
                {
                    //MessageBox.Show("1St Box", "title");
                    _saveCustomerCommand = new RelayCommand(param => SaveCustomer());

                }


                return _saveCustomerCommand;
            }
            set
            {
                _saveCustomerCommand = value;
            }
        }
        
        public ICommand SaveContactCommand
        {
            get
            {
                if (_saveContactCommand == null)
                {
                    //MessageBox.Show("1St Box", "title");
                    _saveContactCommand = new RelayCommand(param => SaveContact());

                }


                return _saveContactCommand;
            }
            set
            {
                _saveContactCommand = value;
            }
        }
        
        private void SaveCustomer()
        {
            MessageBox.Show("2ndBox", "Title");  // You would implement your Product save here
            string me = this._CustName;
            int meNumber = this._CustCode;
            MessageBox.Show(me, "Title");
            MessageBox.Show(meNumber.ToString(), "Title");
            try
            {
                MessageBox.Show("Button is clicked!" + me);
                Customer u = new Customer()
                {
                    CustomerName = me
                };
                using (CustomerManagementDBEntities cm = new CustomerManagementDBEntities())
                {

                    cm.Customers.Add(u);
                    cm.SaveChanges();
                }
                MessageBox.Show("Success!" + me);


            }
            catch (InvalidOperationException w)
            {


                // _logger.Error("OnClick", ex);
                throw;
            }
        }
        
        private void SaveContact()
        {
            //MessageBox.Show("3rdBox", "Title");  // You would implement your Product save here
            string me = this._ContactName;
            int meNumber = this._ContactCode;
            int meNumber1 = this._CustCode;
           // MessageBox.Show(me, "Title");
           // MessageBox.Show(meNumber.ToString(), "Title");
           // MessageBox.Show(meNumber1.ToString(), "Title");
			
            try
            {
               // MessageBox.Show("Button is clicked!" + me);
                Contact u = new Contact()
                {
                    CustomerCode = meNumber1,
                    ContactCode=meNumber,
                    ContactName=me
                };
				LoadCollectionData.Add(u);
				//using (CustomerManagementDBEntities cm = new CustomerManagementDBEntities())
              //  {

              //      cm.Contacts.Add(u);
              //      cm.SaveChanges();
              //  }
               // MessageBox.Show("Success!" + me);
				

            }
            catch (InvalidOperationException w)
            {
                // _logger.Error("OnClick", ex);
                throw;
            }
            
        }
    
    }
}

