using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private float speed=10f;
    private GameObject player;
    private componentManager.movementComponent playerMovementComponent;
    void Start()
    {
        player = GameObject.Find("Player");
        playerMovementComponent = new componentManager.movementComponent(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        playerMovementComponent.moveObject(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
    }
}
