﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class LinkedinEducation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public int LinkedinProfileId { get; set; }
        public string Title { get; set; }

        public virtual LinkedinProfile LinkedinProfile { get; set; }
    }
}
