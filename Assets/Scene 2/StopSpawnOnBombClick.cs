using UnityEngine;

public class StopSpawnOnBombClick : MonoBehaviour
{
    // Reference the Spawner script component
    public RandomSpawner spawnerScript;


    void Start()
{
    // Finds the object by its exact name in the scene
    spawnerScript = GameObject.Find("Spawner").GetComponent<RandomSpawner>();
}
    void OnMouseDown()
    {
        if (spawnerScript != null)
        {
            // Stops the InvokeRepeating in the spawner
            spawnerScript.CancelInvoke("Spawn");
            Debug.Log("Spawning stopped, but object still exists.");
        }
    }
}