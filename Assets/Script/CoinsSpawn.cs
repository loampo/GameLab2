using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawn : MonoBehaviour
{
    public GameObject m_coin;
    public List<Transform> m_spawnListCoin = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        SpawnCoin();
    }

    private void SpawnCoin()
    {

        //var index = 7;
        int m_random = Random.Range(0, 100);
        for (int i = 1; i <= 1; i++)
        {
            if (m_random > 60)
            {
                int witchSpawn = Random.Range(0, m_spawnListCoin.Count);
                Instantiate(m_coin, m_spawnListCoin[witchSpawn].position, Quaternion.identity);
            }
            

        }


    }
}
