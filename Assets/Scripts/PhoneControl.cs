using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneControl : MonoBehaviour
{
    [SerializeField] private GameObject Phone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("space") == true)
        {
            Phone.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Escape) == true)
        {
            Phone.SetActive(false);
        }
    }
}
