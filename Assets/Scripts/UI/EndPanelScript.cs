using Assets.Scripts.Assets.Scripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.UI
{
    public class EndPanelScript: MonoBehaviour
    {
        [SerializeField] private SceneAsset m_MenuScene;
        [SerializeField] private SceneAsset UIScene;
        [SerializeField] public SceneAsset m_Scene;

        public void restartGame()
        {
            Game.start_attempt();
            SceneManager.LoadScene(m_Scene.name);
            SceneManager.LoadScene(UIScene.name, LoadSceneMode.Additive);
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