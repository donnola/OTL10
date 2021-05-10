using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Assets.Scripts;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    private Vector3 m_SpeedVector;
    [SerializeField] private float target_z;
    // Start is called before the first frame update
    private bool m_UpPressed, m_DownPressed, m_LeftPressed, m_RightPressed;
    private static float sq_vect = (float) Math.Sqrt(2);
    private Vector3 m_UpDirection = new Vector3(-1, 0, 0);
    private Vector3 m_RightDirection = new Vector3(0, sq_vect, -sq_vect);
    private Vector3 m_LeftDirection = new Vector3(0, -sq_vect, sq_vect);
    private Vector3 m_DownDirection = new Vector3(1, 0, 0);
    [SerializeField] private float m_MaxRotationAngle;
    [SerializeField] private float m_RotationSpeed;
    [SerializeField] private Vector3 m_StartPosition;
    [SerializeField] private Vector3 m_BaseRotation;
    
    
    //private Quaternion m_CurrentRotation;
    private Quaternion m_TargetRotation;

    void Awake()
    {
        transform.position = m_StartPosition;
        m_UpPressed = Input.GetKeyDown(KeyCode.UpArrow);
        m_DownPressed = Input.GetKeyDown(KeyCode.DownArrow);
        m_LeftPressed = Input.GetKeyDown(KeyCode.LeftArrow);
        m_RightPressed = Input.GetKeyDown(KeyCode.RightArrow);
        //m_CurrentRotation = Quaternion.Euler(m_BaseRotation);
        updateTargetRotation();
        //m_SpeedVector = transform.forward * m_Speed;
        Debug.Log(transform.forward);
        Debug.Log(transform.up);
        Debug.Log(transform.right);
        
    }

    private void Start()
    {
        
    }

    private void updateTargetRotation()
    {
        Vector3 rotation = m_BaseRotation;
        if (m_DownPressed)
        {
            rotation += m_DownDirection * m_MaxRotationAngle;
        }
        if (m_LeftPressed)
        {
            rotation += m_LeftDirection * m_MaxRotationAngle;
        }
        if (m_RightPressed)
        {
            rotation += m_RightDirection * m_MaxRotationAngle;
        }
        if (m_UpPressed)
        {
            rotation += m_UpDirection * m_MaxRotationAngle;
        }
        m_TargetRotation = Quaternion.Euler(rotation);
        //Debug.Log(m_TargetRotation);
        //Debug.Log(transform.position);
        //transform.rotation = Quaternion.Euler(rotation);
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
            //Debug.Log("Change");
            updateTargetRotation();
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
        transform.rotation = Quaternion.RotateTowards(transform.rotation, m_TargetRotation, m_RotationSpeed * Time.deltaTime);
        m_SpeedVector = transform.forward * m_Speed;
        if (transform.position.z >= target_z)
        {
            Game.finish();
            return;
        }
        transform.position = transform.position + m_SpeedVector * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            debug_get_pressed();
        }
    }
}