﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.ViewModels
{
    public class Y_EngineRoomScoreViewModel
    {
        public int ID { get; set; }
        public int EngineRoomID { get; set; }
        public double EngineRoomScore { get; set; }
        public int ScoreLevel { get; set; }
        public DateTime StartTime { get; set; }
    }
}
