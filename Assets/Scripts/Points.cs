using UnityEngine;
using System.Collections;
using Assets.Scripts.Assets.Scripts;

public class Points : MonoBehaviour {
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Game.get_coin();
        }
    }
}

