﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class GithubLinkedinCrossTable
    {
        public int Id { get; set; }
        public int GithubUserId { get; set; }
        public int LinkedinUserId { get; set; }
    }
}
