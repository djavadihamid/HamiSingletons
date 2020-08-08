using System;

public class EditorSingleton<T> : UnityEditor.Editor where T : class, new()
{
    private static Lazy<T> _ins = new Lazy<T>(() => new T());
    public static T Ins => _ins.Value;

    protected EditorSingleton()
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