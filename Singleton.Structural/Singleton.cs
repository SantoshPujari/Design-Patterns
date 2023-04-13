using System;

namespace Singleton.Structural
{
    class Singleton
    {
       static Singleton _singleton;

        

        private Singleton()
        {
            log = DateTime.Today.ToString();
        }

        public static Singleton Instance()
        {

            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
            return _singleton;

        }

        public string log { get; }
    }
}
