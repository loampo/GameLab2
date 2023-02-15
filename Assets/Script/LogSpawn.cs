using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawn : MonoBehaviour
{
    public List<GameObject> m_logsList = new List<GameObject>();
    private List<GameObject> m_logsListDestroy = new List<GameObject>();
    public Transform m_spawnPoint;
    public Transform m_spawnPoint2;
    public float m_minTime;
    public float m_maxTime;
    private float m_logs = 100;
    [SerializeField] private Transform m_logsHolder;
    private int m_maxLogsCount = 4;

    private void Start()
    {
        StartCoroutine(SpawnLogs());

    }

    private IEnumerator SpawnLogs()
    {

        int m_random = Random.Range(0, 100);
        int witchLogs = Random.Range(0, m_logsList.Count);
        for (float i = 0; i < m_logs; i++)
        {

            if (m_random > 60)
            {
                GameObject logs = Instantiate(m_logsList[witchLogs], m_spawnPoint.position, m_spawnPoint.transform.rotation, m_logsHolder);
                m_logsListDestroy.Add(logs);
                if (m_logsListDestroy.Count > m_maxLogsCount) //control from m_carsListDestroy.Count  and  m_maxCarsCount
                {
                    Destroy(m_logsListDestroy[0]);//destroy currentCars 
                    m_logsListDestroy.RemoveAt(0);
                }

            }
            else
            {
                GameObject logs = Instantiate(m_logsList[witchLogs], m_spawnPoint2.position, m_spawnPoint2.transform.rotation, m_logsHolder);
                m_logsListDestroy.Add(logs);
                if (m_logsListDestroy.Count > m_maxLogsCount) //control from m_carsListDestroy.Count  and  m_maxCarsCount
                {
                    Destroy(m_logsListDestroy[0]);//destroy currentCars 
                    m_logsListDestroy.RemoveAt(0);
                }
            }
            yield return new WaitForSeconds(Random.Range(m_minTime, m_maxTime));




        }

    }
}
