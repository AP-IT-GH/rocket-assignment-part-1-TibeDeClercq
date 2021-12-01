using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float speed = 2f;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (target != null){
            transform.RotateAround(target.transform.position, new Vector3(0,0,2), speed);
        }
    }
}
