using UnityEngine;

namespace MyRunner
{
    public class AidKitScript : PlayerComponents
    {
        public static AidKitComponent instance;

        private void Start()
        {
            EventManager._onSetAidKit += SetLives;
        }

        void Update()
        {
            RotateAidKit();
        }

        void RotateAidKit()
        {
            transform.Rotate(Vector3.up, AidKitComponent.instance._speedRotate * Time.deltaTime);
        }

        public void SetLives()
        {
            if (_livesPlayer < 4)
            {
                AidKitComponent.instance._aidKitSound.Play();
                _livesPlayer++;
                Gamemanager._Manager._LivesScore.text = _livesPlayer.ToString();
            }
        }
    }
}


