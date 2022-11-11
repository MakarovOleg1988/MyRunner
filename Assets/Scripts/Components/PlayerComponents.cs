using UnityEngine;

namespace MyRunner
{
    public abstract class PlayerComponents : MonoBehaviour
    {
        [SerializeField, Range(0, 20)] public static float _speedMove;
        [SerializeField] public static float speedBust;
        [SerializeField, Range(1, 10)] protected float JumpForce;
        [SerializeField, Range(1, 10)] protected float speedSideways;
        [SerializeField] protected float CooldownJump = 1f;
        public int _livesPlayer;
        public Rigidbody rbPlayer;
        public GameObject _player;
    }
}
