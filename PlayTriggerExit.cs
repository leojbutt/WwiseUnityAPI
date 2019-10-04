using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTriggerExit : MonoBehaviour 
{

    public string wwiseEvent;
    public GameObject location;
    
    //Input audio event and audio emitter GameObject
    //Audio will trigger when exiting collider
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AkSoundEngine.PostEvent(wwiseEvent, location);
        }
    }
}
