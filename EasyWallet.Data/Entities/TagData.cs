﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWallet.Data.Entities
{
    public class TagData : Entity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsAutoGenerated { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public CategoryData Category { get; set; }
        public List<EntryData> Entries { get; set; }
    }
}
