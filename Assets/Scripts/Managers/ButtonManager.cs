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

        public void ActionChangeLevelPanel()
        {
            IEventManager.SendSetButton();
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
            IEventManager.SendSetButton();
            StartCoroutine(BackMainMenuCoroutine());
        }

        IEnumerator BackMainMenuCoroutine()
        {
            yield return new WaitForSeconds(0.2f);
            _ChangeLevelPanel.SetActive(false);
            _MainMenuPanel.SetActive(true);
        }

        public void BackToMainScene()
        {
            IEventManager.SendSetButton();
            StartCoroutine(BackToMainSceneCoroutine());
        }

        IEnumerator BackToMainSceneCoroutine()
        {
            Time.timeScale = 1f;
            yield return new WaitForSeconds(0.02f);
            SceneManager.LoadScene("Menu");
        }

        public void ChangeLevel(string sceneName)
        {
            IEventManager.SendSetButton();
            StartCoroutine(ChangeLevelCoroutine(sceneName));
        }

        IEnumerator ChangeLevelCoroutine(string sceneName)
        {
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(sceneName);
        }

        public void Restart()
        {
            IEventManager.SendSetButton();
            StartCoroutine(RestartCoroutine());
        }

        IEnumerator RestartCoroutine()
        {
            Time.timeScale = 1f;
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Gamemanager._Manager._loseMenu.SetActive(false);
        }

        public void SetNextLevel()
        {
            IEventManager.SendSetButton();
            StartCoroutine(NextLevelCoroutine());
        }

        IEnumerator NextLevelCoroutine()
        {
            yield return new WaitForSeconds(0.2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void SetPause()
        {
            IEventManager.SendSetButton();
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
            IEventManager.SendSetButton();
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
            IEventManager.SendSetButton();
            StartCoroutine(ExitCoroutine());
        }
         
        IEnumerator ExitCoroutine()
        {
            yield return new WaitForSeconds(0.2f);
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE_WIN && !UNITY_EDITOR
            Application.Quit();
#endif
        }
    }
}
