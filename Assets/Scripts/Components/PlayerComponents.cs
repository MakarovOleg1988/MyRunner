using UnityEngine;

namespace MyRunner
{
    public class PlayerComponents : MonoBehaviour
    {
        [SerializeField] protected float _speedBust;
        [SerializeField] protected float _speedMove;
        [SerializeField, Range(1, 10)] protected float _speedSideways;
        protected Rigidbody _rbPlayer;
    }

    public class PlayerHealth
    {
        private int _livesPlayer = 4;

        public int LivesPlayer
        {
            get
            { return _livesPlayer; }
            set
            { _livesPlayer = value; }
        }
    }
}
