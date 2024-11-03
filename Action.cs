using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Action : MonoBehaviour
{
//Boolean value created for collision detection
    public bool IsTouching; 
//declaring collider that will be used     
     public Collider2D Polygon;
    // setting up collider trigger for when certain colliders come in contact with each other
    void Start()
    {
        Polygon = GetComponent<Collider2D>();

         if (Polygon.isTrigger)
        {
          IsTouching = true;
          Debug.Log("IsTouching = true");
        }

    }

    // "Eating" button that emulates eating action when coming into contact with enemies
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Destroy(gameObject);
           Debug.Log("Detroyed");
        }
    }



}
