using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreinScript : MonoBehaviour
{
    public GameObject m_train;
    public Transform m_spawnPoint;
    public Transform m_spawnPoint2;
    [SerializeField] private Transform m_carsHolder;
    private float m_minTime=20f;
    private float m_maxTime=30f;

    private void Start()
    {
        StartCoroutine(SpawnVehicle());

    }

    private IEnumerator SpawnVehicle()
    {
        yield return new WaitForSeconds(Random.Range(m_minTime, m_maxTime));
        int m_random = Random.Range(0, 100);
        //int witchCars = Random.Range(0, m_carsList.Count );
            if (m_random > 60)
            {
                GameObject train = Instantiate(m_train, m_spawnPoint.position, m_spawnPoint.transform.rotation, m_carsHolder);
                yield return new WaitForSeconds(10);
                Destroy(train);


            }
            else
            {
                GameObject train = Instantiate(m_train, m_spawnPoint2.position, m_spawnPoint2.transform.rotation, m_carsHolder);
                yield return new WaitForSeconds(10);
                Destroy(train);

            }
        
    }

}
