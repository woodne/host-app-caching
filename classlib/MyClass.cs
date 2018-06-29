using System;
using System.Runtime.Caching;
using boot;

namespace classlib
{
    public class MyClass : IMyInterface
    {
        private readonly ObjectCache myCache;

        public MyClass()
        {
            this.myCache = new MemoryCache("CoolCache");
            
            Console.WriteLine("Hello! It works!");
        }
    }
}