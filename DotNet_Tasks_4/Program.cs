using System;
using System.Collections.Generic;

namespace DotNet_Tasks_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-2 p
            Person person1 = new Person();
            person1.Age = 18;
            person1.Name = "Petro";
            person1.PhoneNumbers = new List<string> { "280-230-15", "065-038-28-50", "555-66-00" };

            Person person2 = new Person();
            person2.Age = 25;
            person2.Name = "Marta";
            person2.PhoneNumbers = new List<string> { "244-48-10", "097-123-25-71", "444-23-58" };

            Person person3 = new Person();
            person3.Age = 20;
            person3.Name = "Andriy";
            person3.PhoneNumbers = new List<string> { "777-23-58", "068-258-66-72", "587-66-66" };

            Person person4 = new Person();
            person4.Age = 50;
            person4.Name = "Yosyf";
            person4.PhoneNumbers = new List<string> { "123-86-15", "068-563-54-25", "325-21-45" };

            Person person5 = new Person();
            person5.Age = 68;
            person5.Name = "Vladimir";
            person5.PhoneNumbers = new List<string> { "458-02-58", "086-541-58-52", "258-54-25" };

            Person person6 = new Person();
            person6.Age = 28;
            person6.Name = "Liza";
            person6.PhoneNumbers = new List<string> { "213-45-68", "098-558-55-21", "668-58-53" };

            var list1 = new List<Person>();

            list1.Add(person1);
            list1.Add(person2);
            list1.Add(person3);
            list1.Add(person4);
            list1.Add(person5);
            list1.Add(person6);

            Console.WriteLine("1. Name and age of all persons in List");
            Console.WriteLine();

            foreach (var item in list1)
            {
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            Person person7 = new Person();
            person7.Age = 35;
            person7.Name = "Ivanna";
            person7.PhoneNumbers = new List<string> { "153-12-58", "068-486-51-98", "588-42-79" };

            Person person8 = new Person();
            person8.Age = 15;
            person8.Name = "Stepan";
            person8.PhoneNumbers = new List<string> { "589-36-88", "050-888-69-25", "973-58-58" };

            var list2 = new List<Person>();
            list2.Add(person7);
            list2.Add(person8);
            
            list1.AddRange(list2);

            Console.WriteLine("2. Numbers of phones of all persons in List");
            Console.WriteLine();

            foreach (var item in list1)
            {
                foreach (var num in item.PhoneNumbers)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine();
            }
            #endregion

            List<string> randArr = new List<string>();
            randArr = OperationWithStrings.Random();

            Console.WriteLine("3. List of random words");
            Console.WriteLine();

            foreach (var item in randArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.Write("Number of elements in List is: ");
            Console.WriteLine(randArr.Count);
            Console.WriteLine();

            randArr = OperationWithStrings.Find(randArr);

            Console.Write("Number of unqie elements in List is: ");
            Console.WriteLine(randArr.Count);
            Console.WriteLine();

            randArr = OperationWithStrings.Sort(randArr);
            Console.WriteLine();

            
        }
    }
}
