using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SphereControll : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject BadSphere;
    private GameObject Eva;
    private componentManager.shadowEnemyComponent shadowAiControl;
    void Start()
    {
        BadSphere = this.gameObject;
        Eva = GameObject.Find("Eva");
        shadowAiControl = new componentManager.shadowEnemyComponent(Eva, BadSphere.GetComponent<NavMeshAgent>(), 50f);
    }

    // Update is called once per frame
    void Update()
    {
        shadowAiControl.moveEnemy();
    }
}