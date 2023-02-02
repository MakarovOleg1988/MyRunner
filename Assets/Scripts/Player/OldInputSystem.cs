using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyRunner
{
    public class OldInputSystem : BaseControllerPlayer
    {
        protected override void Start()
        {
            base.StartCoroutine(CorotiuneMovement());
            base.StartCoroutine(CorotiunespeedBust());
        }

        protected void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.A)) transform.position -= new Vector3(_speedSideways * Time.deltaTime, 0, 0); 
            if (Input.GetKey(KeyCode.D)) transform.position += new Vector3(_speedSideways * Time.deltaTime, 0, 0); 

            if (Input.GetKeyDown(KeyCode.Space)) Jump();
        }
    }
}
