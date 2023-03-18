using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenemoveConroller : MonoBehaviour
{
    [SerializeField] private string sceneToGo;
    [SerializeField] private bool allowTeleport = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.F) && allowTeleport == true)
        {
            SceneManager.LoadScene(sceneToGo);
        }
    }

    private void OnTriggerEnter(Collider TeleportationZone)
    {
        allowTeleport = true;
    }

    private void OnTriggerExit(Collider TeleportationZone)
    {
        allowTeleport = false;
    }
}
