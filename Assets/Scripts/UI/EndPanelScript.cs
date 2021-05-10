using Assets.Scripts.Assets.Scripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.UI
{
    public class EndPanelScript: MonoBehaviour
    {
        [SerializeField] private GameObject m_EndPanel;
        [SerializeField] private GameObject m_Info;
        [SerializeField] private SceneAsset m_MenuScene;

        public void restartGame()
        {
            m_EndPanel.SetActive(false);
            m_Info.SetActive(true);
            Game.start_attempt();
        }

        public void Quit()
        {
            Application.Quit();
        }

        public void MainMenu()
        {
            SceneManager.LoadScene(m_MenuScene.name);
        }

    }
}