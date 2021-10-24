using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment.Entities;

namespace CSharpAssignment
{
    class Question3
    {
        public void answer3()
        {
            #region Initializing Original and Copy Class
            DecimalFields<decimal> c1 = new DecimalFields<decimal>();
            DecimalFields<decimal> c2 = new DecimalFields<decimal>();
            int localVar = 3;
            #endregion

            #region Initialize Decimal Fields
            int i = 0;
            List<decimal> list = new List<decimal>();
            for (i = 0; i < 10; i++)
                list.Add(0.5m + i);

            i = 0;
            foreach (var prop in c1.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(decimal))
                {
                    prop.SetValue(c1, list[i++]);
                }
            }

            #endregion

            #region Performing Copy
            c2 = c1.Copy();
            #endregion

            #region Performing Application Logic

            foreach (var prop in c1.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(decimal))
                {
                    prop.SetValue(c1, (decimal)prop.GetValue(c1) / localVar);
                    prop.SetValue(c2, (decimal)prop.GetValue(c2) - (decimal)prop.GetValue(c1));
                }
            }

            #endregion

            #region Printing the Values
            Console.WriteLine("\n***************Assignment3***************\n");
            foreach (var prop in c1.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(decimal))
                {
                    Console.WriteLine("\n-------{0}--------\n",prop.Name);
                    Console.WriteLine("Obj 1-->  {0}", prop.GetValue(c1));
                    Console.WriteLine("Obj 2-->  {0}",prop.GetValue(c2));
                }
            }
            Console.WriteLine("\n*****************************************\n");
            #endregion

        }
    }
}
