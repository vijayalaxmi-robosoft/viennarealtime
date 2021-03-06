﻿using System;

namespace MundlTransit.WP8.Data.Reference.Import
{
    //
    // "STEIG_ID";"FK_LINIEN_ID";"FK_HALTESTELLEN_ID";"RICHTUNG";"REIHENFOLGE";"RBL_NUMMER";"BEREICH";"STEIG";"STEIG_WGS84_LAT";"STEIG_WGS84_LON";"STAND"
    // 
    public class CsvSteig
    {
        public int STEIG_ID { get; set; }
        public int FK_LINIEN_ID { get; set; }
        public int FK_HALTESTELLEN_ID { get; set; }
        public string RICHTUNG { get; set; }
        public int REIHENFOLGE { get; set; }
        public string RBL_NUMMER { get; set; }
        public string BEREICH { get; set; }
        public string STEIG { get; set; }
        public double STEIG_WGS84_LAT { get; set; }
        public double STEIG_WGS84_LON { get; set; }
        public string STAND { get; set; }
        
    }
}
