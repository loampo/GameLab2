using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Terrain Data", menuName = "Terrain Data")]

public class TerrainData : ScriptableObject
{
    public List<GameObject> terrain; //Possibly terrain
    public int maxTerrainInSuccession; //max terrain in succession
}
