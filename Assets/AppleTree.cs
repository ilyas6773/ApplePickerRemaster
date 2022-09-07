using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    //Apple instance
    public GameObject applePrefab;

    //Apple movement speed
    public float speed = 1f;

    //Left and Right edges of the Scene
    public float leftAndRightEdge = 10f;

    //Chance of changing the direction of the tree
    public float chanceToChangeDirections = 0.1f;

    //Apple creation frequency
    public float secondsBetweenAppleDrops = 1f;

    void Start()
    {
        //Drop apples once in a second
        
    }

    void Update()
    {
        //Simple movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Direction change
        if( pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);            //start moving to the right
        }else if ( pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);           //start moving to the left
        }
    }

    void FixedUpdate()
    {
        //random direction change is tied to time
        //because it is executed in FixedUpdate()
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1; //change direction
        }
    }
}
