using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPlayer : MonoBehaviour
{
    public Joystick joystick;   
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        var rigdbody = GetComponent<Rigidbody2D>();
        rigdbody.velocity = new Vector3(joystick.Horizontal * speed, rigdbody.velocity.y, joystick.Vertical * speed);
    }

    public void Shot()
    {
        print("tiro");
    }
}
