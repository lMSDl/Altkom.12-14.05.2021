using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Singleton
{
    public class Context
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Inicjalizacja ustawień");

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }

        private static Context instance;
        private static object _object = new object();
        /*public static Context GetInstance()
        {
                if (instance == null)
                    instance = new Context();
                return instance;
        }*/
        /*public static Context GetInstance()
        {
            lock (_object)
            {
                if (instance == null)
                    instance = new Context();
                return instance;
            }
        }*/
        /*public static Context GetInstance()
        {
            if (instance == null)
            {
                lock (_object)
                {
                    if (instance == null)
                        instance = new Context();
                }
            }
            return instance;
        }*/

        /*static Context()
        {

        }

        public static Context Instance { get; } = new Context();*/

        private static Lazy<Context> LazyInstance { get; } = new Lazy<Context>(() => new Context());
        public static Context Instance => LazyInstance.Value;


        public string GetSettings(string key)
        {
            return _settings[key];
        }
        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }
    }
}
