using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5_file_08_
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            short age = short.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long egn = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName} \r\nLast name: {lastName} \r\nAge: {age} " +
                $"\r\nGender: {gender} '\r\nPersonal ID: {egn} \r\nUnique Employee number: {employeeNumber}");
        }
    }
}
