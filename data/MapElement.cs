﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeraDataExtractor.data
{
    public class MapElement
    {
        public uint Id { get; set; }
        public uint NameId { get; set; }
        public string MapId { get; set; }
        public bool IsDungeon { get; set; }
        public uint ContinentId { get; set; }
        public List<MapElement> Children { get; set; }
        public MapElement(uint id, uint nameId, string mapId, bool dng = false)
        {
            Children = new List<MapElement>();
            Id = id;
            NameId = nameId;
            MapId = mapId;
            IsDungeon = dng;
        }
    }
}