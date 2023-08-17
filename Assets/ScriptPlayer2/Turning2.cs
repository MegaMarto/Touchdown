using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning2 : MonoBehaviour
{

    private Rigidbody rb;

    

    
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        

        if (Input.GetKey(KeyCode.J)) _rotation = Vector3.down;
        else if (Input.GetKey(KeyCode.L)) _rotation = Vector3.up;
        else _rotation = Vector3.zero;
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }

    

}
