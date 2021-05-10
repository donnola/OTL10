using UnityEditor;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class MenuScript : MonoBehaviour
    {
        [SerializeField] private SceneAsset UIScene;
        [SerializeField] public SceneAsset m_Scene;
        public void StartGame()
        {
            SceneManager.LoadScene(m_Scene.name);
            SceneManager.LoadScene(UIScene.name, LoadSceneMode.Additive);
            Game.start_attempt();
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}