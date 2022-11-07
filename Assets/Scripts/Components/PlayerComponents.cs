using UnityEngine;

namespace MyRunner
{
    public class PlayerComponents : MonoBehaviour
    {
        [SerializeField, Range(0, 20)] public static float _speedMove; //�������� ����������� ������
        [SerializeField] protected float speedBust; //���������� ��������
        [SerializeField, Range(1, 10)] protected float JumpForce; //���� ������
        [SerializeField, Range(1, 10)] protected float speedSideways; //�������� ����������� ����
        [SerializeField] protected float CooldownJump = 1f;
        protected float[] blockSpeed;
        public Rigidbody rbPlayer;
    }
}
