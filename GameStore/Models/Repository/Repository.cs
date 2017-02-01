﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models.Repository
{
    public class Repository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }
    }
}