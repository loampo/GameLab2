using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{
    [SerializeField] private int m_minDistanceFromPlayer;
    [SerializeField] private int m_maxTerrainCount;
    [SerializeField] private List<TerrainData> terrainDatas = new List<TerrainData>();
    [SerializeField] private Transform terrainHolder;

    private List<GameObject> currentTerrains = new List<GameObject>();
    [HideInInspector] public Vector3 currentPosition = new Vector3(0, 0, 0);
    


    private void Start()
    {
        for (int i = 0; i < m_maxTerrainCount; i++)
        {
            SpawnTerrain(true, new Vector3(0,0,0));
        }
        m_maxTerrainCount = currentTerrains.Count;

    }


    public void SpawnTerrain(bool isStart, Vector3 playerPos)
    {
        if ((currentPosition.z - playerPos.z < m_minDistanceFromPlayer)||(isStart))//distancefrom player 
        {
            int whichTerrain = Random.Range(0, terrainDatas.Count); //take randomly from terrainDatas 
            int terrainInSuccession = Random.Range(1, terrainDatas[whichTerrain].maxTerrainInSuccession); //take randomly from terrainDatas the succession of it
            for (int i = 0; i < terrainInSuccession; i++)
            {
                //instantiate a new terrain pick from terrainDatas all randomly and put in a terrainHolder
                GameObject terrain = Instantiate(terrainDatas[whichTerrain].terrain[Random.Range(0, terrainDatas[whichTerrain].terrain.Count)], currentPosition, Quaternion.identity, terrainHolder);
                currentTerrains.Add(terrain); //add terrain 
                if (!isStart)
                {
                    if (currentTerrains.Count > m_maxTerrainCount) //control from currentTerrainsCount and maxTerrainCount
                    {
                        Destroy(currentTerrains[0]);//destroy currentTerrains 
                        currentTerrains.RemoveAt(0);
                    }
                }
                currentPosition.z=currentPosition.z+1; //incrementa z position for the terrains
            }
        }

        
    }

    


}

