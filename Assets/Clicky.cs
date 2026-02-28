using UnityEngine;

public class Clicky : MonoBehaviour
{
void OnMouseDown()
    {
Animation anim = GetComponent<Animation>();
        if (anim != null)
        {
            anim.Play();
        }
    }
}
