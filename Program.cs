using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> tinkoff = new BankAccount <int> (2345, 125.214, "Демидова Мария");
            BankAccount<string> sberbank = new BankAccount<string>("EEE254", 23.125, "Демидова Мария");
            tinkoff.Print<int>(2345);
            sberbank.Print<string>("EEE254");
            Console.ReadKey();
        }
    }
    class BankAccount <T>
    {
        public T Number { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }
        public BankAccount(T number, double balance, string name)
        {
            Number = number;
            Balance = balance;
            Name = name;
        }
       public void Print <T> (T value)
        {
            Console.WriteLine("Счет номер {0}, владелец счета - {1}, сумма на счете - {2}", value, Name, Balance);
        }
    }
}
