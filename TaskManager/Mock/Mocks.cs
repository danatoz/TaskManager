using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Model;

namespace TaskManager.Mock
{
    class Mocks
    {
        public List<Task> tasks = new List<Task>()
        {
            new Task(){HeaderTask = "Привет мир!",TaskDone = false, DeadLine = "30.06.2021",RepeatTask = true},
            new Task(){HeaderTask = "О этот мир",TaskDone = false, DeadLine = "30.06.2021",RepeatTask = true},
            new Task(){HeaderTask = "Просто мир!",TaskDone = false, DeadLine = "30.06.2021",RepeatTask = true}
        };
    }
}
