using System;
using System.Collections.Generic;
using System.Text;
using ToDoWPFTesting.ViewModels.Base;

namespace ToDoWPFTesting.Models
{
    class Model : ViewModel
    {
        private bool _checkBoxTest;

        public bool CheckBoxTest
        {
            get => _checkBoxTest;
            set => Set(ref _checkBoxTest, value);
        }
    }
}
