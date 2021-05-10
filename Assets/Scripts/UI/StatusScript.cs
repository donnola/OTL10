using Assets.Scripts.Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class StatusScript: MonoBehaviour
    {
        [SerializeField] private Text m_Text;
        [SerializeField] private GameObject m_Panel;
        
        private void OnEnable()
        {
            Game.PrintTime += ChangeStatus;
        }

        private void OnDisable()
        {
            Game.PrintTime -= ChangeStatus;
        }

        private void ChangeStatus(int time)
        {
            Debug.Log(time);
            if (time >= 3)
            {
                m_Panel.SetActive(true);
                m_Text.text = "3";
            }
            else if (time <= 0)
            {
                m_Panel.SetActive(false);
            }
            else
            {
                m_Panel.SetActive(true);
                m_Text.text = (time).ToString();
            }
        }

    }
}