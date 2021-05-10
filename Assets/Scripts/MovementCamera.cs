using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCamera : MonoBehaviour
{
    
    // Update is called once per frame
    [SerializeField] 
    private float m_distant = 0.5f;
    [SerializeField]
    public Transform m_target;

    private void Awake()
    {
        if (m_target != null) {
            transform.position = m_target.position - Vector3.forward * m_distant;
            transform.LookAt(m_target.position);
        }
    }

    // Update is called once per frame
    void Update() 
    { 
        if (m_target != null) {
            transform.position = m_target.position - Vector3.forward * m_distant ;
            transform.LookAt(m_target.position);
        }
    }
}
