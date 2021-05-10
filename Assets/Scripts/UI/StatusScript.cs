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
            public static bool is_Running = true;
            public static bool is_Die = false;
            public static bool is_Win = false;
            public static float TimeBeforeStart;
            public static event Action<int> PrintTime; 
            
            public static int Money => m_Money;
            //public static GameObject Player;
            
            public static void start_attempt()
            {
                m_Money = 0;
                Time.timeScale = 1f;
                GetMoney?.Invoke(m_Money);
                is_Running = true;
                TimeBeforeStart = 10f;
                updateTimeBeforeStart(3f);
            }

            public static void updateTimeBeforeStart(float time)
            {
                //Debug.Log((int) Math.Floor(time));
                //Debug.Log((int) Math.Floor(TimeBeforeStart));
                if ((int) Math.Floor(time) != (int) Math.Floor(TimeBeforeStart))
                {
                    Debug.Log((int) Math.Floor(TimeBeforeStart));
                    PrintTime?.Invoke((int) Math.Floor(TimeBeforeStart));
                }
                TimeBeforeStart = time;
            }

            public static void get_coin()
            {
                Debug.Log("Coin!");
                ++m_Money;
                GetMoney?.Invoke(m_Money);
                if (m_Money == 10)
                {
                    is_Running = false;
                    EndGame?.Invoke(false);
                }
            }

            public static void finish()
            {
                is_Running = false;
                EndGame?.Invoke(false);
                Debug.Log("Конец");
            }

            public static void die()
            {
                is_Running = false;
                is_Die = true;
                EndGame?.Invoke(true);
                Debug.Log("Die!");
            }
        }
    }
}