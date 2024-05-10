using System;
using static System.Formats.Asn1.AsnWriter;

namespace Prof
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor newProf1 = new Professor();
            newProf1.id = "L12345";
            newProf1.firstName = "Hank";
            newProf1.lastName = "Hill";
            newProf1.department = "Propane & Propane accsessories";

            Professor newProf2 = new Professor();
            newProf2.id = "7637";
            newProf2.firstName = "Bobby";
            newProf2.lastName = "Hill";
            newProf2.department = "Mathamatics";

            Console.WriteLine("{0} - {1} - {2} - {3}",
                newProf1.lastName, newProf1.firstName, newProf1.id, newProf1.department);

            Console.WriteLine("{0} - {1} - {2} - {3}",
                newProf2.lastName, newProf2.firstName, newProf2.id, newProf2.department);
        }
    }

    class Professor
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string department { get; set; }


    }
}