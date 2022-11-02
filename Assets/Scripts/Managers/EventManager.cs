using System;
using UnityEngine;

namespace MyRunner
{
    public class EventManager : MonoBehaviour
    {
        public static Action _onSetCoin;
        public static Action<int> _onSetAidKit;
        public static Action<int> _onSetDamageCoin;

        public static void SendSetCoin()
        {
            _onSetCoin?.Invoke();
        }

        public static void SendSetAidKit(int health)
        {
            _onSetAidKit?.Invoke(health);
        }

        public static void SendSetDamage(int damage)
        {
            _onSetDamageCoin?.Invoke(damage);
        }
    }
}
