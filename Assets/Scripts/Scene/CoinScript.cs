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
            if (_coin <= 100)
            {
                _coin++;
                _coinSound.Play();
                _CoinScore.text = _coin.ToString();
            }
        }
    }
}


