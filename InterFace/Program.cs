using System;

namespace
{
    class program
    {
        static void Main(string[] args)
        {

        }
    }
    interface  IPerson
    {
        //otamatik publicttir
        void add();
    }
    class CustomerPerson : IPerson
    {
        public void add()
        {
            Console.WriteLine("cust eklendi");
        }
    }

    class EmployeePerson : IPerson
    {
        public void add()
        {
            Console.WriteLine("Müşteri eklendi");
        }
    }


}