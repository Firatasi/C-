using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add();
            manager.Update();
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            customerManager.GetBestCustomer();

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            employeeManager.Update();
            employeeManager.GetBestEmployee();

        }
    }

    class PersonManager
    {
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Güncellendi");
        }
    }

    class CustomerManager:PersonManager // cstm personu mıras alır
    {
        public void GetBestCustomer()
        {

        }
    }

    class EmployeeManager : PersonManager // cstm personu mıras alır
    {
        public void GetBestEmployee()
        {

        }

    }

}