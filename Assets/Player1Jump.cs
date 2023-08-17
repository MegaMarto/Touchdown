using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Jump : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpAmount = 10;

    public float cooldownTime = 2;
    private float nextFireTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
                nextFireTime = Time.time + cooldownTime;
            }
        }
    }
}
