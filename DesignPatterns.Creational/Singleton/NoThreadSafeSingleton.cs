using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class NoThreadSafeSingleton
    {
        private NoThreadSafeSingleton()
        {
            
        }

        public static NoThreadSafeSingleton instance;

        public static NoThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NoThreadSafeSingleton();
                }

                return instance;
            }
        }
    }
}
