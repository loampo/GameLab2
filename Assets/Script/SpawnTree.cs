using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTree : MonoBehaviour
{

    public List<GameObject> m_treeAndStoneList = new List<GameObject>();
    public List<Transform> m_spawnList = new List<Transform>();
    [SerializeField] private Transform m_treeHolder;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTreeAndStone();
    }

    private void  SpawnTreeAndStone()
    {
        int witchTreeAndStone = Random.Range(0, m_treeAndStoneList.Count );
        int witchSpawn = Random.Range(0, m_spawnList.Count );
        for(int i=0; i < 5; i++)
        {
            GameObject treesAndStone = Instantiate(m_treeAndStoneList[witchTreeAndStone], m_spawnList[witchSpawn].position, Quaternion.identity, m_treeHolder);
            m_spawnList.RemoveAt(0);
            m_treeAndStoneList.RemoveAt(0);
        }
    

    }
}
