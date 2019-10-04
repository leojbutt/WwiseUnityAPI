using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStart : MonoBehaviour
{
    public string wwiseEvent;
    public GameObject emitter;
    
    //Input audio event name and GameObject the audio will emit from
    private void Start()
    {
        AkSoundEngine.PostEvent(wwiseEvent, emitter);
    }
}
