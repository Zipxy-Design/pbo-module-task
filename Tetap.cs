namespace PBO_ModuleTask
{
    public class Tetap : Karyawan
    {
        public double Tunjangan { get; set; }

        public Tetap(string nama, double gaji, double tunjangan) : base(nama, gaji)
        {
            Tunjangan = tunjangan;
        }

        public override HitungGajiTotal()
        {
            return Gaji + Tunjangan;
        }

        public override void Kerja()
        {
            Console.WriteLine($"{Nama} (Karyawan Tetap) sedang bekerja dengan penuh dedikasi.");
        }
    }
}
