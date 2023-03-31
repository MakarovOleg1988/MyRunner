using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
    public class Gamemanager : MonoBehaviour
    {
        public static Gamemanager _Manager;
        public GameObject _loseMenu;
        public GameObject _StartMenu;
        public GameObject _winMenu;

        [SerializeField] private int finalProgress;
        private int progress = 0;
        private float _secBeforeStart = 5;
        private float step = 80f; 
        private int currentBlock = 4;
        private float lastZ = 160f;

        [SerializeField] public Transform[] blocks;
        [SerializeField] public Text _textOfProgress;
        [SerializeField] public Text _LivesScore;
        [SerializeField] public Text _CoinScore;
        [SerializeField] public Text _timerforStart;
        
        private void Awake()
        {
            _Manager = this;
        }

        public void Start()
        {
            StartCoroutine(CorotiuneTimer());
        }

        public IEnumerator CorotiuneTimer()
        {
            while (_secBeforeStart >= 0)
            {
                _timerforStart.text = Mathf.Round(_secBeforeStart).ToString();
                _secBeforeStart--;
                yield return new WaitForSeconds(1);
            }
            _StartMenu.SetActive(false);
        }

        public void UpdateLevel()
        {
            progress++;
            _textOfProgress.text = progress.ToString();

            if (progress >= finalProgress) _winMenu.SetActive(true);

            lastZ += step;
            var position = blocks[currentBlock].position;
            position.z = lastZ;
            blocks[currentBlock].position = position;

            currentBlock++;
            if (currentBlock >= blocks.Length) currentBlock = 0;
        }
    }
}


