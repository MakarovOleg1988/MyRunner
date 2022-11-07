using UnityEngine;

namespace MyRunner
{
    public class PlayerComponents : MonoBehaviour
    {
        [SerializeField, Range(0, 20)] public static float _speedMove; //Скорость перемещения вперед
        [SerializeField] protected float speedBust; //Увеличение скорости
        [SerializeField, Range(1, 10)] protected float JumpForce; //Сила прыжка
        [SerializeField, Range(1, 10)] protected float speedSideways; //Скорость перемещения вбок
        [SerializeField] protected float CooldownJump = 1f;
        protected float[] blockSpeed;
        public Rigidbody rbPlayer;
    }
}
