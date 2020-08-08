using UnityEngine;

public abstract class SingletonPersistentNewGameobject<T> : SingletonNewGameObject<T> where T : MonoBehaviour, new()
{
    protected virtual void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}