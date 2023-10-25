using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiTandurApp
{
    internal class Administrator : User
    {
        private string _namaAdmin;
        private string _alamatAdmin;

        public string NamaAdmin
        {
            get { return _namaAdmin; }
            set { _namaAdmin = value; }
        }

        public string AlamatAdmin
        {
            get { return _alamatAdmin; }
            set { _alamatAdmin = value;}
        }

    }
}
