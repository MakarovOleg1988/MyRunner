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

        [SerializeField] private AudioSource _mainmusic;

        [SerializeField] private int finalProgress; //счет для победы
        private int progress = 0; //счет прогресса
        private float _secBeforeStart = 5; //таймер запуска уровня
        private float step = 80f; //шаг переноса блока
        private int currentBlock = 4;
        private float lastZ = 160f;

        [SerializeField] public Transform[] blocks; //Массив блоков
        [SerializeField] public Text _textOfProgress; // Прогресс
        [SerializeField] public Text _LivesScore;
        [SerializeField] public Text _scoreOfWin; //Поле для вывода победного счета
        [SerializeField] public Text _timerforStart;
        [SerializeField] private Transform _player;
        
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
            BaseControllerPlayer._speedMove += 7;
        }

        public void UpdateLevel()
        {
            progress++;
            _textOfProgress.text = progress.ToString();
            _scoreOfWin.text = finalProgress.ToString();

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


