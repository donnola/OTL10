using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class MenuScript : MonoBehaviour
    {
        [SerializeField] private SceneAsset m_Scene;
        public void StartGame()
        {
            SceneManager.LoadScene(m_Scene.name);
        }
    }
}