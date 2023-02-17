using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNinfea : MonoBehaviour
{

    public List<Transform> m_spawnList = new List<Transform>();
    public GameObject m_ninfea;


    // Start is called before the first frame update
    void Start()
    {
        SpawnNinfeaRandom();
    }

    private void  SpawnNinfeaRandom()
    {
        int m_random = Random.Range(0, 100);
        if (m_random > 40)
        {
            int witchSpawn = Random.Range(0, m_spawnList.Count);
            Instantiate(m_ninfea, m_spawnList[witchSpawn].position, Quaternion.identity);
        }

    }
}
