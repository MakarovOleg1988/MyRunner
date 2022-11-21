using UnityEngine;

namespace MyRunner
{
    public class DamageAssistant : MonoBehaviour
    {
        private void Start()
        {
            EventManager._onSetDamage += SetDamage;
        }

        public void FixedUpdate()
        {
            LoseGame();
        }
        
        public void LoseGame()
        {
            if (PlayerComponents._livesPlayer <= 0)
            {
                PlayerComponents._speedMove = 0f;
                PlayerComponents.speedBust = 0f;
                Gamemanager._Manager._loseMenu.SetActive(true);
            }
        }

        private void SetDamage()
        {
            PlayerComponents._livesPlayer--;
           
            Gamemanager._Manager._LivesScore.text = PlayerComponents._livesPlayer.ToString();
            Debug.Log(PlayerComponents._livesPlayer);
        }
    }
}
