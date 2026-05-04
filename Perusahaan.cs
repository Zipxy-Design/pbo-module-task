namespace PBO_ModuleTask
{
    public class Perusahaan
    {
        private List<Karyawan> daftarKaryawan = new List<Karyawan>();

        public void TambahKaryawan(Karyawan karyawan)
        {
            daftarKaryawan.Add(karyawan);
            Console.WriteLine($"Karyawan {karyawan.Nama} berhasil ditambahkan.");
        }

        public void DaftarKaryawan()
        {
            Console.WriteLine("\n===== DAFTAR KARYAWAN =====");
            foreach (var karyawan in daftarKaryawan)
            {
                karyawan.InfoKaryawan();
            }
            Console.WriteLine("===========================\n");
        }

        public List<Karyawan> GetKaryawan()
        {
            return daftarKaryawan;
        }
    }
}
