using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class inventoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    private componentManager.basicInventory playerInventory;
    void Start()
    {
        playerInventory = new componentManager.basicInventory();
        playerInventory.addItem(new componentManager.basicItem("cucumber",null));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i")){
            foreach(string toPrint in playerInventory.getInventoryItems())
            {
                Debug.Log(toPrint);
            }
        }
    }
}
