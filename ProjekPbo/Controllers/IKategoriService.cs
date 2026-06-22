using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjekPbo.Controllers
{
    public interface IKategoriService
    {
        DataTable ambilkategori();
        void TambahKategori(string nama);
        void EditKategori(int id, string nama);
        void HapusKategori(int id);
    }
}
