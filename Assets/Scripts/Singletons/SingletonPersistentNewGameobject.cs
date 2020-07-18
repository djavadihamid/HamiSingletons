using System;
using UnityEngine;

public abstract class SingletonPersistentNewGameobject<T> : MonoBehaviour where T : MonoBehaviour, new()
{
    private static Lazy<T> _ins = new Lazy<T>(() => { return new GameObject(typeof(T).Name).AddComponent<T>(); });
    public static T Ins => _ins.Value;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    protected void ResetInstance()
    {
        _ins = new Lazy<T>(() => { return new GameObject(typeof(T).Name).AddComponent<T>(); });
    }
}