using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class CBBCategory
    {
        private int _idC;
        private string _NameC;
        public int IdC { get => _idC; set => _idC = value; }
        public string NameC { get => _NameC; set => _NameC = value; }
        public override string ToString()
        {
            return NameC;
        }
    }
}
