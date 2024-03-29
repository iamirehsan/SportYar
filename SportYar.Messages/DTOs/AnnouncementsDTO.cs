﻿using SportYar.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Messages.DTOs
{
    public class AnnouncementsDTO : BaseDTO
    {

        public SportsTypes SportType { get; set; }
        public DateTime Date { get; set; }
        public string StartingTimeInPersian { get; set; }
        public string EndingTimeInPersian { get; set; }
        public int Participant { get; set; }
        public int PricePerparticipant { get; set; }
        public int GeneralPrice => Participant * PricePerparticipant;
        public string Address { get; set; }
        public string Description { get; set; }
        public bool IsExpired { get; set; }
 
    }
}
