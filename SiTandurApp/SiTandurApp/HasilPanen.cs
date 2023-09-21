using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiTandurApp
{
    internal class HasilPanen
    {
        private int IDPanen;
        private string namaTanaman;
        private double beratTanaman;
        private DateTime tanggalPanen;
        private string lokasiPanen;
        private decimal hargaPasar;

        public decimal HargaJual { get; set; }

        // Constructor
        public HasilPanen(int idPanen, string namaTanaman, double beratTanaman, DateTime tanggalPanen, string lokasiPanen, decimal hargaPasar)
        {
            IDPanen = idPanen;
            this.namaTanaman = namaTanaman;
            this.beratTanaman = beratTanaman;
            this.tanggalPanen = tanggalPanen;
            this.lokasiPanen = lokasiPanen;
            this.hargaPasar = hargaPasar;
        }

        public void AddHasilPanen(List<HasilPanen> hasilPanenList, HasilPanen newHasilPanen)
        {
            hasilPanenList.Add(newHasilPanen);
            Console.WriteLine("Hasil panen berhasil ditambahkan!");
        }

        public void EditHasilPanen(List<HasilPanen> hasilPanenList, int targetID, HasilPanen updatedHasilPanen)
        {
            HasilPanen existingCropField = hasilPanenList.FirstOrDefault(c => c.IDPanen == targetID);
            //penerapan LINQ FirstOrDefault untuk mengecek apakah ada elemen atau tidak

            if (existingCropField != null)
            {
                // Update fitur dari hasil panen
                existingCropField.namaTanaman = updatedHasilPanen.namaTanaman;
                existingCropField.beratTanaman = updatedHasilPanen.beratTanaman;
                existingCropField.tanggalPanen = updatedHasilPanen.tanggalPanen;
                existingCropField.lokasiPanen = updatedHasilPanen.lokasiPanen;
                existingCropField.hargaPasar = updatedHasilPanen.hargaPasar;
                existingCropField.HargaJual = updatedHasilPanen.HargaJual;

                Console.WriteLine("Hasil panen berhasil diperbarui!");
            }
            else
            {
                Console.WriteLine("Hasil panen dengan ID " + targetID + " tidak dapat ditemukan.");
            }
        }

        public void DeleteHasilPanen(List<HasilPanen> hasilPanenList, int targetID)
        {
            HasilPanen cropFieldToDelete = hasilPanenList.FirstOrDefault(c => c.IDPanen == targetID);

            if (cropFieldToDelete != null)
            {
                hasilPanenList.Remove(cropFieldToDelete);

                Console.WriteLine("Hasil panen dengan ID " + targetID + " berhasil dihapus!");
            }
            else
            {
                Console.WriteLine("Hasil panen dengan ID " + targetID + " tidak dapat ditemukan.");
            }
        }
    }
}
