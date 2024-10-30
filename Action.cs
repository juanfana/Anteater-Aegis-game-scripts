using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Action : MonoBehaviour
{
    public bool IsTouching; 

     public Collider2D Polygon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Polygon = GetComponent<Collider2D>();

         if (Polygon.isTrigger)
        {
          IsTouching = true;
          Debug.Log("IsTouching = true");
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Destroy(gameObject);
           Debug.Log("Detroyed");
        }
    }



}
