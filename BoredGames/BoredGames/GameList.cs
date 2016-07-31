﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BoredGames
{
    class GameList
    {
        public ObservableCollection<Game> Games { get; set; }

        public GameList()
        {
            Games = new ObservableCollection<Game>() {};
        }
    }
}
