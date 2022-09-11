using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    //Creates section in Inspector to show all variables
    [Header("Set in Inspector")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    void Start()
    {
        //Creates 3 instances of Basket placing them one another
        for(int i=0; i < numBaskets; i++){
            GameObject tBasketGO = Instantiate<GameObject>( basketPrefab );
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + ( basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppleDestroyed(){
        //delete all fallen apples
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach ( GameObject tGO in tAppleArray){
            Destroy ( tGO );
        }
    }
}
