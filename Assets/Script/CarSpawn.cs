using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject m_vehicle;
    public GameObject m_vehicle2;
    public Transform m_spawnPoint;
    public Transform m_spawnPoint2;
    public float m_minTime;
    public float m_maxTime;


    private void Start()
    {
        StartCoroutine(SpawnVehicle());
    }

    private IEnumerator SpawnVehicle()
    {
            yield return new WaitForSeconds(Random.Range(m_minTime, m_maxTime));
            int m_random = Random.Range(0, 1);
            if (m_random == 1)
            {
                Instantiate(m_vehicle, m_spawnPoint.position, Quaternion.identity);
            }
            else 
            {
                Instantiate(m_vehicle2, m_spawnPoint2.position, Quaternion.identity);
            }
        

    }

}
