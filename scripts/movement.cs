using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rigid;
    [SerializeField] float movementspeed = 5f;
    [SerializeField] float jumpforce = 6f;
    // [SerializeField] Transform groundCheck;
    // [SerializeField] LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HELLO OUTPUT");
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigid.velocity = new Vector3(rigid.velocity.x,jumpforce,rigid.velocity.z);
        }
        float a=Input.GetAxis("Horizontal");
        float b=Input.GetAxis("Vertical");

        rigid.velocity = new Vector3(movementspeed*a,rigid.velocity.y,movementspeed*b);

        // bool isgrounded()
        // {
        //     return Physics.CheckSphere(groundCheck.position, .1f, ground);
        // }

        // if(Input.GetKey("up"))
        // {
        //     rigid.velocity = new Vector3(x,y,5);
        // }
        // if(Input.GetKey("down"))
        // {
        //     rigid.velocity = new Vector3(rigid.Velocity.x,rigid.Velocity.y,-5);
        // }
        // if(Input.GetKey("left"))
        // {
        //     rigid.velocity = new Vector3(-5,rigid.Velocity.y,Velocity.z);
        // }
        // if(Input.GetKey("right"))
        // {
        //     rigid.velocity = new Vector3(5,rigid.Velocity.y,Velocity.z);
        // }

    }
}
