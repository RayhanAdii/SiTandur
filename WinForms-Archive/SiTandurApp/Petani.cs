using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public namespace SiTandurApp
{
    public class Petani
    {
        public string NamaPetani { get; set; }
        public string AlamatPetani { get; set; }
        public string KelompokTani { get; set; }
        public int UsiaPetani { get; set; }

        // Constructor untuk class Petani
        public Petani(string namaPetani, string alamatPetani, string kelompokTani, int usiaPetani)
        {
            NamaPetani = namaPetani;
            AlamatPetani = alamatPetani;
            KelompokTani = kelompokTani;
            UsiaPetani = usiaPetani;
        }

        // List untuk menyimpan data petani
        private static List<Petani> database = new List<Petani>();

        // Method untuk menambahkan petani
        public static void AddPetani()
        {
            database.Add(this);
        }

        // Method untuk mengedit informasi petani
        public static void EditPetani(string namaPetani, string alamatPetani, string kelompokTani, int usiaPetani)
        {
            // Temukan petani berdasarkan nama atau id
            Petani petaniToUpdate = database.Find(p => p.NamaPetani == namaPetani);

            if (petaniToUpdate != null)
            {
                // Perbarui informasi petani
                petaniToUpdate.NamaPetani = namaPetani;
                petaniToUpdate.AlamatPetani = alamatPetani;
                petaniToUpdate.KelompokTani = kelompokTani;
                petaniToUpdate.UsiaPetani = usiaPetani;
            }
        }

        // Method untuk menghapus petani
        public static void DeletePetani(Petani petani)
        {
            database.Remove(petani);
        }

        // Method untuk membaca data petani
        public static List<Petani> GetPetaniList()
        {
            return database;
        }
    }
}