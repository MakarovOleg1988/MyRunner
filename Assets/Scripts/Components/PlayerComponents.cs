using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
    public abstract class PlayerComponents : MonoBehaviour
    {
        [SerializeField, Range(0, 20)] public static float _speedMove;
        [SerializeField] protected float speedBust;
        [SerializeField, Range(1, 10)] protected float JumpForce;
        [SerializeField, Range(1, 10)] protected float speedSideways;
        [SerializeField] protected float CooldownJump = 1f;
        protected int _livesPlayer = 4;
        public Rigidbody rbPlayer;
    }
}
