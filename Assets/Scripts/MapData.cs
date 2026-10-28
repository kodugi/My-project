using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scripts/Map Data")]
public class MapData : ScriptableObject
{
    [Serializable]
    public class MapDataRow
    {
        public List<GameManager.EntityType> entityTypes = new List<GameManager.EntityType>();
    }

    public string mapName;
    public List<MapDataRow> mapDataRows = new List<MapDataRow>();
}
