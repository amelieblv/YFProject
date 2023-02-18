using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneControl : MonoBehaviour
{
    [SerializeField] private GameObject Phone;
    [SerializeField] private AudioSource message1;
    [SerializeField] private AudioSource message2;
    [SerializeField] private AudioSource message3;
    [SerializeField] private int message_counter = 1;

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
                message1.PlayDelayed(1);
                message_counter++;
            }
            if (message_counter == 1)
            {
                message1.PlayDelayed(1);
                message_counter++;
            }
            if (message_counter == 1)
            {
                message1.PlayDelayed(1);
            }

        }
        if (Input.GetKey(KeyCode.Escape) == true)
        {
            Phone.SetActive(false);
        }
    }
}
