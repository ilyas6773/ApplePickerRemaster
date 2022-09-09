using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Recieve current coordinates of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;

        //Z coordinate of the camera determines how far is the 
        //mouse pointer in 3D space
        mousePos2D.z = -Camera.main.transform.position.z;

        //Transform 2D position into 3D coordinates of the game
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //Move Basket along X axis to the X coordinate of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
}
