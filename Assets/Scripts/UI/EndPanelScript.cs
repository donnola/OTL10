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
        [SerializeField] private SceneAsset UIScene;
        [SerializeField] public SceneAsset m_Scene;

        public void restartGame()
        {
            SceneManager.LoadScene(m_Scene.name);
            SceneManager.LoadScene(UIScene.name, LoadSceneMode.Additive);
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