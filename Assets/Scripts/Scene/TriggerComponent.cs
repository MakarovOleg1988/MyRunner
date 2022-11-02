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

        public static Action _setCoin;

        void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<OldInputSystem>() == null) return;

            if (_isDamage == true)
            {
                EventManager.SendSetDamage(1);
                _crashSound1.Play();
            }
                else if(_isCoin == true) EventManager.SendSetCoin();
                else if (_isAirKit == true) EventManager.SendSetAidKit(1);
                else Gamemanager._Manager.UpdateLevel();
        }
    }
}