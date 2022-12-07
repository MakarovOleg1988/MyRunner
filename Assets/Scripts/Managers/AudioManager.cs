using UnityEngine;

namespace MyRunner
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private AudioSource[] _audioSourceCrash;
        [SerializeField] private AudioSource _audioSourceAirKit;
        [SerializeField] private AudioSource _audioSourceCoin;

        private void Start()
        {
            EventManager._onSetDamage += SetSoundCrach;
            EventManager._onSetAidKit += SetSoundLives;
            EventManager._onSetCoin += SetSoundCoin;
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
