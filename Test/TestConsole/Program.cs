using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using DBToDo;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using TaskManager.Model;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new TaskContext();
            db.Tasks.Load();
            foreach (var a in db.Tasks.ToList())
            {
                if(a.TaskIsDone.ToString() == "1")
                    Console.WriteLine(a.HeaderTask);
            }
            Console.ReadKey();
        }
    }
}
