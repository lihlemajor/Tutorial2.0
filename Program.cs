using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepo studentRepo = new StudentRepo();
            while (true)
            {
                Console.WriteLine("Enter Student Details");
                Console.WriteLine();

                String Id;
                Console.WriteLine("Enter student Id.");
                Id = Console.ReadLine();

                String name;
                Console.WriteLine("Enter student name.");
                name = Console.ReadLine();

                String lastname;
                Console.WriteLine("Enter student lastname.");
                lastname = Console.ReadLine();

                String age;
                Console.WriteLine("Enter student age.");
                age = Console.ReadLine();

                Console.WriteLine(studentRepo.SaveStudent(int.Parse(Id), name, lastname, int.Parse(age)));
                Console.ReadLine();


            }
        }
    }
}
