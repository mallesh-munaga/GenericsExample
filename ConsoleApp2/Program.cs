using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeMyEmployeeModel(new Employee { });
            SerializeMyPeopleModel(new People { });
            Console.WriteLine("---------------------------After using generic ---------------------------");
            SerializeMyModel(new People { });
            SerializeMyModel(new Employee { });

            Console.ReadKey();
        }

        private static void SerializeMyEmployeeModel(Employee model)
        {
            var result = JsonConvert.SerializeObject(model);
            Console.WriteLine(result);
        }

        private static void SerializeMyPeopleModel(People model)
        {
            var result = JsonConvert.SerializeObject(model);
            Console.WriteLine(result);
        }

        private static void SerializeMyModel<MyCommanModel>(MyCommanModel model)
        {
            var result = JsonConvert.SerializeObject(model);
            Console.WriteLine(result);
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string MyProperty { get; set; }
    }

    class People
    {
        public int Id { get; set; }
    }
}
