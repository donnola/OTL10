using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    private Vector3 m_SpeedVector;
    [SerializeField] private float target_x;
    // Start is called before the first frame update
    private bool m_UpPressed, m_DownPressed, m_LeftPressed, m_RightPressed;
    private Vector3 m_UpDirection = new Vector3(1, 0, 0);
    private Vector3 m_RightDirection = new Vector3(0, 1, 0);
    private Vector3 m_LeftDirection = new Vector3(0, -1, 0);
    private Vector3 m_DownDirection = new Vector3(-1, 0, 0);
    [SerializeField] private float m_RotationAngle;
    [SerializeField] private Vector3 m_StartPosition;
    [SerializeField] private Vector3 m_BaseRotation;

    void Awake()
    {
        transform.position = m_StartPosition;
        m_UpPressed = Input.GetKeyDown(KeyCode.UpArrow);
        m_DownPressed = Input.GetKeyDown(KeyCode.DownArrow);
        m_LeftPressed = Input.GetKeyDown(KeyCode.LeftArrow);
        m_RightPressed = Input.GetKeyDown(KeyCode.RightArrow);
        updateRotation();
        m_SpeedVector = -transform.forward * m_Speed;
        Debug.Log(transform.forward);
        Debug.Log(transform.up);
        Debug.Log(transform.right);
        
    }
 
    private void updateRotation()
    {
        Vector3 rotation = m_BaseRotation;
        if (m_DownPressed)
        {
            rotation += m_DownDirection * m_RotationAngle;
        }
        if (m_LeftPressed)
        {
            rotation += m_LeftDirection * m_RotationAngle;
        }
        if (m_RightPressed)
        {
            rotation += m_RightDirection * m_RotationAngle;
        }
        if (m_UpPressed)
        {
            rotation += m_UpDirection * m_RotationAngle;
        }
        transform.rotation = Quaternion.Euler(rotation);
    }
    
    private bool process_key(KeyCode code, ref bool flag)
    {
        bool changed = false;
        if (Input.GetKeyDown(code))
        {
            flag = true;
            changed = true;
        }
        if (Input.GetKeyUp(code))
        {
            flag = false;
            changed = true;
        }
        return changed;
    }

    private void process_keys()
    {
        bool changed = false;
        changed |= process_key(KeyCode.UpArrow, ref m_UpPressed);
        changed |= process_key(KeyCode.DownArrow, ref m_DownPressed);
        changed |= process_key(KeyCode.LeftArrow, ref m_LeftPressed);
        changed |= process_key(KeyCode.RightArrow, ref m_RightPressed);
        if (changed)
        {
            Debug.Log("Change");
            updateRotation();
            m_SpeedVector = -transform.forward * m_Speed;
        }
    }

    private void debug_get_pressed()
    {
        Debug.Log("Up press: " + m_UpPressed.ToString());
        Debug.Log("Down press: " + m_DownPressed.ToString());
        Debug.Log("Left press: " + m_LeftPressed.ToString());
        Debug.Log("Right press: " + m_RightPressed.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        process_keys();
        if (transform.position.x < target_x)
        {
            return;
        }
        transform.position = transform.position + m_SpeedVector * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            debug_get_pressed();
        }
    }
}
