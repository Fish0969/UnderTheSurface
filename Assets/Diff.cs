using UnityEngine;

public class Diff : MonoBehaviour
{
public float pickaxeTimer;
public int MaxChildren;
public float letterTimer;
public GameObject pickaxe;
public GameObject letter;
public float TimerCHEESE;
    public void Differ()
    {
       pickaxeTimer = pickaxe.GetComponent<RandomSpawner>().spawnInterval;
       MaxChildren = pickaxe.GetComponent<RandomSpawner>().maxChildren;
       letterTimer = letter.GetComponent<KeyRandomizer>().interval;
    }

    public void Tim()
    {
        Time.timeScale = TimerCHEESE;

    }

}
