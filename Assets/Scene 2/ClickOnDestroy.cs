using UnityEngine;

public class ClickDestroy : MonoBehaviour
{
    public float destroyTimer;
    void OnMouseDown() => Destroy(gameObject);

    void Start()
    {
        Destroy(gameObject, destroyTimer);
    }
}