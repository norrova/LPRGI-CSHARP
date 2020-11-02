using System;
using System.Collections.Generic;
using Generic.Sample.AutomaticCash;
using Generic.Sample.Game;
using Generic.Sample.Human.Customer;
using Generic.Sample.Human.Person;
using Generic.Sample.Human.Student;
using Generic.Sample.ReversePhoneBook;
using Generic.Utilities;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercice 1
            Console.WriteLine("Exercice 1 - List");

            CustomList<String> v_list = new CustomList<string>();
            v_list.Add("test");
            v_list.Print();
            Console.WriteLine(v_list.Count());
            Console.WriteLine(v_list.Get(0));
            v_list = null;

            // Exercice 2
            // 2.1
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Exercice 2.1 - List");
            List<String> v_names = new List<string>();
            v_names.Add("Joe West");
            v_names.Add("Iris West Allen");
            v_names.Add("Barry Allen West");

            CustomList<Student> v_students = new CustomList<Student>();
            v_names.ForEach(p_name =>
            {
                v_students.Add(new Student(p_name));
            });
            v_students.Print();
            v_students = null;

            // 2.2
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Exercice 2.2 - SortedList");
            SortedList<string, Person> v_reversePhone;
            v_reversePhone = new SortedList<string, Person>();
            v_reversePhone.Add("0623034933", new Person("Rataplan"));
            v_reversePhone.Add("0623034932", new Person("Lucky luke"));

            ReversePhoneBook v_reversePhoneBook = new ReversePhoneBook(v_reversePhone);
            Console.WriteLine($"Search 0623034933 : {v_reversePhoneBook.Search("0623034933")}");
            try
            {
                v_reversePhoneBook.Search("0623034930");
            }
            catch(Exception t_ex)
            {
                Console.WriteLine(t_ex.Message);
            }
            v_reversePhoneBook.Print();

            // 2.3
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Exercice 2.3 - Queue");

            AutomaticCash v_automaticCash = new AutomaticCash(1);
            v_automaticCash.AddPayment(
                new Payment(
                    DateTime.Now,
                    new Customer("Joe Biden"),
                    1204.02
                )
            );
            v_automaticCash.AddPayment(
               new Payment(
                   DateTime.Now,
                   new Customer("Donald Trump"),
                   20.00
               )
            );
            Console.WriteLine("Premier paiement dans la queue :");
            Console.WriteLine(v_automaticCash.GetFirstPayment());
            Console.WriteLine("Affichage Queue :");
            v_automaticCash.Print();

            // 2.4
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Exercice 2.4 - HashSet");

            JeuFrancais v_jeuFrancais = new JeuFrancais();
            v_jeuFrancais.Init();
            v_jeuFrancais.Print();
        }
    }
}
