using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Author: Charles Henry
/// Assignment: Homework Week 2
/// </summary>


namespace HomeworkWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });



            //1.Display to the console, all the passwords that are "hello".Hint: Where

            Console.WriteLine("1.Display to the console, all the passwords that are 'hello'");

            IEnumerable<Models.User> findHello = users.Where(t => t.Password == "hello") ;

            foreach (var myHello in findHello)
            {

                int mySubscript = users.IndexOf(myHello);
                string myName = myHello.Name.ToString();
                string myPassword = myHello.Password.ToString();

                string myNameAndPassword = "Index Number " + mySubscript + ", Name = " + myName + ", Password = " + myPassword;

                Console.WriteLine(myNameAndPassword);
            }

            Console.WriteLine();
            Console.WriteLine();


            //2.Delete any passwords that are the lower - cased version of their Name.Do not just look for "steve".It has to be data - driven.Hint: Remove or RemoveAll

            Console.WriteLine("2.Delete any passwords that are the lower - cased version of their NAME and list the remaining");

            var myIndex = users.FindIndex(t => t.Password.ToUpper() == t.Name.ToUpper());

            if (myIndex >= 0)
            {  
                users.RemoveAt(myIndex);
            }
                     
            foreach (var whatsLeft in users)

            {

                int mySubscript2 = users.IndexOf(whatsLeft);
                string myName2 = whatsLeft.Name.ToString();
                string myPassword2 = whatsLeft.Password.ToString();

                string myNameAndPassword2 = "Index Number " + mySubscript2 + ", Name = " + myName2 + ", Password = " + myPassword2;


                Console.WriteLine(myNameAndPassword2);

            }


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("3.Delete the first User that has the password 'hello'");


            var myIndex2 = users.FindIndex(t => t.Password == "hello");

            if (myIndex2 >= 0)
            {   // ensure item found
                users.RemoveAt(myIndex2);
            }


            Console.WriteLine("Index of Record Removed = " + myIndex2.ToString());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("4.Display to the console the remaining users with their Name and Password.");

            foreach (var whatsLeft2 in users)

            {

                int mySubscript3 = users.IndexOf(whatsLeft2);
                string myName3 = whatsLeft2.Name.ToString();
                string myPassword3 = whatsLeft2.Password.ToString();

                string myNameAndPassword3 = "Index Number " + mySubscript3 + ", Name = " + myName3 + ", Password = " + myPassword3;


                Console.WriteLine(myNameAndPassword3);

            }

                       

       



        }
    }
}
