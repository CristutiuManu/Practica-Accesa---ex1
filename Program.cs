using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Vizitator[] vizitatori = new Vizitator[5];

            vizitatori[0] = new Vizitator("Manu", 19, "Male");
            vizitatori[1] = new Vizitator("Estera", 19, "Female");

            for(int i = 0; i < vizitatori.Length; i++)
            {
                Console.WriteLine("{0}, {1}, {2}", vizitatori[i].Name, vizitatori[i].Age, vizitatori[i].Gender); 
            }


            Fabrica f1 = new Fabrica();
            Muncitor m1 = new Muncitor() {Id = 1, Name = "Mirel", Age = 31, Gender="Male", Religion= "Muslim", SexualOrientation = "Straight"};
            Muncitor m2 = new Muncitor() { Id = 2, Name = "Viorel", Age = 47, Gender = "Male", Religion = "Christian", SexualOrientation = "Straight" };

            Console.WriteLine("Angajatul " + m1.Name + " cu id-ul: " +m1.Id + ", cu varsta: " + m1.Age + ", de sex: " +m1.Gender + ", religia: " + m1.Religion + " este " + m1.SexualOrientation);


            Console.WriteLine(f1.BileteVandute());
            Console.WriteLine("Numarul muncitorilor este de: " + f1.GetMuncitor(2) + " muncitori");
        }
    }
}
