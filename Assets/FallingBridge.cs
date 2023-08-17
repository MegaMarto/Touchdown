using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBridge : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;

    //2nd on trigger collider extended above the object to detect if someone is stepping on it
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isFalling = true;
        }
    }

    
    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime/10;
            transform.position = new Vector3(transform.position.x,
                transform.position.y - downSpeed,
                transform.position.z);
        }
    }
}
