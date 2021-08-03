using System;
using System.Collections.Generic;

namespace SortPay
{
    //1 Сортировка через интерфейс IComparer (с большего к меньшему)
    class Worker 
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public Worker(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class PayComparer : IComparer<Worker>
    {
        public int Compare(Worker x, Worker y)
        {
            return y.Salary - x.Salary;
        }
    }


    //2 Сортировка через интерфейс IComparable (с меньшего к большому )
    class WorkerV2 : IComparable<WorkerV2>
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public WorkerV2(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public int CompareTo(WorkerV2 other)
        {
            return Salary - other.Salary;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker[]
            {
                new Worker ("Abror", 1000),
                new Worker ("Komron", 940),
                new Worker ("Shamil", 10600),
                new Worker ("Akbar", 10000),
            };

            Array.Sort(worker, new PayComparer());

            for (int i = 0; i < worker.Length; i++)
            {
                Console.WriteLine($"{worker[i].Name} - {worker[i].Salary} $");
            }
            Console.WriteLine();


            var workerV2 = new WorkerV2[]
            {
                new WorkerV2 ("Kolya", 1100),
                new WorkerV2 ("Firuz", 970),
                new WorkerV2 ("Lyoxa", 1800),
                new WorkerV2 ("Tolik", 1200),
            };

            Array.Sort(workerV2);

            for (int i = 0; i < workerV2.Length; i++)
            {
                Console.WriteLine($"{workerV2[i].Name} - {workerV2[i].Salary} $");
            }
            Console.ReadLine();
        }
    }
}
