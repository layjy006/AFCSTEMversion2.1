﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public interface IPlayerRepository
    {
        Player getPlayer(int id);
        IEnumerable<Player> getAllPlayers();
        Player getPlayerByName(string name);
        Player HidePlayer(Player player,bool hide);
    }
}
