using UnityEngine;

public abstract class SingletonPersistantUIFromResources<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _ins;

    public static T Ins
    {
        get
        {
            if (_ins == null)
            {
                _ins = Instantiate(Resources.Load<GameObject>($"Prefabs/{typeof(T).Name}"), GlobalCanvas.Ins.transform)
                    .GetComponent<T>();
            }

            return _ins;
        }
    }
}