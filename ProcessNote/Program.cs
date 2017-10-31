using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] localAll = Process.GetProcesses();
            Console.WriteLine(localAll);
            int counter = 0;
            foreach (var item in localAll)
            {
                Console.WriteLine("{0}: Name: {1}   Id: {2}",counter++, item.ProcessName, item.Id);
            }
            Console.WriteLine("Please, enter the chosen id: ");
            string input = Console.ReadLine();
            int id;
            if (Int32.TryParse(input,out id))
            {
                try
                {
                    Process chosenProcess = Process.GetProcessById(id);
                    Console.WriteLine("Name: {0} Id: {1} Thread: {2}\n" +
                        "CPU usage: {3} Memory usage: {4}", chosenProcess.ProcessName, chosenProcess.Id, chosenProcess.ProcessorAffinity,
                        chosenProcess.UserProcessorTime, chosenProcess.PrivateMemorySize64);
                } catch(Exception e)
                {
                    if (e is ArgumentException)
                    {
                        Console.WriteLine("There is no process with that id: '{0}'", id);
                    } else if (e is Win32Exception){
                        Console.WriteLine("Permission denied.");
                    }
                }
            } else
            {
                Console.WriteLine("Error, maybe type-o?: '{0}'", input);
            }
            Console.ReadKey();

        }

    }
}
