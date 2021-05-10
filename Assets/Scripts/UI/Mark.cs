using Assets.Scripts.Assets.Scripts;
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
            m_Text.text = $"отл({coins})";
        }
    }
}