using UnityEngine;

namespace MyRunner
{
    public class AidKitScript : AidKitComponent
    {
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
            transform.Rotate(Vector3.up, _speedRotate * Time.deltaTime);
        }

        public void SetLives()
        {
            if (PlayerComponents._livesPlayer < 4)
            {
                _aidKitSound.Play();
                PlayerComponents._livesPlayer++;
                Gamemanager._Manager._LivesScore.text = PlayerComponents._livesPlayer.ToString();
                Debug.Log(PlayerComponents._livesPlayer);
            }
        }
    }
}


