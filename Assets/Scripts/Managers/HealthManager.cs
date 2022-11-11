using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
    public class HealthManager : PlayerComponents
    {
        public static HealthManager _healthManager;

        private void Awake()
        {
            _healthManager = this;
        }
        public void Start()
        {
            _livesPlayer = 4;
            EventManager._onSetDamage += SetDamage;
        }

        private void FixedUpdate()
        {
            LoseGame();
        }

        private void LoseGame()
        {
            if (_livesPlayer <= 0)
            {
                BaseControllerPlayer._speedMove = 0f;
                BaseControllerPlayer.speedBust = 0f;
                Gamemanager._Manager._loseMenu.SetActive(true);
            }
        }

        public void SetDamage()
        {
            _livesPlayer--;
            Gamemanager._Manager._LivesScore.text = _livesPlayer.ToString();
        }
    }
}


