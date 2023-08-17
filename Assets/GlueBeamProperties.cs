using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueBeamProperties : MonoBehaviour
{
    float scaleSpeed = 20;
    float travelSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(2, transform.localScale.y + scaleSpeed * Time.deltaTime, 2);
        transform.Translate(Vector3.up * travelSpeed * Time.deltaTime);

        if (transform.localScale.y > 50)
        {
            Destroy(gameObject);
        }
    }

}
