using System;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    namespace Assets.Scripts
    {
        public static class Game
        {
            public static event Action<int> GetMoney;
            public static event Action<bool> EndGame; 
            private static int m_Money;
            public static bool is_Running;
            
            public static int Money => m_Money;
            //public static GameObject Player;
            
            public static void start_attempt()
            {
                m_Money = 0;
                GetMoney?.Invoke(m_Money);
            }

            public static void get_coin()
            {
                Debug.Log("Coin!");
                ++m_Money;
                GetMoney?.Invoke(m_Money);
            }

            public static void finish()
            {
                is_Running = false;
                EndGame?.Invoke(false);
                if (m_Money >= 10)
                {
                    
                }
                else
                {
                    Debug.Log("Уд тебе");
                }
                Debug.Log("Ваш заслуженный отл 10");
            }

            public static void die()
            {
                is_Running = false;
                EndGame?.Invoke(true);
                Debug.Log("Die!");
            }
        }
    }
}