using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTodoApp.ViewModels
{
    public class MainViewModel
    {
        public string NewTaskName { get; set; }
        public List<TaskViewModel> Tasks { get; set; }
    }

    public class TaskViewModel
    {
        public string TaskName { get; set; }
        public bool IsComplete { get; set; }
    }
}
