﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }


        public Location(int id, string name, string description, Item itemreq = null, Quest questa = null, Monster mon=null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemreq;
            QuestAvailableHere = questa;
            MonsterLivingHere = mon;
        }
    }
}
