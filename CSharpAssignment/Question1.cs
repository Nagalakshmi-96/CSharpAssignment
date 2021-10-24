using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment.Entities;

namespace CSharpAssignment
{
    class Question1
    {
        public void answer1()
        {
            #region Declaring Variables
            double i, RangeStart, RangeEnd;
            int RangeCount = 1;
            IDictionary<double, int> DateDictionary = new Dictionary<double, int>();
            IList<ProductionDetails> pd = new List<ProductionDetails>(); 
            #endregion

            #region Declaring Values for Start and End Ranges 
            double StartDateNumber = new DateTime(2016, 1, 1).ToOADate();
            double EndDateNumber = new DateTime(2016, 12, 31).ToOADate();

            double range1StartNumber = new DateTime(2016, 2, 15).ToOADate();
            double range1EndNumber = new DateTime(2016, 3, 18).ToOADate();

            double range2StartNumber = new DateTime(2016, 6, 2).ToOADate();
            double range2EndNumber = new DateTime(2016, 8, 20).ToOADate(); 
            #endregion

            #region Performing Assignment Question Logic
            for (i = StartDateNumber; i <= EndDateNumber; i++)
                DateDictionary.Add(i, 0);



            for (i = range1StartNumber; i <= range1EndNumber; i++)
                DateDictionary[i] = 1;
            for (i = range2StartNumber; i <= range2EndNumber; i++)
                DateDictionary[i] = 1;

            i = StartDateNumber;

            while (i <= EndDateNumber)
            {
                if (DateDictionary[i] == 0)
                {
                    RangeStart = i;
                    while (i <= EndDateNumber && DateDictionary[i] == 0)
                        i++;
                    RangeEnd = i - 1;
                    pd.Add(new ProductionDetails() { ProductID = RangeCount, ProductName = "Test" + RangeCount, StartDate = RangeStart, EndDate = RangeEnd });
                    RangeCount++;
                }
                i++;
            }
            #endregion

            #region Printing the Output

            Console.WriteLine("\n***************Assignment1***************\n");

            Console.WriteLine("ProductionID ProductName StartDate EndDate");
            foreach (var obj in pd)
                Console.WriteLine("     {0}          {1}     {2}  {3} ", obj.ProductID, obj.ProductName, DateTime.FromOADate(obj.StartDate).ToShortDateString(), DateTime.FromOADate(obj.EndDate).ToShortDateString());

            Console.WriteLine("\n*****************************************\n");
            #endregion

        }
    }
}
