using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote
{
    class RunningProcess
    {
        private string name;
        private int id, cpuAffinity, cpuUsage, memoryUsage;

        public RunningProcess(Process process)
        {
            this.id = process.Id;
            this.name = process.ProcessName;
            //this.cpuAffinity = process.ProcessorAffinity;
            //this.cpuUsage = ;
            //this.memoryUsage = process.PrivateMemorySize64;
        }

        public int Id
        {
            get {return id; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
