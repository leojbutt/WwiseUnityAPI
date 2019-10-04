using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRFootsteps : MonoBehaviour {

    public float timer;
    CharacterController player;

    //Define player and set timer to 0
    private void Start()
    {
        player = gameObject.GetComponent<CharacterController>();
        timer = 0;
    }

    //If player is grounded and moving timer will run
    //Every 0.5 seconds footstep sound plays and timer resets
    void Update ()
    {
		    if (player.isGrounded == true && player.velocity.magnitude >= 0.1)
        {
            timer = timer += Time.deltaTime;
        }

        if (timer >= 0.5)
        {
            AkSoundEngine.PostEvent("Play_Footsteps", gameObject);
            timer = 0;
        }
  	}
}
