using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneControl : MonoBehaviour
{
    [SerializeField] private GameObject Phone;
    [SerializeField] private AudioSource message;
    [SerializeField] private int messageCounter = 1;
    [SerializeField] private AudioClip message2;
    [SerializeField] private AudioClip message3;
    private bool delay = false;

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
        if (Input.GetKey("space"))
        {
            Phone.SetActive(true);
            if (messageCounter == 1)
            {
                message.PlayDelayed(1);
            }
            if (messageCounter == 2)
            {
                message.clip = message2;
                message.PlayDelayed(1);
                delay = false;
            }
            if (messageCounter == 3)
            {
                message.clip = message3;
                message.PlayDelayed(1);
            }
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Phone.SetActive(false);
            if (messageCounter == 1)
            {
                messageCounter = 2;
                delay = true;
            }
            if (messageCounter == 2 && delay == false)
            {
                messageCounter = 3;
            }
        }
    }
}
