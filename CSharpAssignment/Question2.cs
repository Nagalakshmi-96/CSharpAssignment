﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment.Entities;
namespace CSharpAssignment
{
    class Question2
    {
        public void answer2()
        {
            #region Assigning And initializing List and Dictionaray
            List<OverlappingDays> data = new List<OverlappingDays>();
            Dictionary<Tuple<string, string>, List<Dates>> dict = new Dictionary<Tuple<string, string>, List<Dates>>();

            data.Add(new OverlappingDays { FromID = "S1", ToID = "S2", StartDate = new DateTime(2016, 1, 1), EndDate = new DateTime(2016, 1, 15) });

            //Test Cases
            //data.Add(new OverlappingDays { FromID = "S2", ToID = "S3", StartDate = new DateTime(2016, 3, 16), EndDate = new DateTime(2016, 3, 17) });

            data.Add(new OverlappingDays { FromID = "S2", ToID = "S3", StartDate = new DateTime(2016, 1, 25), EndDate = new DateTime(2016, 2, 25) });

            data.Add(new OverlappingDays { FromID = "S2", ToID = "S3", StartDate = new DateTime(2016, 2, 1), EndDate = new DateTime(2016, 3, 14) });

            data.Add(new OverlappingDays { FromID = "S1", ToID = "S2", StartDate = new DateTime(2016, 1, 21), EndDate = new DateTime(2016, 1, 25) });

            data.Add(new OverlappingDays { FromID = "S1", ToID = "S2", StartDate = new DateTime(2016, 1, 5), EndDate = new DateTime(2016, 1, 20) });
            #endregion

            #region Printing Original 
            Console.WriteLine("\n***************Assignment1***************\n");
            Console.WriteLine("\n*************Original Table*************\n");
            Console.WriteLine("FromID  ToID      StartDate       EndDate");
            foreach (var o in data)
            {
                Console.WriteLine("{0}       {1}       {2}       {3}", o.FromID, o.ToID, o.StartDate.ToShortDateString(), o.EndDate.ToShortDateString());
            }
            #endregion

            #region Adding Keys and Values to the Dictionary
            foreach (var o in data)
            {
                var tupl = new Tuple<string, string>(o.FromID, o.ToID);
                var list = new Dates { StartDate = o.StartDate, EndDate = o.EndDate };
                if (dict.ContainsKey(tupl))
                {
                    dict[tupl].Add(list);
                }
                else
                {
                    List<Dates> list1 = new List<Dates>();
                    list1.Add(list);
                    dict.Add(tupl, list1);
                }
            }
            #endregion

            #region Performing Assignment Question Logic
            foreach (var a in dict)
            {
                dict[a.Key].Sort((x, y) => x.StartDate.CompareTo(y.StartDate));
                for (int i = 0; i < dict[a.Key].Count - 1; i++)
                {
                    if (dict[a.Key][i].EndDate > dict[a.Key][i + 1].StartDate || (dict[a.Key][i].EndDate.AddDays(1) == dict[a.Key][i + 1].StartDate))
                    {
                        if (dict[a.Key][i].EndDate <= dict[a.Key][i + 1].EndDate)
                        {
                            dict[a.Key][i].EndDate = dict[a.Key][i + 1].EndDate;
                            dict[a.Key].RemoveAt(i + 1);
                            i--;
                        }

                    }
                }

            }
            #endregion

            #region Printing Merged Table
            Console.WriteLine("\n*************Merged Table*************\n");
            Console.WriteLine("FromID  ToID      StartDate       EndDate");
            foreach (var a in dict)
            {

                foreach (var o in dict[a.Key])
                {
                    Console.WriteLine("{0}       {1}       {2}       {3}", a.Key.Item1, a.Key.Item2, o.StartDate.ToShortDateString(), o.EndDate.ToShortDateString());
                }
            }
            Console.WriteLine("\n*****************************************\n"); 
            #endregion
        }
    }
}
