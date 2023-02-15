using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObjects : MonoBehaviour
{
    public float m_minSpeedX;
    public float m_maxSpeedX;

    public void Update()
    {
        transform.position += transform.forward*(Random.Range(m_minSpeedX, m_maxSpeedX)) * Time.deltaTime;
    }


}
