using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 loc = new Vector3(0, 11, -23);
    void Start()
    {
        
    }

    void LateUpdate()
    {
        // MOVING THE CAMRA.
        transform.position = player.transform.position + loc ; 
    }
}
