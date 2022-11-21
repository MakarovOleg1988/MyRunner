using System;
using UnityEngine;

namespace MyRunner
{
    public class TriggerComponent : MonoBehaviour
    {
        [SerializeField] private bool _isDamage;
        [SerializeField] private bool _isCoin;
        [SerializeField] private bool _isAirKit;
        [SerializeField] public AudioSource _crashSound1;

        void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<OldInputSystem>() == null) return;

            if (_isDamage == true) EventManager.SendSetDamage();
            else if(_isCoin == true) EventManager.SendSetCoin();
            else if (_isAirKit == true) EventManager.SendSetAidKit();
            else Gamemanager._Manager.UpdateLevel();
        }
    }
}