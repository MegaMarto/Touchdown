using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBullet1 : MonoBehaviour
{
    public Rigidbody staplerBullet;
    public Transform staplerBulletSource;

    public float cooldown;
    float lastShot;

    // Update is called once per frame
    void Update()
    {
        if(Time.time-lastShot<cooldown)
        {
            return;
        }
        lastShot = Time.time;
        if(Input.GetKey(KeyCode.R))
        {
            Instantiate(staplerBullet, staplerBulletSource.position, staplerBulletSource.rotation);
        }
    }
}
