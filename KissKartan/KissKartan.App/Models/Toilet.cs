﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KissKartan.App.Models
{
    public class Toilet
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public bool IsFree { get; set; }
        public Rating Rating { get; set; }
        public DateTime LastCleaned { get; set; }

    }
}
