using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueMovement : MonoBehaviour
{
    
    
    public GameObject GluePuddle;
    public Transform GlueProjectileLocation;

    

    
    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {

            Instantiate(GluePuddle, GlueProjectileLocation.position, GlueProjectileLocation.rotation);
        }
    }
}
