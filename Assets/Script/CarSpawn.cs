using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public List<GameObject> m_carsList = new List<GameObject>();
    private List<GameObject> m_carsListDestroy = new List<GameObject>();
    public Transform m_spawnPoint;
    public Transform m_spawnPoint2;
    public float m_minTime;
    public float m_maxTime;
    private int m_cars = 100;
    [SerializeField] private Transform m_carsHolder;
    private int m_maxCarsCount=4;

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
                GameObject cars= Instantiate(m_carsList[witchCars], m_spawnPoint.position,m_spawnPoint.transform.rotation,m_carsHolder );
                m_carsListDestroy.Add(cars);
                if (m_carsListDestroy.Count > m_maxCarsCount) //control from m_carsListDestroy.Count  and  m_maxCarsCount
                {
                    Destroy(m_carsListDestroy[0]);//destroy currentCars 
                    m_carsListDestroy.RemoveAt(0);
                }

            }
            else
            {
                GameObject cars = Instantiate(m_carsList[witchCars], m_spawnPoint2.position, m_spawnPoint2.transform.rotation, m_carsHolder);
                m_carsListDestroy.Add(cars);
                if (m_carsListDestroy.Count > m_maxCarsCount) //control from m_carsListDestroy.Count  and  m_maxCarsCount
                {
                    Destroy(m_carsListDestroy[0]);//destroy currentCars 
                    m_carsListDestroy.RemoveAt(0);
                }
            }
            yield return new WaitForSeconds(Random.Range(m_minTime, m_maxTime));
            



        }

    }

    


}
