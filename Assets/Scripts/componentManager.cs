using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public class movementComponent
    {
        private GameObject controledObject;
        public movementComponent(GameObject objectToSet)
        {
            this.controledObject = objectToSet;
        }
        public void moveObject(float x,float y, float z)
        {
            controledObject.transform.position += new Vector3(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
