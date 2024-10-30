using Unity.Mathematics;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Ant;
    public Transform spawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Instantiate(Ant, spawn.position, quaternion.identity);
    }
}
