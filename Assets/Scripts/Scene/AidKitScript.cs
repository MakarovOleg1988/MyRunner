using UnityEngine;

namespace MyRunner
{
    public class AidKitScript : AidKitComponent, IEventManager
    {
        PlayerHealth player = new PlayerHealth();

        private void Start()
        {
            IEventManager._onSetAidKit += SetLives;
        }

        private void Update()
        {
            RotateAidKit();
        }

        void RotateAidKit()
        {
            transform.Rotate(Vector3.up, _speedRotate * Time.deltaTime);
        }

        public void SetLives()
        {
            player.LivesPlayer++;
            Gamemanager._Manager._LivesScore.text = player.LivesPlayer.ToString();
            Debug.Log(player.LivesPlayer);
        }
    }
}


