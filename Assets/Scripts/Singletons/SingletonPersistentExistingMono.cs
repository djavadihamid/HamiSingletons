using UnityEngine;

public abstract class SingletonPersistentExistingMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _ins;

    public static T Ins => _ins;

    protected virtual void Awake()
    {
        if (_ins == null)
        {
            _ins = this as T;
        }
        else if (!Equals(_ins, this))
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);
    }
}
