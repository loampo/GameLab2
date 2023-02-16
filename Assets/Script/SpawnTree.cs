using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTree : MonoBehaviour
{

    public List<GameObject> m_treeAndStoneList = new List<GameObject>();
    public List<Transform> m_spawnList = new List<Transform>();
    [SerializeField] private Transform m_treeHolder;
    public GameObject m_coin;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTreeAndStone();
    }

    private void  SpawnTreeAndStone()
    {

        var index = 7;
        for (int i=0; i < 4; i++)
        {
            int witchTreeAndStone = Random.Range(0, m_treeAndStoneList.Count);
            int witchSpawn = Random.Range(0, m_spawnList.Count);
            GameObject treesAndStone = Instantiate(m_treeAndStoneList[witchTreeAndStone], m_spawnList[witchSpawn].position, Quaternion.identity, m_treeHolder);
            m_spawnList.RemoveAt(witchSpawn);
            if (m_treeAndStoneList.Count > 0 && index < m_treeAndStoneList.Count && m_spawnList.Count > 0 && index < m_spawnList.Count)
            {
                m_treeAndStoneList.RemoveAt(0);

            }

        }
        int m_random = Random.Range(0, 100);
        if (m_random > 60)
        {
            int witchSpawn = Random.Range(0, m_spawnList.Count);
            Instantiate(m_coin, m_spawnList[witchSpawn].position, Quaternion.identity);
        }

    }
}
