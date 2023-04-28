using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.AlSaadi_120255_LambdaExpression
{
    public class School
    {
        public string name { get; set; }
        public string location { get; set; }
        public int ID { get; set; }
        public School(string n, string l, int id)
        {
            name = n;
            location = l;
            ID = id;
        }
        public override string ToString()
        {
            return "School name : " + name + ", School location : " + location + ", School ID :" + ID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            List<School> sch = new List<School>() {
                new School("Khalid Bin Waleed","Muscat",1203),
                new School("Al Zahraa","Sur",4653),
                new School("Al Salam","Nizwa",2523)
            };
            var all = sch.Select(x => x.ToString());
            foreach (var n in all)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("============================================================");
            var id = sch.Select(x => x.ID);
            foreach (var n in id)
            {
                Console.WriteLine("School ID : {0}", n);
            }
            Console.WriteLine("============================================================");
            var name = sch.Select(x => x.name);
            foreach (var n in name)
            {
                Console.WriteLine("School Name : {0}", n);
            }
            Console.WriteLine("============================================================");
            var location = sch.Select(x => x.location);
            foreach (var n in location)
            {
                Console.WriteLine("School location : {0}",n);
            }
        }
            
        }

    }
