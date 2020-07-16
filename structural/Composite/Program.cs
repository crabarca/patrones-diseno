using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Task(10);
            var task2 = new Task(10);
            var task3 = new Task(10);
            var task4 = new Task(10);
            
            var taskGroup1 = new Composite(new List<IComposite>
            {
                task1, task2, task3
            });
            
            var taskGroup2 = new Composite(new List<IComposite>
            {
                taskGroup1, task4
            });

            var totalDuration = taskGroup2.Duration;
        }
    }
}