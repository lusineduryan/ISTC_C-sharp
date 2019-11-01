﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LinkedinSkill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? EndorsedCount { get; set; }
        public int LinkedinProfileId { get; set; }

        public virtual LinkedinProfile LinkedinProfile { get; set; }
    }
}
