using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmasankarTestC
{
    struct WorkTask
    {
        private string description;
        private int hours;

        public WorkTask(string v1, int v2) : this()
        {
            this.description = v1;
            this.hours = v2;
        }

       

        public void  PerformWorkTask()
        {
            Console.WriteLine($"Task {description} of {hours} hour(s) has been performed.");
        }
    }
}
