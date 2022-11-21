using System.Collections;
using UnityEngine;

namespace MyRunner
{
    public class BaseControllerPlayer : PlayerComponents
    {
        protected virtual void Start()
        {
            rbPlayer = GetComponent<Rigidbody>();
            
            StartCoroutine(CorotiuneMovement());
            StartCoroutine(CorotiunespeedBust());
        }

        protected IEnumerator CorotiuneMovement() //Курутина движения вперед
        {
            while (true)
            {
                transform.position += new Vector3(0, 0, (_speedMove + speedBust) * Time.deltaTime);
                yield return null;
            }
        }

        protected IEnumerator CorotiunespeedBust() //Курутина ускорения
        {
            while (true)
            {
                yield return new WaitForSeconds(20);
                speedBust = speedBust + 1f;
                yield return new WaitForSeconds(20);
            }
        }

        protected virtual void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && CooldownJump <= 0)
            {
                rbPlayer.AddForce(transform.up * JumpForce, ForceMode.Impulse);
                CooldownJump = 1f;
            }
            else CooldownJump -= Time.deltaTime;
        }
    }
}