using Assets.Scripts.Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class Status: MonoBehaviour
    {
        [SerializeField] private GameObject m_Text;

        public void TimeToStart()
        {
           m_Text.SetActive(true);
           
           
           m_Text.SetActive(false);
        }
    }
}