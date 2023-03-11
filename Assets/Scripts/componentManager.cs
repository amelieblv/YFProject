using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

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
        public void moveObject(float x, float y, float z)
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

        public limitedMovementComponent(GameObject objectToSet) : base(objectToSet)
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
                controledObject.transform.localEulerAngles = new Vector3(83f, rot.y, rot.z);
            }
            if (rot.x < -0.7f)
            {
                controledObject.transform.localEulerAngles = new Vector3(-83f, rot.y, rot.z);
            }
        }
    }

    public abstract class enemyNavigationComponent
    {
        protected GameObject target;
        protected NavMeshAgent agent;
        protected float lookRadius;
        public enemyNavigationComponent(GameObject targetToSet, NavMeshAgent agentToSet, float lookRadiusToSet)
        {
            this.target = targetToSet;
            this.agent = agentToSet;
            this.lookRadius = lookRadiusToSet;
        }

        public void moveEnemy()
        {
            float distance = Vector3.Distance(target.transform.position, agent.transform.position);
            if (distance <= lookRadius)
            {
                agent.SetDestination(target.transform.position);
                if (distance <= agent.stoppingDistance)
                {
                    this.attack();
                }
            }
        }
        protected virtual void attack()
        {

        }
    }

    public class shadowEnemyComponent : enemyNavigationComponent
    {
        public shadowEnemyComponent(GameObject targetToSet, NavMeshAgent agentToSet, float lookRadiusToSet) : base(targetToSet, agentToSet, lookRadiusToSet)
        {

        }
        protected override void attack()
        {
            SceneManager.LoadScene("DeathScreen");
        }
    }

    public abstract class item
    {
        protected string name;
        protected Sprite imageOfAnItem;
        public item(string nameToSet, string pathToImage)
        {
            this.name = nameToSet;
            try
            {
                this.imageOfAnItem = Resources.LoadAll<Sprite>("Sprites/" + pathToImage)[0];
            }
            catch
            {
                this.imageOfAnItem = null;
            }
        }

        public Sprite getImage()
        {
            return this.imageOfAnItem;
        }

        public string getName()
        {
            return this.name;
        }
    }

    public class basicItem : item
    {
        public basicItem(string nameToSet, string pathToImage) : base(nameToSet, pathToImage)
        {

        }
    }
    public abstract class inventory
    {
        protected List<item> items;
        public inventory()
        {
            items = new List<item>();
        }

        public List<string> getInventoryItems()
        {
            List<string> toReturn = new List<string>();
            foreach (item itemToReturn in this.items)
            {
                toReturn.Add(itemToReturn.getName());
            }
            return toReturn;
        }

        public void addItem(item itemToAdd)
        {
            items.Add(itemToAdd);
        }

    }

    public class basicInventory:inventory
    {
    }

    void Update()
    {
        
    }
}
