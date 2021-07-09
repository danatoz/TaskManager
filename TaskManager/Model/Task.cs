using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.ViewModel;

namespace TaskManager.Model
{
    public class Task : ViewModel.Base.ViewModel
    {


        private string _dateTime;
        private string _headerTask;
        private bool _taskDone;

        public int Id { get; set; }

        public bool TaskIsDone
        {
            get => _taskDone;
            set
            {
                _taskDone = value;
                OnPropertyChanged("TaskIsDone");
            }
        }

        public string HeaderTask
        {
            get => _headerTask;
            set
            {
                _headerTask = value;
                OnPropertyChanged("HeaderTask");
            }
        }

        public string DateOfCreation
        {
            get => _dateTime;
            set
            {
                _dateTime = value;
                OnPropertyChanged("DateOfCreation");
            }
        }
        public string DeadLine { get; set; }
        public bool RepeatTask { get; set; }
        public bool TaskFavorite { get; set; }

    }
}
