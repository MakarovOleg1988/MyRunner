using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
using UnityEditor;

namespace MyRunner
{
    public class ButtonManager : MonoBehaviour
    {
        [SerializeField] public GameObject _pausePanel;
        [SerializeField] private AudioSource _clickButton;

        public void StartNewGame()
        {
            StartCoroutine(StartNewGameCoroutine());
        }

        IEnumerator StartNewGameCoroutine()
        {
            _clickButton.Play();
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void Restart()
        {
            StartCoroutine(RestartCoroutine());
        }

        IEnumerator RestartCoroutine()
        {
            _clickButton.Play();
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            BaseControllerPlayer._speedMove = 0f;
            Time.timeScale = 1f;
        }

        public void SetNextLevel()
        {
            StartCoroutine(NextLevelCoroutine());
        }

        IEnumerator NextLevelCoroutine()
        {
            _clickButton.Play();
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            BaseControllerPlayer._speedMove = 0f;
        }

        public void SetPause()
        {
            StartCoroutine(PauseCoroutine());
        }

        IEnumerator PauseCoroutine()
        {
            _clickButton.Play();
            yield return new WaitForSeconds(0.2f);
            _pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }

        public void SetResumeGame()
        {
            StartCoroutine(ResumeCoroutine());
        }

        IEnumerator ResumeCoroutine()
        {
            _clickButton.Play();
            Time.timeScale = 1f;
            _pausePanel.SetActive(false);
            yield return new WaitForSeconds(0.2f);
        }

        public void ExitGame()
        {
            StartCoroutine(ExitCoroutine());
        }

        IEnumerator ExitCoroutine()
        {
            _clickButton.Play();
            yield return new WaitForSeconds(0.2f);
            EditorApplication.isPlaying = false;
        }
    }
}
