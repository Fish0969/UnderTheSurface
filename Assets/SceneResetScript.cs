using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneResetScript : MonoBehaviour
{
public void ResetScene()
    {
        SceneManager.LoadScene("Focus");
    }
}
