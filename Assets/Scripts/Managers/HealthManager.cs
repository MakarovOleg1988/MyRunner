using UnityEngine;

namespace MyRunner
{
    public class HealthManager : PlayerComponents
    {

        private void Start()
        {
            Gamemanager._Manager._LivesScore.text = _livesPlayer.ToString();
            EventManager._onSetDamage += SetDamage;
        }

        public void SetDamage()
        {
            _livesPlayer--;
            Gamemanager._Manager._LivesScore.text = _livesPlayer.ToString();
        }
    }
}


