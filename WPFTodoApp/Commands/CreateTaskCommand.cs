using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFTodoApp.ViewModels;

namespace WPFTodoApp.Commands
{
    public class CreateTaskCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);

            if (parameter is MainViewModel viewModel)
            {
                return !string.IsNullOrWhiteSpace(viewModel.NewTaskName);
            }

            return false;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainViewModel viewModel)
            {
                viewModel.Tasks.Add(new TaskViewModel()
                {
                    IsComplete = false,
                    TaskName = viewModel.NewTaskName
                });

                viewModel.NewTaskName = string.Empty;

                this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
