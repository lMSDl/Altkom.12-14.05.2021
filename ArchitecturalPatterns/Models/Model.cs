using ArchitecturalPatterns.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatterns.Models
{
    public class Model : NotifyPropertyChanged
    {
        private string _value;

        public string Value
        {
            get => _value;
            set
            {
                this._value = value;
                OnPropertyChanged();
            }
        }
    }
}
