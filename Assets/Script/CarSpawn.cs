using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public List<GameObject> m_carsList = new List<GameObject>();
    public Transform m_spawnPoint;
    public Transform m_spawnPoint2;
    public float m_minTime;
    public float m_maxTime;
    private int m_cars = 100;


    private void Start()
    {
        StartCoroutine(SpawnVehicle());
    }

    private IEnumerator SpawnVehicle()
    {
      
        int m_random = Random.Range(0, 100);
        int witchCars = Random.Range(0, m_carsList.Count);
        for(int i = 0; i < m_cars; i++)
        {
            
            if (m_random > 60)
            {
                Instantiate(m_carsList[witchCars], m_spawnPoint.position,m_spawnPoint.transform.rotation );
            }
            else
            {
                Instantiate(m_carsList[witchCars], m_spawnPoint2.position, m_spawnPoint2.transform.rotation);
            }
            yield return new WaitForSeconds(Random.Range(m_minTime, m_maxTime));
        }
            
        

    }

}
