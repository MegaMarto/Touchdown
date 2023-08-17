using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaplerBulletMovement : MonoBehaviour
{
    public GameObject blood;
    public Transform staplerBulletLocation;
    private float speed = 40;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(blood, staplerBulletLocation.position, staplerBulletLocation.rotation);
        }
    }
}
