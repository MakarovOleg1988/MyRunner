using UnityEngine;

namespace MyRunner
{
    public class NewInputSystem : BaseControllerPlayer
    {
        private MyRunnerController NewController;

        void Awake()
        {
            NewController = new MyRunnerController();
            NewController.Actionmap.Movement.Enable();
        }
        protected override void Start()
        {
            base.StartCoroutine(CorotiuneMovement());
            base.StartCoroutine(CorotiunespeedBust());
        }

        protected void FixedUpdate()
        {
            var direction = NewController.Actionmap.Movement.ReadValue<float>();
            if (direction == 0) return;
            transform.position += direction * _speedSideways * Time.deltaTime * transform.right;
        }

        private void OnDisable()
        {
            NewController.Actionmap.Disable();
        }

        private void OnDestroy()
        {
            NewController.Disable();
        }
    }
}
