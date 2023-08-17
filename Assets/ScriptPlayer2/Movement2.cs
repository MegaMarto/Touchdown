using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position += -transform.forward * speed * Time.deltaTime;
        }
    }

}
