using Unity.Mathematics;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Ant;
    public Transform spawn;
    public float Minimum 0.2f;
    public float Maximum 10f;
    public float timeUntilSpawn;    
   //Called at the start of the game
    void Awake()
    {
      SetTimeUntilSpawn ();
    }

    void Update () 
    {
        timeUntilSpawn = Time.deltaTime
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Instantiate(Ant, spawn.position, quaternion.identity);
    }
    public void SetTimeUntilSpawn () 
    {
      timeUntilSpawn = Random.Range ( Minimum, Maximum);
    }
}
