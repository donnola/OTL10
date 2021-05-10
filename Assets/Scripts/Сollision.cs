﻿using Assets.Scripts.Assets.Scripts;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    public class Сollision: MonoBehaviour
    {
        void OnTriggerEnter (Collider other)
        {
            if (other.CompareTag("Wall") || other.CompareTag("Ring"))
            {
                Game.die();
            }
            if (other.CompareTag("Coin"))
            {
                Destroy(other.gameObject);
                Game.get_coin();
            }
        }
    }
}