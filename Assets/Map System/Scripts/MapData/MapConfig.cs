﻿using System;
using System.Collections.Generic;
using Encounter.Data;
using Map;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Map_System.Scripts.MapData
{
    /// <summary>
    /// 一張地圖的資料
    /// </summary>
    [Serializable]
    public class MapConfig 
    {
        [TableColumnWidth(10)]
        public string mapName;
        [LabelText("地圖層數設計")]
        [TableList(ShowIndexLabels = true)]
        [GUIColor("#FFFFAA")]
        public List<MapLayer> layers;
        
        [LabelText("地圖遭遇事件")]
        [GUIColor("#02F78E")]
        public EncounterStage encounterStage;

        [HideInInspector]
        public int GridWidth = 2;

  

    }
}