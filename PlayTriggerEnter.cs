using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_TriggerEnter : MonoBehaviour
{

    public string wwiseEvent;
    public GameObject location;
    
    //Input audio event name and GameObject to emit from
    //Audio will play on trigger
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AkSoundEngine.PostEvent(wwiseEvent, location);
        }
    }
}
