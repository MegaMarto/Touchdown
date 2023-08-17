using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReappearingPlatform : MonoBehaviour
{
    //game object is the platform prefab
    public GameObject Platform;
    //source is the empty game object
    public Transform Source;

    public float cooldownTime = 5;
    private float nextFireTime = 0;

    void Update()
    {
        if (Time.time > nextFireTime)
        {
            Instantiate(Platform, Source.position, Source.rotation);
            nextFireTime = Time.time + cooldownTime;
        }
    }
}
