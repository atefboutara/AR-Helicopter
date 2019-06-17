using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Joystick MovementButton;
    public Joystick VerticalButton;
    Rigidbody rg;
    void Start()
    {
        rg = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rg.velocity = new Vector3(MovementButton.Horizontal * 1.0f, VerticalButton.Vertical * 1.0f, MovementButton.Vertical * 1.0f);
    }
}
