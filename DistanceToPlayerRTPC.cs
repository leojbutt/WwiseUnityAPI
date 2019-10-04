using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcDist : MonoBehaviour 
{

    public Transform target;
    public string wwiseRTPC;
    public float distToPlayer;

    //Define player's transform as target
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //When in collider, calculate distance to player
    //Use this distance in RTPC
    public void OnTriggerStay(Collider other)
    {
        distToPlayer = Mathf.Abs((Vector3.Distance(target.position, transform.position)) - 100);
        AkSoundEngine.SetRTPCValue(wwiseRTPC, distToPlayer);
    }
}
