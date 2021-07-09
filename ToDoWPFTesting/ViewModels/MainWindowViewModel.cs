using System;
using System.Collections.Generic;
using System.Text;
using ToDoWPFTesting.ViewModels.Base;

namespace ToDoWPFTesting.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _title = "Hello world!";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
    }
}
