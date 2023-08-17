using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBeam : MonoBehaviour
{
    public GameObject GlueBeam;
    public Transform GlueSource;

    public float cooldownTime = 15;
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
            if (Input.GetKey(KeyCode.Y))
            {
                Instantiate(GlueBeam, GlueSource.position, GlueSource.rotation);
                nextFireTime = Time.time + cooldownTime;
            }
        }
    }
}
