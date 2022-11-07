using System;
using UnityEngine;

namespace MyRunner
{
    public class EventManager : MonoBehaviour
    {
        public static event Action _onSetCoin;
        public static event Action _onSetAidKit;
        public static event Action _onSetDamageCoin;

        public static void SendSetCoin()
        {
            _onSetCoin?.Invoke();
        }

        public static void SendSetAidKit()
        {
            _onSetAidKit?.Invoke();
        }

        public static void SendSetDamage()
        {
            _onSetDamageCoin?.Invoke();
        }
    }
}
