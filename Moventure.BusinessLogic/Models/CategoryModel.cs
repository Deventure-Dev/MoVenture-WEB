﻿using Moventure.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moventure.BusinessLogic.Models
{
    public class CategoryModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime SavedAt { get; set; }
        public Users SavedBy { get; set; }

    }
}
