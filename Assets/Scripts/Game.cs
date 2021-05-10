using System;
using UnityEngine;

namespace Assets.Scripts
{
    namespace Assets.Scripts
    {
        public static class Game
        {
            public static event Action<int> GetMoney;
            private static int m_Money;
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
                Debug.Log("Finish!");
            }

            public static void die()
            {
                Debug.Log("Die!");
            }
        }
    }
}