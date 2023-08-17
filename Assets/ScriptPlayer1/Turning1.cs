using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning1 : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;
    
    

    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) _rotation = Vector3.down;
        else if (Input.GetKey(KeyCode.D)) _rotation = Vector3.up;
        else _rotation = Vector3.zero;
        transform.Rotate(_rotation * _speed * Time.deltaTime);
        
        

    }
}
