using Module4__Assignment3.Commands;
using Module4__Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Module4__Assignment3.ViewModels
{
    class EmployeeViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        DataAccess ad = new DataAccess();

        #region EmployeeID
        private int _EmpId;
        public int EmpId
        {
            get { return _EmpId; }
            set 
            { 
                _EmpId = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("EmpId"));
                }
            }
        }
        #endregion

        #region Employee Object
        private Employee _emp;
        public Employee emp
        {
            get { return _emp; }
            set
            {
                _emp = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("emp"));
                }
            }
        }
        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Name")
                {
                    if (string.IsNullOrEmpty(emp.Name) == true || string.IsNullOrWhiteSpace(emp.Name) == true)
                        result = "Name cannot be empty";
                    if (!Regex.IsMatch(emp.Name, @"^[a-zA-Z]+$"))
                        result = "Inalid Name";
                }

                if (columnName == "Age")
                {
                    if (!Regex.IsMatch(emp.Age.ToString(), @"^[0-9]+$"))
                        result = "Inalid Age";
                    if (emp.Age <= 0)
                        result = "Age can't be negative or zero";
                }

                if (columnName == "Gender")
                {
                    if (String.IsNullOrEmpty(emp.Gender) || String.IsNullOrWhiteSpace(emp.Gender))
                        result = "Gender cannot be empty";
                    if (!Regex.IsMatch(emp.Gender, @"^[a-zA-Z]+$"))
                        result = "Inalid Gender";
                }

                if (columnName == "Address")
                {
                    if (String.IsNullOrEmpty(emp.Address) || String.IsNullOrWhiteSpace(emp.Address))
                        result = "Address cannot be empty";
                    if (!Regex.IsMatch(emp.Address, @"^[a-zA-Z]+$"))
                        result = "Inalid Address";
                }

                return result;
            }
        }
        #endregion

        #region Employee List
        private ObservableCollection<Employee> _empList;
        public ObservableCollection<Employee> empList
        {
            get { return _empList; }
            set 
            { 
                _empList = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("empList"));
                }
            }
        }
        #endregion

        #region Relay_Commands
        public RelayCommand CreateCommand { get; set; }
        public RelayCommand RetrieveCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand SearchCommand { get; set; }
        #endregion

        public EmployeeViewModel()
        {
            emp = new Employee();

            RetrieveCommand = new RelayCommand(RetrieveData);
            CreateCommand = new RelayCommand(CreateData);
            UpdateCommand = new RelayCommand(UpdateData);
            DeleteCommand = new RelayCommand(DeleteData);
            SearchCommand = new RelayCommand(SearchData);
        }

        #region operations
        private void SearchData()
        {
            emp = ad.makeEmpty(emp);
            Employee x = ad.getEmployee(EmpId);
            
            if (x.Name != null)
                emp = x;
            else
                MessageBox.Show("Invalid Id","Error",MessageBoxButton.OK,MessageBoxImage.Error);
        }

        private void DeleteData()
        {
            ad.deleteData(EmpId);
            empList = ad.getData();
            emp = ad.makeEmpty(emp);
        }

        private void UpdateData()
        {
            ad.putData(emp, EmpId);
            empList = ad.getData();
            emp = ad.makeEmpty(emp);
        }

        private void CreateData()
        {
            ad.postData(emp);
            emp = ad.makeEmpty(emp);
            empList = ad.getData();
        }

        public void RetrieveData()
        {
            empList = ad.getData();
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public string Error => throw new NotImplementedException();
    }
}