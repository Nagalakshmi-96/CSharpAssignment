using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment.Entities;
namespace CSharpAssignment
{
    class Question4
    {
        public void answer4()
        {
            #region Initializing Original List
            List<Values> OrigList = new List<Values>();
            
            DateTime dayStart = new DateTime(2016, 1, 1);
            double dayStartNumber = dayStart.ToOADate();

            int i;

            for (i = 1; i <= 10; i++)
                OrigList.Add(new Values { Column1 = "B" + i, Column2 = "Item" + i, Column3 = dayStartNumber + i, Column4 = 100 + i });

            #endregion

            #region Cloning Original List
            var CloneList = new List<Values>();

            foreach (var obj in OrigList)
                CloneList.Add((Values)obj.Clone());
            #endregion

            #region Printing Original and Cloned List
            Console.WriteLine("\n***************Assignment4***************\n");
            Console.WriteLine("Original List");
            foreach (var obj in OrigList)
                Console.WriteLine("{0}  {1}  {2}  {3} ", obj.Column1, obj.Column2, DateTime.FromOADate(obj.Column3).ToShortDateString(), obj.Column4);

            Console.WriteLine("\n------------");
            Console.WriteLine("Cloned List");
            foreach (var obj in CloneList)
                Console.WriteLine("{0}  {1}  {2}  {3} ", obj.Column1, obj.Column2, DateTime.FromOADate(obj.Column3).ToShortDateString(), obj.Column4);
            #endregion

            #region Altering Original List
            int j = 10;

            foreach (var obj in OrigList)
                obj.Column2 = "Item" + (++j);

            OrigList.RemoveAt(0);
            OrigList.RemoveAt(0);
            OrigList.Add(new Values { Column1 = "B" + i, Column2 = "Item" + (++j), Column3 = dayStartNumber + i, Column4 = 100 + i });

            Console.WriteLine("\n------------");
            Console.WriteLine("Altered List");
            foreach (var obj in OrigList)
                Console.WriteLine("{0}  {1}  {2}  {3} ", obj.Column1, obj.Column2, DateTime.FromOADate(obj.Column3).ToShortDateString(), obj.Column4);
            #endregion

            #region Reverting the Changes and printing the List
            OrigList = CloneList;
            Console.WriteLine("\n------------");
            Console.WriteLine("After Reverting back the Changes");
            foreach (var obj in OrigList)
                Console.WriteLine("{0}  {1}  {2}  {3} ", obj.Column1, obj.Column2, DateTime.FromOADate(obj.Column3).ToShortDateString(), obj.Column4);
            Console.WriteLine("\n*****************************************\n"); 
            #endregion
        }
    }
}
