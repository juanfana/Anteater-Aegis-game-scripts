using Unity.Mathematics;
using UnityEngine;

public class Spawn : MonoBehaviour
{
//These values can be assigned and tampered with on the editor
//GameObject the will be spawned
//Postion where it will be spawned
//Floats for time between spawns
    public GameObject;
    public Transform;
    public float timeUntilSpawn;
    public float Minimum;
    public float Maximum ;    
   //Used awake instead of start so it can be initialized when the scene first loads
    void Awake()
    {
      SetTimeUntilSpawn ();
    }
    // If statement to check if spawn value reaches zero, allowing the next enemy to spawn
    void Update () 
    {
        timeUntilSpawn -= Time.deltaTime
        if(timeUntilSpawn <=0)
        {
          Instantiate(GameObject, transform.position, Quaternion.indentity);
          SetTimeUntilSpawn ();

        } 
    }
    //Method created to give timeUntilSpawn value
    public void SetTimeUntilSpawn () 
    {
      timeUntilSpawn = Random.Range ( Minimum, Maximum);
    }
}
