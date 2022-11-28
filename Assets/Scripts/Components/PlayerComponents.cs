using UnityEngine;

namespace MyRunner
{
    public class PlayerComponents : MonoBehaviour
    {
        [SerializeField, Range(0, 20)] public static float _speedMove;
        [SerializeField] public static float _speedBust;
        [SerializeField, Range(1, 10)] protected float _jumpForce;
        [SerializeField, Range(1, 10)] protected float _speedSideways;
        [SerializeField] public static int _livesPlayer = 4;
        [SerializeField] protected float CooldownJump = 1f;
        public Rigidbody _rbPlayer;
        public GameObject _player;
    }
}
