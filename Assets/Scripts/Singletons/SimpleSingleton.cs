using System;

namespace Modules.Singleton
{
    public abstract class SimpleSingleton<T> where T : class, new()
    {
        private static Lazy<T> _ins = new Lazy<T>(() => new T());
        public static T Ins => _ins.Value;

        protected SimpleSingleton()
        {
            Init();
        }

        protected virtual void Init()
        {
        }

        protected void ResetInstance()
        {
            _ins = new Lazy<T>(() => new T());
        }
    }
}