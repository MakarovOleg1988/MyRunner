using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
        public class CoinScript : CoinsComponents
        {
        [SerializeField] public Text _CoinScore;

        private void Start() => EventManager._onSetCoin += SetCoin;

            void Update()
            {
                transform.Rotate(Vector3.up, GetRotate * Time.deltaTime);
            }

            public void SetCoin()
            {
                 _coin++;
                 _coinSound.Play();
                 Debug.Log(_coin);
            }
        }
    }

