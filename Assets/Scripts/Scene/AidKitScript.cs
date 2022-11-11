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
            if (HealthManager._healthManager._livesPlayer < 4)
            {
                _aidKitSound.Play();
                HealthManager._healthManager._livesPlayer++;
                Gamemanager._Manager._LivesScore.text = HealthManager._healthManager._livesPlayer.ToString();
            }
        }
    }
}


