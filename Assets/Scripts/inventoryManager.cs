using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class inventoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    private componentManager.basicInventory playerInventory= new componentManager.basicInventory();
    private componentManager.itemBuilder itemRegister = new componentManager.itemBuilder();
    void Start()
    {
        itemRegister.registerItems();
        playerInventory.addItem(itemRegister.registeredItems["cucumber"]);
        playerInventory.addItem(itemRegister.registeredItems["apple"]);
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
