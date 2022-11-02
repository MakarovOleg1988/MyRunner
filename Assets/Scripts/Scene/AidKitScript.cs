using System;
using UnityEngine;

namespace MyRunner
{
    public class AidKitScript : AidKitComponent
    {
        private void Start()
        {
            EventManager._onSetAidKit += SetLives;
            EventManager._onSetDamageCoin += SetDamage;
        }

        void Update()
        {
            transform.Rotate(Vector3.up, _speedRotate * Time.deltaTime);
        }

        public void SetLives(int health)
        {
            if (Gamemanager._Manager._livesPlayer < 4)
            {
                Gamemanager._Manager._livesPlayer += health;
                Gamemanager._Manager._LivesScore.text = Gamemanager._Manager._livesPlayer.ToString();
                _aidKitSound.Play();
            }
        }

        public void SetDamage(int damage)
        {
            Gamemanager._Manager._livesPlayer -= damage;
            Gamemanager._Manager._LivesScore.text = Gamemanager._Manager._livesPlayer.ToString();
            
            if (Gamemanager._Manager._livesPlayer <= 0)
            {
                Gamemanager._Manager._loseMenu.SetActive(true);
                Time.timeScale = 0.001f;
            }
        }
    }
}


