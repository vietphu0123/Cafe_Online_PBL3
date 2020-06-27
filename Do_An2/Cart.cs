using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An2
{
    public class Cart
    {
        private int _id;
        private string _NameSp;
        private int _SoLuong;
        private double _Tien;


        public string NameSp { get => _NameSp; set => _NameSp = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public double Tien { get => _Tien; set => _Tien = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
