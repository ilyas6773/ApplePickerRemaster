using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [Header("Set in Inspector")]
    public static float bottomY = -20f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY){
            Destroy(this.gameObject);

            //Get a reference to the Main Camera ApplePicker component
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            //Call public method AppleDestroyed() from apScript
            apScript.AppleDestroyed();
        }
    }
}
