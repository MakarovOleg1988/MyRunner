using System.Collections;
using UnityEngine;

namespace MyRunner
{
    public class BaseControllerPlayer : PlayerComponents
    {
        protected virtual void Start()
        {
            _rbPlayer = GetComponent<Rigidbody>();
        }

        protected IEnumerator CorotiuneMovement()
        {
            int Timer = 5;
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
    }
}