using System;
using System.Collections.Generic;
using System.Linq;

namespace Tdd
{
    public class Warehouse
    {
        private List<CD> _cds;

        public Warehouse()
        {
        }

        public Warehouse(List<CD> cds)
        {
            _cds = cds;

        }

        public CD FindByTitle(string title)
        {
            return _cds.FirstOrDefault(c => c.Title == title);
        }

        public CD FindByArtist(string artist)
        {
            return _cds.FirstOrDefault(c => c.Artist == artist);
        }
    }
}