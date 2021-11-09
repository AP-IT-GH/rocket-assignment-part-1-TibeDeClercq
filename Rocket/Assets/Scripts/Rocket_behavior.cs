using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_behavior : MonoBehaviour
{
    public Vector2 Speed;
    public Rigidbody rb;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Speed = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Speed.x = 0;
        Speed.y = 0;
        if (Input.GetKey(KeyCode.Space))
        {
            Speed.y = 8;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Speed.x = 4;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Speed.x = -4;
        }
        if (Input.GetKey(KeyCode.R))
        {
            this.gameObject.transform.rotation = new Quaternion(0,0,0,0);
        }
    }

    void FixedUpdate()
    {
        rb.AddRelativeForce(0, Speed.y, 0);
        rb.AddRelativeTorque(0, 0, Speed.x);
    }
}
