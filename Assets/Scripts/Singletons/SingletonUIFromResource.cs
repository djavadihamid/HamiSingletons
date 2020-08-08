using UnityEngine;

public class SingletonUiFromResource<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _ins;

    public static T Ins
    {
        get
        {
            if (_ins == null)
            {
                _ins = Instantiate(Resources.Load<GameObject>($"Prefabs/{typeof(T).Name}"), SceneCanvas.Ins.transform)
                    .GetComponent<T>();
            }

            return _ins;
        }
    }
}