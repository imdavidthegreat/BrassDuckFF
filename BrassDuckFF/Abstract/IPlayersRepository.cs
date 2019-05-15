using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrassDuckFF.Models.DB;

namespace BrassDuckFF.Abstract
{
    public interface IPlayersRepository
    {
        IEnumerable<Player> Players { get; }
    }
}
