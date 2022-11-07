using UnityEngine;

namespace MyRunner
{
    public class HealthManager : AidKitComponent
    {
        public static Gamemanager _Manager;

        private void Start()
        {
            EventManager._onSetAidKit += SetLives;
            EventManager._onSetDamageCoin += SetDamage;
        }

        void Update()
        {
            RotateAidKit();
        }

        void RotateAidKit()
        {
            transform.Rotate(Vector3.up, _speedRotate * Time.deltaTime);
        }

        public void SetLives()
        {
            if (_Manager._livesPlayer < 6)
            {
                _aidKitSound.Play();
                _Manager._livesPlayer++;
                _Manager._LivesScore.text = _Manager._livesPlayer.ToString();
            }
        }

        public void SetDamage()
        {
            _Manager._livesPlayer--;
            _Manager._LivesScore.text = _Manager._livesPlayer.ToString();
        }
    }
}


