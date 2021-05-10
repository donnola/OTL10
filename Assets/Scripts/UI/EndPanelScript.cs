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
            Application.LoadLevel(m_MenuScene.name);
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