using UnityEngine;

namespace MyRunner
{
    public class AudioManager : MonoBehaviour, IEventManager
    {
        [SerializeField] private AudioSource[] _audioSourceCrash;
        [SerializeField] private AudioSource _audioSourceAirKit;
        [SerializeField] private AudioSource _audioSourceCoin;

        private void Start()
        {
            IEventManager._onSetDamage += SetSoundCrach;
            IEventManager._onSetAidKit += SetSoundLives;
            IEventManager._onSetCoin += SetSoundCoin;
        }

        void SetSoundCrach()
        {
            _audioSourceCrash[Random.Range(0, 2)].Play();
        }

        void SetSoundLives()
        {
            _audioSourceAirKit.Play();
        }

        void SetSoundCoin()
        {
            _audioSourceCoin.Play();
        }
    }
}
