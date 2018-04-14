using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {
            
        }

        private static readonly object padlock = new object();
        private static ThreadSafeSingleton instance;

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }

                    return instance;
                }
            }
        }
    }
}
