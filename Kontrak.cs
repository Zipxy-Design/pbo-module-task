namespace PBO_ModuleTask
{
    public class Kontrak : Karyawan
    {
        public int Durasi { get; set; }

        public Kontrak(string nama, double gaji, int durasi) : base(nama, gaji)
        {
            Durasi = durasi;
        }

        public string CekKontrak()
        {
            if (Durasi > 0)
                return $"Kontrak {Nama} masih aktif ({Durasi} bulan tersisa).";
            else
                return $"Kontrak {Nama} telah berakhir.";
        }

        public override void Kerja()
        {
            Console.WriteLine($"{Nama} (Karyawan Kontrak) sedang bekerja sesuai kontrak.");
        }
    }
}
