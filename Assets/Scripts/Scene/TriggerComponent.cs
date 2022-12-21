using System;
using UnityEngine;

namespace MyRunner
{
    public class TriggerComponent : MonoBehaviour, IEventManager
    {
        [SerializeField] private bool _isDamage;
        [SerializeField] private bool _isCoin;
        [SerializeField] private bool _isAirKit;

        void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<OldInputSystem>() == null) return;

            if (_isDamage == true) IEventManager.SendSetDamage();
            else if(_isCoin == true) IEventManager.SendSetCoin();
            else if (_isAirKit == true) IEventManager.SendSetAidKit();
            else Gamemanager._Manager.UpdateLevel();
        }
    }
}