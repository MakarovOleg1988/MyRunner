using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MyRunner
{
    public class ButtonManager : MonoBehaviour
    {
        public GameObject _pausePanel;

        [SerializeField] public bool _pauseButton;
        [SerializeField] private bool _startButton;
        [SerializeField] private bool _nextLevelButton;
        [SerializeField] private bool _restartButton;
        [SerializeField] private AudioSource _clickButton;

        public void OnMouseEnter()
        {
            if (_startButton) StartCoroutine(StartNewGameCoroutine());
            if (_restartButton) StartCoroutine(RestartCoroutine());
            if (_nextLevelButton) StartCoroutine(NextLevelCoroutine());
        }

        public void PauseGame()
        {
            if (_pauseButton)
            {
                StartCoroutine(ResumeCoroutine());
            }
            else
            {
                StartCoroutine(PauseCoroutine());
            }
        }

        IEnumerator StartNewGameCoroutine()
        {
            _clickButton.Play();
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(1);
        }

        IEnumerator RestartCoroutine()
        {
            _clickButton.Play();
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
            yield return new WaitForSeconds(0.2f);
        }
        IEnumerator NextLevelCoroutine()
        {
            _clickButton.Play();
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(2);
        }

        IEnumerator PauseCoroutine()
        {
            _clickButton.Play();
            yield return new WaitForSeconds(0.2f);
            _pausePanel.SetActive(true);
            _pauseButton = true;
            Time.timeScale = 0f;
        }
        IEnumerator ResumeCoroutine()
        {
            _clickButton.Play();
            Time.timeScale = 1f;
            _pausePanel.SetActive(false);
            _pauseButton = false;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
