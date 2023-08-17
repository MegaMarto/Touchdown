using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem2 : MonoBehaviour
{

    public float health = 100;
    public GameObject self;
    public void TakeDamageStapler()
    {
        health -= 30;
            if (health <= 0)
            Dead();
    }

    void Dead()
    {
        ScoreScript.scoreValue += 1;
        //Destroy(self);
        //transform.position = new Vector3(6, 0, 0);
        transform.position = new Vector3(-65, -3, -261);
        health = 100;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StaplerBullet"))
            TakeDamageStapler();
        else if (other.gameObject.CompareTag("Geyser"))
        {
            Dead();
        }
    }

    private void Update()
    {
        if(transform.position.y < -30f)
        {
            Dead();
        }
    }

}
