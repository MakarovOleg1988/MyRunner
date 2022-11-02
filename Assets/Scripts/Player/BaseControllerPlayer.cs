using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyRunner
{
    public class BaseControllerPlayer : MonoBehaviour
    {
        [SerializeField, Range(0, 20)] public static float _speedMove; //�������� ����������� ������
        [SerializeField] protected float speedBust; //���������� ��������
        [SerializeField, Range(1, 10)] protected float JumpForce; //���� ������
        [SerializeField, Range(1, 10)] protected float speedSideways; //�������� ����������� ����
        [SerializeField]  protected float CooldownJump = 1f;
        protected float[] blockSpeed;
        public Rigidbody rbPlayer;

        protected virtual void Start()
        {
            rbPlayer = GetComponent<Rigidbody>();
            StartCoroutine(CorotiuneMovement());
            StartCoroutine(CorotiunespeedBust());
        }

        protected IEnumerator CorotiuneMovement() //�������� �������� ������
        {
            while (true)
            {
                transform.position += new Vector3(0, 0, (_speedMove + speedBust) * Time.deltaTime);
                yield return null;
            }
        }

        protected IEnumerator CorotiunespeedBust() //�������� ���������
        {
            while (true)
            {
                yield return new WaitForSeconds(20);
                speedBust = speedBust + 1f;
                yield return new WaitForSeconds(20);
            }
        }

        //������
        protected virtual void Jump() //������
        {
            if (Input.GetKeyDown(KeyCode.Space) && CooldownJump <= 0)
            {
                rbPlayer.AddForce(transform.up * JumpForce, ForceMode.Impulse);
                CooldownJump = 1f;
            }
            else CooldownJump -= Time.deltaTime;
        }

        protected void Rage()
        {
            switch (CoinsComponents.instance._coin)
            {
                case 1:
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                       _speedMove += 2;
                        CoinsComponents.instance._coin -= 1;
                        CoinsComponents.instance._CoinScore.text = CoinsComponents.instance._coin.ToString();
                    }; break;
                
                case 2:
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        JumpForce += 3;
                        CoinsComponents.instance._coin -= 2;
                        CoinsComponents.instance._CoinScore.text = CoinsComponents.instance._coin.ToString();
                    }; break;
                default: break;
            }
        }
    }
}