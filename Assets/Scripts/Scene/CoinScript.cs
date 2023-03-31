using UnityEngine;

namespace MyRunner
{
        public class CoinScript : CoinsComponents, IEventManager
    {
            private void Start() => IEventManager._onSetCoin += SetCoin;

            private void FixedUpdate()
            {
                transform.Rotate(Vector3.up, GetRotate * Time.deltaTime);
            }

            public void SetCoin()
            {
                _coin++;
                Gamemanager._Manager._CoinScore.text = _coin.ToString();
            }
        }
    }

