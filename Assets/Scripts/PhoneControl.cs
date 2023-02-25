using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneControl : MonoBehaviour
{
    [SerializeField] private GameObject Phone;
    [SerializeField] private AudioSource message;
    [SerializeField] private int message_counter = 1;
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
        if (Input.GetKey("space") == true)
        {
            Phone.SetActive(true);
            if (message_counter == 1)
            {
                message.PlayDelayed(1);
                Debug.Log(message_counter);
            }
            if (message_counter == 2)
            {
                message.clip = message2;
                message.PlayDelayed(1);
                delay = false;
            }
            if (message_counter == 3)
            {
                message.clip = message3;
                message.PlayDelayed(1);
            }
        }
        if (Input.GetKey(KeyCode.Escape) == true)
        {
            Phone.SetActive(false);
            if (message_counter == 1)
            {
                message_counter = 2;
                delay = true;
            }
            if (message_counter == 2 && delay == false)
            {
                message_counter = 3;
            }
        }
    }
}
