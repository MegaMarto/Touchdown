using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGlue : MonoBehaviour
{
    public GameObject Glue;
    public Transform GlueSource;
    public float GlueForce;
    

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetKey(KeyCode.P))
        {
            fire();
        }
    }

    void fire()
    {
        GameObject GlueBullet = Instantiate(Glue, GlueSource.position, GlueSource.rotation);
        Rigidbody rb = GlueBullet.GetComponent<Rigidbody>();
        rb.AddForce(GlueSource.forward * GlueForce, ForceMode.Impulse);
    }
}
