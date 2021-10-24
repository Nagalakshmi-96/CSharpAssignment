using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class Question5
    {
        public void answer5()
        {
            string ScheduledTime = System.Configuration.ConfigurationManager.AppSettings["ScheduledTime"];
            string[] ScheduledTimeParts = ScheduledTime.Split(new char[1] { ':' });

            Console.WriteLine("The Scheduled time for the Function --> {0}", ScheduledTime);

            while (true)
            {
                DateTime currentDate = DateTime.Now;

                DateTime ScheduledDateTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, int.Parse(ScheduledTimeParts[0]), int.Parse(ScheduledTimeParts[1]), int.Parse(ScheduledTimeParts[2]));

                TimeSpan ts;

                if (ScheduledDateTime > currentDate)
                    ts = ScheduledDateTime - currentDate;
                else
                {
                    ScheduledDateTime = ScheduledDateTime.AddDays(1);
                    ts = ScheduledDateTime - currentDate;
                }

                Task.Delay(ts).Wait();
                DisplayMessage();
                
            }
        }
        static void DisplayMessage()
        {
            Console.WriteLine("***********Method is called at {0}***********", DateTime.Now);
        }
    }
}
