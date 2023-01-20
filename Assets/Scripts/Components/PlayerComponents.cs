using UnityEngine;

namespace MyRunner
{
    public class PlayerComponents : MonoBehaviour
    {
        [SerializeField] public float _speedBust;
        [SerializeField] public float _speedMove;
        [SerializeField, Range(1, 10)] protected float _jumpForce;
        [SerializeField, Range(1, 10)] protected float _speedSideways;
        [SerializeField] protected float CooldownJump = 1f;
        [Space] public Rigidbody _rbPlayer;
    }

    class PlayerHealth
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
