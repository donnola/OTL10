using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //[SerializeField]
    private Vector3 m_Speed;
    [SerializeField] private float target_y;
    // Start is called before the first frame update
    void Start()
    {
        m_Speed = new Vector3(0f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > target_y)
        {
            m_Speed = new Vector3(0f, 0f, 0f);
        }
        transform.position = transform.position + m_Speed * Time.deltaTime;
    }
}
