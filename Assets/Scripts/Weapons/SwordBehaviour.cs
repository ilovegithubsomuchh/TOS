using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBehaviour : Sword
{
    protected override void Start()
    {
        base.Start();

        transform.position = new Vector3(transform.position.x + 2, transform.position.y, 0);
    }


    private void LateUpdate()
    {
        Movement();
    }

    protected override void Movement()
    {
        transform.RotateAround(transform.parent.position, transform.parent.forward, 70f * Time.deltaTime);
    }
}