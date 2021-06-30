using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Model
{
    public class Task
    {
        private string dateTime;

        public bool TaskDone { get; set; }
        public string HeaderTask { get; set; }
        public string DateOfCreation
        {
            get => dateTime;
            set { value = dateTime = DateTime.Now.ToString(); }
        }
        public string DeadLine { get; set; }
        public bool RepeatTask { get; set; }
    }
}
