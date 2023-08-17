using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem1 : MonoBehaviour
{
    public float health = 100;
    public GameObject self;
    public void TakeDamageGlue()
    {
        health -= 2;
        if (health <= 0)
            Dead();
    }

    void Dead()
    {
        ScoreScript2.scoreValue += 1;
        transform.position = new Vector3(26, 9 ,436);
        health = 100;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Glue"))
            TakeDamageGlue();

        else if (other.gameObject.CompareTag("Geyser"))
        {
            Dead();
        }
    }

    private void Update()
    {
        if (transform.position.y < -30f)
        {
            Dead();
        }
    }
}
