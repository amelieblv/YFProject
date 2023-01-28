using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentManager : MonoBehaviour
{
    // Это тот самый сборник компонентов, поэтому прежде чем менять тут что-то ПОДУМАЙТЕ ТЩАТЕЛЬНО!!!
    public class movementComponent
    {
        protected GameObject controledObject;
        public movementComponent(GameObject objectToSet)
        {
            this.controledObject = objectToSet;
        }
        public void moveObject(float x,float y, float z)
        {
            controledObject.transform.position += controledObject.transform.forward * z * Time.deltaTime;
            controledObject.transform.position += controledObject.transform.right * x * Time.deltaTime;
            controledObject.GetComponent<Rigidbody>().AddForce(Vector3.up * y * Time.deltaTime);
        }
        public virtual void rotateObject(float rotateX, float rotateY, float rotateZ) {
            controledObject.transform.Rotate(Vector3.up * rotateY);
            controledObject.transform.Rotate(Vector3.forward * rotateZ);
            controledObject.transform.Rotate(Vector3.right * rotateX);
        }
    }

    public class limitedMovementComponent : movementComponent
    {

        public limitedMovementComponent(GameObject objectToSet) :base(objectToSet) 
        {
        }
        public override void rotateObject(float rotateX, float rotateY, float rotateZ)
        {
            controledObject.transform.Rotate(Vector3.up * rotateY);
            controledObject.transform.Rotate(Vector3.forward * rotateZ);
            controledObject.transform.Rotate(Vector3.right * rotateX);

            Quaternion rot = controledObject.transform.localRotation;
            if (rot.x > 0.7f)
            {
                controledObject.transform.localEulerAngles = new Vector3(82f, rot.y, rot.z);
            }
            if (rot.x < -0.7f)
            {
                
                controledObject.transform.localEulerAngles = new Vector3(-82f, rot.y, rot.z);

            }
            else
            {
                Debug.Log(rot.x);
            }
        }
    }

    void Update()
    {
        
    }
}
