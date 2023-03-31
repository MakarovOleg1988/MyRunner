using System;

namespace MyRunner
{
    public interface IEventManager
    {
        public static event Action _onSetCoin;
        public static event Action _onSetAidKit;
        public static event Action _onSetDamage;
        public static event Action _onSetLoseLevel;
        public static event Action _onSetButton;

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
            _onSetDamage?.Invoke();
        }

        public static void SendSetLoseLevel()
        {
            _onSetLoseLevel?.Invoke();
        }

        public static void SendSetButton()
        {
            _onSetButton?.Invoke();
        }
    }
}
