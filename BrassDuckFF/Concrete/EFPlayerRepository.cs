using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrassDuckFF.Abstract;
using BrassDuckFF.Models.DB;

namespace BrassDuckFF.Concrete
{
    public class EFPlayerRepository : IPlayersRepository
    {
        private BrassDuckEntities1 context = new BrassDuckEntities1();

        public IEnumerable<Player> Players
        {
            get { return context.Players; }
        }
    }
}