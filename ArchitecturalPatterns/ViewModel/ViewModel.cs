using ArchitecturalPatterns.Commands;
using ArchitecturalPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatterns.ViewModel
{
    public class ViewModel : NotifyPropertyChanged
    {
        private string _inputValue;

        public ViewModel()
        {
            Model = new Model();
            SaveCommand = new Command(x => InputValue != Model.Value, x => { Model.Value = InputValue; RaiseCommandsCanExecuteChanged(); });
            LoadCommand = new Command(x => InputValue != Model.Value, x => InputValue = Model.Value);
        }

        public Model Model { get; set; }

        public string InputValue
        {
            get => _inputValue;
            set
            {
                _inputValue = value;
                OnPropertyChanged();

                RaiseCommandsCanExecuteChanged();
            }
        }

        private void RaiseCommandsCanExecuteChanged()
        {
            SaveCommand.RaiseCanExecuteChanged();
            LoadCommand.RaiseCanExecuteChanged();
        }

        public Command SaveCommand { get; set; }
        public Command LoadCommand { get; set; }

    }
}
