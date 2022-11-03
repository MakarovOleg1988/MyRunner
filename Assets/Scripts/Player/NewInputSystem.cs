using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyRunner
{
    public class NewInputSystem : BaseControllerPlayer
    {
        private MyRunnerController NewController;

        protected override void Start()
        {
            base.StartCoroutine(CorotiuneMovement());
            base.StartCoroutine(CorotiunespeedBust());
        }

        void Awake()
        {
            NewController = new MyRunnerController();
            NewController.Actionmap.Jump.performed += _ => Jump();
        }

        void OnEnable()
        {
            NewController.Actionmap.Movement.Enable();
        }

        protected void Update()
        {
            base.Jump();

            var direction = NewController.Actionmap.Movement.ReadValue<float>();
            if (direction == 0) return;
            transform.position += direction * speedSideways * Time.deltaTime * transform.right;
        }
    }
}
