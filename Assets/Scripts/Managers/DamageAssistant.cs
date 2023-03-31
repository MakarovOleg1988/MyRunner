using UnityEngine;

namespace MyRunner
{
    public class DamageAssistant : MonoBehaviour, IEventManager
    {
        PlayerHealth player = new PlayerHealth();

        private void Start()
        {
            IEventManager._onSetDamage += SetDamage;
            IEventManager._onSetLoseLevel += SendSetLoseLevel;
        }
        
        public void SendSetLoseLevel()
        {
            Gamemanager._Manager._loseMenu.SetActive(true);
        }

        private void SetDamage()
        {
            player.LivesPlayer--;
           
            Gamemanager._Manager._LivesScore.text = player.LivesPlayer.ToString();
            Debug.Log(player.LivesPlayer);

            if (player.LivesPlayer <= 0) IEventManager.SendSetLoseLevel();
        }
    }
}
