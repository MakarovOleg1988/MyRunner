using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System;

namespace MyRunner
{
    public class ButtonManager : MonoBehaviour, IEventManager
    {
        [SerializeField] private GameObject _pausePanel;
        [SerializeField] private GameObject _ChangeLevelPanel;
        [SerializeField] private GameObject _MainMenuPanel;
        [SerializeField] private Text[] _level;
       
        private void Start()
        {
            IEventManager._onSetButton += ActionChangeLevelPanel;
            IEventManager._onSetButton += BackMainMenuPanel;
            IEventManager._onSetButton += Restart;
            IEventManager._onSetButton += SetNextLevel;
            IEventManager._onSetButton += SetPause;
            IEventManager._onSetButton += SetResumeGame;
            IEventManager._onSetButton += ExitGame;
        }

        public void ActionChangeLevelPanel()
        {
            StartCoroutine(ActionChangeLevelPanelCoroutine());
        }

        IEnumerator ActionChangeLevelPanelCoroutine()
        {
            yield return new WaitForSeconds(0.2f);
            _ChangeLevelPanel.SetActive(true);
            _MainMenuPanel.SetActive(false);
        }

        public void BackMainMenuPanel()
        {
            StartCoroutine(BackMainMenuCoroutine());
        }

        IEnumerator BackMainMenuCoroutine()
        {
            yield return new WaitForSeconds(0.2f);
            _ChangeLevelPanel.SetActive(false);
            _MainMenuPanel.SetActive(true);
        }

        public void ChangeLevel(string sceneName)
        {
            StartCoroutine(ChangeLevelCoroutine(sceneName));
        }

        IEnumerator ChangeLevelCoroutine(string sceneName)
        {
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(sceneName);
        }

        public void Restart()
        {
            StartCoroutine(RestartCoroutine());
        }

        IEnumerator RestartCoroutine()
        {
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Gamemanager._Manager._loseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        public void SetNextLevel()
        {
            StartCoroutine(NextLevelCoroutine());
        }

        IEnumerator NextLevelCoroutine()
        {
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void SetPause()
        {
            StartCoroutine(PauseCoroutine());
        }

        IEnumerator PauseCoroutine()
        {
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
            yield return new WaitForSeconds(0.2f);
            Application.Quit();
        }
    }
}
