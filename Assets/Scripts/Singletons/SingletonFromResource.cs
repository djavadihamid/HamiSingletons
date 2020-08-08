using UnityEngine;

public class SingletonFromResource<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _ins;

    public static T Ins
    {
        get
        {
            if (_ins == null)
            {
                _ins = Instantiate(Resources.Load<GameObject>($"Prefabs/{typeof(T).Name}"))
                    .GetComponent<T>();
            }

            return _ins;
        }
    }
}