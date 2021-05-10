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
        [SerializeField] private Transform m_Player;

        public void restartGame()
        {
            m_EndPanel.SetActive(false);
            m_Info.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            { 
                Application.LoadLevel(m_MenuScene.name);
                Destroy(m_Player);
            }
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