using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class StartEndOfGame: MonoBehaviour
    {
        [SerializeField] private Text m_Comment;
        [SerializeField] private Text m_Result;
        [SerializeField] private GameObject m_EndPanel;
        [SerializeField] private GameObject m_InfoPanel;
        private void OnEnable()
        {
            Game.EndGame += ActivateEndPanel;
        }

        private void OnDisable()
        {
            Game.EndGame -= ActivateEndPanel;
        }

        private void ActivateEndPanel(bool is_died)
        {
            m_EndPanel.SetActive(true);
            m_InfoPanel.SetActive(false);
            m_Result.text = $"ОТЛ({Game.Money})";
            if (is_died)
            {
                m_Comment.text = "Вы разбились!";
            }
            else
            {
                if (Game.Money < 10)
                {
                    m_Comment.text = "Отловили слишком мало.";
                }
                if (Game.Money == 10)
                {
                    m_Comment.text = "Победа!";
                }
                if (Game.Money > 10)
                {
                    m_Comment.text = "Отловили слишком много...";
                }
            }
        }
    }
}