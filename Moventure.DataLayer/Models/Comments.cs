﻿using System;
using System.Collections.Generic;

namespace Moventure.DataLayer.Models
{
    public partial class Comments
    {
        public Guid Id { get; set; }
        public string CommentMessage { get; set; }
        public int Status { get; set; }
        public DateTime SavedAt { get; set; }
        public Guid MovieId { get; set; }
        public Guid SavedBy { get; set; }

        public virtual Users SavedByNavigation { get; set; }
    }
}
