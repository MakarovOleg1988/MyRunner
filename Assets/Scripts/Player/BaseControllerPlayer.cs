using System.Collections;
using UnityEngine;

namespace MyRunner
{
    public class BaseControllerPlayer : PlayerComponents
    {

        protected virtual void Start()
        {
            _rbPlayer = GetComponent<Rigidbody>();
            
            StartCoroutine(CorotiuneMovement());
            StartCoroutine(CorotiunespeedBust());
        }

        protected IEnumerator CorotiuneMovement()
        {
            var Timer = 5;
            while (Timer >= 0)
            {
                Timer--;
                yield return new WaitForSeconds(1);
            }

            _speedMove += 7;

            while (true)
            {
                transform.position += new Vector3(0, 0, (_speedMove + _speedBust) * Time.deltaTime);
                yield return null;
            }
        }

        protected IEnumerator CorotiunespeedBust()
        {
            while (true)
            {
                yield return new WaitForSeconds(20);
                _speedBust = _speedBust + 1f;
                yield return new WaitForSeconds(20);
            }
        }

        protected virtual void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && CooldownJump <= 0)
            {
                _rbPlayer.AddForce(transform.up * _jumpForce, ForceMode.Impulse);
                CooldownJump = 1f;
            }
            else CooldownJump -= Time.deltaTime;
        }
    }
}