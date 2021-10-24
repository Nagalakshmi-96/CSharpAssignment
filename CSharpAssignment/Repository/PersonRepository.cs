using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment.Interface;
using CSharpAssignment.Entities;

namespace CSharpAssignment.Repository
{
    public class PersonRepository : IProcessPerson
    {
        #region Initializing Variables
        List<Person> personList = new List<Person>();

        //assuming 150 as the maximum value for the age
        int minAge = 150;
        int tempAge; 
        #endregion

        #region Add Person Method
        public bool Add(Person person)
        {
            if (!personList.Any(p => p.EmailAddress == person.EmailAddress))
            {
                personList.Add(person);
                return true;
            }
            else
            {
                return false;
            }

        } 
        #endregion

        #region Delete Person Method
        public bool Delete(Person person)
        {
            int index = personList.FindIndex(x => x.EmailAddress == person.EmailAddress);

            if (index != -1)
            {
                personList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        } 
        #endregion

        #region Get All Person Method
        public List<Person> GetAll()
        {
            return personList;
        } 
        #endregion

        #region Get By Name Method
        public List<Person> GetByName(string name)
        {
            return personList.FindAll(x => name == (x.FirstName + " " + x.LastName));
        } 
        #endregion

        #region Get Minimum Age Method
        public int GetMinimumAge(string name)
        {
            List<Person> temp = personList.FindAll(x => name == (x.FirstName + " " + x.LastName));
            if (temp.Count > 0)
            {
                foreach (var o in temp)
                {
                    tempAge = (int)((DateTime.Now.ToOADate() - o.DateofBirth) / 365.2422);
                    if (tempAge < minAge)
                        minAge = tempAge;
                }
                return minAge;
            }
            else
            {
                return -1;
            }

        } 
        #endregion
    }
}
