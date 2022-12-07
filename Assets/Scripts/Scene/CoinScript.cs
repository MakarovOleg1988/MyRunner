using UnityEngine;

namespace MyRunner
{
        public class CoinScript : CoinsComponents
        {
            private void Start() => EventManager._onSetCoin += SetCoin;

            void Update()
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

