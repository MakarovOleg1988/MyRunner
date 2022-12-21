using UnityEngine;

namespace MyRunner
{
    public class AudioManager : MonoBehaviour, IEventManager
    {
        [SerializeField] private AudioSource[] _audioSourceCrash;
        [SerializeField] private AudioSource _audioSourceAirKit;
        [SerializeField] private AudioSource _audioSourceCoin;
        [SerializeField] private AudioSource _clickButton;

        private void Start()
        {
            IEventManager._onSetDamage += SetSoundCrach;
            IEventManager._onSetAidKit += SetSoundLives;
            IEventManager._onSetCoin += SetSoundCoin;
            IEventManager._onSetButton += SetSoundButton;
        }

        private void SetSoundCrach()
        {
            _audioSourceCrash[Random.Range(0, 2)].Play();
        }

        private void SetSoundLives()
        {
            _audioSourceAirKit.Play();
        }

        private void SetSoundCoin()
        {
            _audioSourceCoin.Play();
        }

        private void SetSoundButton()
        {
            _clickButton.Play();
        }
    }
}
