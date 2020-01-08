using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector3 v;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();        
    }


    private void Update()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        v = new Vector3(x, 0, z);
    }

    private void FixedUpdate()
    {
        Move(v);

    }

    private void Move(Vector3 v)
    {        
        rb.MovePosition(v);
    }
    
}
