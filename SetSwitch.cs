using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSwitch_EnterExit : MonoBehaviour 
{

    public string enterGroup;
    public string enterState;
    public string exitGroup;
    public string exitState;
    public GameObject location;

    //Input switch group and switch state information in inspector
    //Switch will set on entering and leaving a collider
    private void Start()
    {
        location = GameObject.FindWithTag("Player");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AkSoundEngine.SetSwitch(enterGroup, enterState, location);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AkSoundEngine.SetSwitch(exitGroup, exitState, location);
        }
    }
}
