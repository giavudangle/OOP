using System;
using System.Collections.Generic;

namespace LAB03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("ST001","Vudang","kms.vudang@gmail.com");
            Console.WriteLine("Student Information\n");
            Console.Write(student.ToString());
            Sofware sofware= new Sofware("v0.01","Kobiton Katalon",33.33);
            Console.WriteLine(sofware.ToString());
            Hardware hardware = new Hardware("CPU I7",99.99,0.5);
            Console.WriteLine(hardware.ToString());

            List<Animal> listAnimal = new List<Animal>(5);
            Lion l1 = new Lion("KING","Lion King",99,100.15);
            Lion l2 = new Lion("QUEEN","Queen King",80,90.15);
            Whale w1 = new Whale("Whale #1","Whale One",199,123.5);
            Whale w2 = new Whale("Whale #2","Whale Two",599,523.5);
            Whale w3 = new Whale("Whale #3","Whale Three",159,423.5);
            listAnimal.Add(l1);
            listAnimal.Add(l2);
            listAnimal.Add(w1);
            listAnimal.Add(w2);
            listAnimal.Add(w3);


            Animal maxAnimal = new Animal();
            maxAnimal.Weight=-1;
            foreach(Animal x in listAnimal){
                if(x.Weight > maxAnimal.Weight){
                    maxAnimal=x;
                }
            }

            Console.WriteLine("Animal have max weight is " + maxAnimal.ToString());

            foreach(Animal x in listAnimal){
                if(x is Lion){
                    Lion lion = (Lion)x;
                    Console.WriteLine(lion.Hunt());               
                }else {
                    Whale whale = (Whale)x;
                     Console.WriteLine(whale.Fish());
                }
            }




        }
    }
}
