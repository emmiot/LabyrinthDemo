using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{

    AudioSource winAudio;
    Text winText;

    // Start is called before the first frame update
    void Start()
    {
        winText = FindObjectOfType<Text>();
        winText.enabled = false;
        winAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGERED");
        winText.enabled = true;
        winAudio.Play(0);
    }

}
