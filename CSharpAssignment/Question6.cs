using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment.Interface;
using CSharpAssignment.Repository;

namespace CSharpAssignment
{
    class Question6
    {
        public void answer6()
        {
            IProcessPerson personRepoObj = new PersonRepository();

            #region Adding New Person to the list
            
            string FirstName = "Sathesh";
            string LastName = "Rangasamy";
            string EmailAddress = "sathesh.r@vernal.is";
            double DateofBirth = new DateTime(1997, 06, 23).ToOADate();
            Console.WriteLine("\n***************Assignment6***************\n");
            Console.WriteLine("Adding New Person -->{0}", personRepoObj.Add(new Entities.Person { FirstName = FirstName, LastName = LastName, EmailAddress = EmailAddress, DateofBirth = DateofBirth + 1000 }));
            Console.WriteLine("Adding New Person With Same Data-->{0}", personRepoObj.Add(new Entities.Person { FirstName = FirstName, LastName = LastName, EmailAddress = EmailAddress, DateofBirth = DateofBirth + 1000 }));
            Console.WriteLine("Adding New Person -->{0}", personRepoObj.Add(new Entities.Person { FirstName = FirstName, LastName = LastName, EmailAddress = "sathesh@vernal.is", DateofBirth = DateofBirth }));
            Console.WriteLine("Adding New Person -->{0}", personRepoObj.Add(new Entities.Person { FirstName = "Harish", LastName = "Ramesh", EmailAddress = "harish@vernal.is", DateofBirth = DateofBirth }));
            #endregion

            #region Deleting Person Details
            Console.WriteLine("\n-----------------------------------------\n");
            //Console.WriteLine(personRepoObj.Delete(new Entities.Person { FirstName = FirstName, LastName = LastName, EmailAddress = EmailAddress, DateofBirth = DateofBirth }));
            Console.WriteLine("Deleting Person-->{0}", personRepoObj.Delete(new Entities.Person { FirstName = "Harish", LastName = "Ramesh", EmailAddress = "harish@vernal.is", DateofBirth = DateofBirth }));
            Console.WriteLine("Deleting Same Person-->{0}", personRepoObj.Delete(new Entities.Person { FirstName = "Harish", LastName = "Ramesh", EmailAddress = "harish@vernal.is", DateofBirth = DateofBirth }));

            #endregion

            #region Getting All User Details
            Console.WriteLine("\n-----------Fetching All user details -----------\n");
            var userList = personRepoObj.GetAll();

            if (userList.Count > 0)
            {
                foreach (var o in userList)
                {
                    Console.WriteLine("{0},{1},{2},{3}", o.FirstName, o.LastName, o.EmailAddress, DateTime.FromOADate(o.DateofBirth).ToShortDateString());
                }
            }
            else
            {
                Console.WriteLine("No User Details Available");
            }
            #endregion

            #region Fetching User Details for Given Name
            Console.WriteLine("\n-----------Fetching user details with the name Sathesh Rangasamy-----------\n");
            var nameList = personRepoObj.GetByName("Sathesh Rangasamy");
            if (nameList.Count > 0)
            {
                foreach (var o in userList)
                {
                    Console.WriteLine("{0},{1},{2},{3}", o.FirstName, o.LastName, o.EmailAddress, DateTime.FromOADate(o.DateofBirth).ToShortDateString());
                }
            }
            else
            {
                Console.WriteLine("No User Details Available");
            }
            #endregion

            #region Fetching Min Age for the Given Name
            Console.WriteLine("\n-----------Fetching min age for the name Sathesh Rangasamy-----------\n");

            int age = personRepoObj.GetMinimumAge("Sathesh Rangasamy");

            if (age != -1)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("No User Details Available for the given name");
            }
            Console.WriteLine("\n*****************************************\n");
            #endregion
        }
    }
}
