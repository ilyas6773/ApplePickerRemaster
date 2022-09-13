using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    //Creates section in Inspector to show all variables
    [Header("Set in Inspector")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    public List<GameObject> basketList;
    void Start()
    {
        basketList = new List<GameObject>();
        //Creates 3 instances of Basket placing them one another
        for(int i=0; i < numBaskets; i++){
            GameObject tBasketGO = Instantiate<GameObject>( basketPrefab );
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + ( basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
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

        //Destroy one of the baskets
        //Get the index of the last basket in basketList
        int basketIndex = basketList.Count-1;
        //Get a reference to that basket's gameobject
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        //If there are no baskets left, restart the game
        if( basketList.Count == 0){
            SceneManager.LoadScene( "Scene_0" );
        }
    }
}
