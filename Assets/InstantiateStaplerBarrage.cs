using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateStaplerBarrage : MonoBehaviour
{

    public float cooldownTime = 15;
    private float nextFireTime = 0;

    public Rigidbody staplerBullet;
    public Transform staplerBulletSource;
    public Transform staplerBulletSource1;
    public Transform staplerBulletSource2;
    public Transform staplerBulletSource3;
    public Transform staplerBulletSource4;
    public Transform staplerBulletSource5;

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(2);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Time.time > nextFireTime)
        {

            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(staplerBullet, staplerBulletSource.position, staplerBulletSource.rotation);
                Instantiate(staplerBullet, staplerBulletSource1.position, staplerBulletSource1.rotation);
                Instantiate(staplerBullet, staplerBulletSource2.position, staplerBulletSource2.rotation);
                Instantiate(staplerBullet, staplerBulletSource3.position, staplerBulletSource3.rotation);
                Instantiate(staplerBullet, staplerBulletSource4.position, staplerBulletSource4.rotation);
                Instantiate(staplerBullet, staplerBulletSource5.position, staplerBulletSource5.rotation);
                Invoke("MoreShooting", 0.5f);
                
                nextFireTime = Time.time + cooldownTime;
            }
        }
    }
    void MoreShooting()
    {
        Instantiate(staplerBullet, staplerBulletSource.position, staplerBulletSource.rotation);
        Instantiate(staplerBullet, staplerBulletSource1.position, staplerBulletSource1.rotation);
        Instantiate(staplerBullet, staplerBulletSource2.position, staplerBulletSource2.rotation);
        Instantiate(staplerBullet, staplerBulletSource3.position, staplerBulletSource3.rotation);
        Instantiate(staplerBullet, staplerBulletSource4.position, staplerBulletSource4.rotation);
        Instantiate(staplerBullet, staplerBulletSource5.position, staplerBulletSource5.rotation);
        Invoke("MoreShooting2", 0.5f);
    }

    void MoreShooting2()
    {
        Instantiate(staplerBullet, staplerBulletSource.position, staplerBulletSource.rotation);
        Instantiate(staplerBullet, staplerBulletSource1.position, staplerBulletSource1.rotation);
        Instantiate(staplerBullet, staplerBulletSource2.position, staplerBulletSource2.rotation);
        Instantiate(staplerBullet, staplerBulletSource3.position, staplerBulletSource3.rotation);
        Instantiate(staplerBullet, staplerBulletSource4.position, staplerBulletSource4.rotation);
        Instantiate(staplerBullet, staplerBulletSource5.position, staplerBulletSource5.rotation);
    }
}
