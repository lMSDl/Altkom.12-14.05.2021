using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Person : INotifyPropertyChanged, ICloneable, IRestorable<Person>
    {
        private string name;
        private DateTime birthDate;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                birthDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BirthDate)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
            Name = state.Name;
            BirthDate = state.BirthDate;
        }
    }
}
