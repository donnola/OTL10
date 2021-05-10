using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class Mark: MonoBehaviour
    {
        [SerializeField] private Text m_Text;
        private void OnEnable()
        {
            Game.GetMoney += ChangeMark;
            ChangeMark(Game.Money);
        }

        private void OnDisable()
        {
            Game.GetMoney -= ChangeMark;
        }


        void ChangeMark(int coins)
        {
            /*if (coins < 3)
            {
                m_Text.text = $"неуд({coins})";
            }

            if (coins >= 3 && coins < 5)
            {
                m_Text.text = $"уд({coins})";
            }

            if (coins >= 5 && coins < 8)
            {
                m_Text.text = $"хор({coins})";
            }
            if (coins >= 8)
            {
                m_Text.text = $"отл({coins})";
            }*/
            m_Text.text = $"отл({coins})";
        }
    }
}