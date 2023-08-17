using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geyser : MonoBehaviour
{
    public GameObject Eruption;
    public Transform EruptionSource;

    public float cooldownTime = 5;
    private float nextFireTime = 0;

    void Update()
    {
        if (Time.time > nextFireTime)
        {
            Instantiate(Eruption, EruptionSource.position, EruptionSource.rotation);
            nextFireTime = Time.time + cooldownTime;
        }
    }
}
