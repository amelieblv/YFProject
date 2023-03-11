using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenemoveConroller : MonoBehaviour
{
    [SerializeField] private string sceneToGo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider TelelportationZone)
    {
        SceneManager.LoadScene(sceneToGo);
    }
}
