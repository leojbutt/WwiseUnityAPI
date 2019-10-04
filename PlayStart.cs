using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStart : MonoBehaviour
{

    public string wwiseEvent;
    public GameObject location;
    
    //Input audio event name and GameObject the audio will emit from
    //Audio will play on Start
    private void Start()
    {
        AkSoundEngine.PostEvent(wwiseEvent, location);
    }
}
