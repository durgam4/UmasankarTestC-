using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal  struct WorkTask
    {
        public string description;
        public int hours;

        public  WorkTask(string description, int hours)
        {
             this.description = description;
            this.hours = hours;

        }
        public string PerformWorkTask()
        {
            Console.WriteLine($"Task: {description} has been completed in {hours} hours.");
            return "Amazing Work";
        }   

    }
}
