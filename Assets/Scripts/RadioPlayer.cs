using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RadioPlayer : MonoBehaviour
{
    public AudioSource audioSource;

    private XRBaseInteractable interactable;

    //void Awake()
    //{
    //    interactable = GetComponent<XRBaseInteractable>();

    //    // Subscribe to the select entered event
    //    interactable.selectEntered.AddListener(PlayMusic);
    //}

    public void PlayMusic()
    {
            audioSource.Play();
        Debug.Log(1);
    }

    void OnDestroy()
    {
        // Clean up the listener
        //interactable.selectEntered.RemoveListener(PlayMusic);
    }
}
