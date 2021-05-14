using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Caretaker<T> : IDisposable where T : IRestorable<T>, ICloneable
    {
        private List<Memento<T>> _mementos = new List<Memento<T>>();
        private T _originator;
        private INotifyPropertyChanged _notify;
        public Caretaker(T originator)
        {
            _originator = originator;
            SaveSate();
            _notify = _originator as INotifyPropertyChanged;
            if(_notify != null)
                _notify.PropertyChanged += Notify_PropertyChanged;
        }

        private void Notify_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            SaveSate();
        }

        public void SaveSate()
        {
            Console.WriteLine($"Caretaker: zapisywanie stanu..");
            var memento = new Memento<T>((T)_originator.Clone());
            _mementos.Add(memento);
        }


        public void Undo(DateTime dateTime)
        {
            //TODO
        }

        public void RestoreBeginState()
        {
            _mementos = _mementos.Take(1).ToList();
            Undo();
        }

        public void Undo()
        {
            if (!_mementos.Any())
                return;

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine($"Caretaker: przywracanie stanu z: {memento.DateTime.ToLongTimeString()}");

            if (_notify != null)
                _notify.PropertyChanged -= Notify_PropertyChanged;
            memento.Restore(_originator);
            if (_notify != null)
                _notify.PropertyChanged += Notify_PropertyChanged;
        }

        public void ShowHistory()
        {
            Console.WriteLine($"Caretaker: {_mementos.Count} stanów");
            _mementos.ToList().ForEach(x => Console.WriteLine(x.DateTime.ToLongDateString()));
        }

        public void Dispose()
        {
            if (_notify != null)
                _notify.PropertyChanged -= Notify_PropertyChanged;
            _notify = null;
            _originator = default;
            _mementos = null;
        }
    }
}
