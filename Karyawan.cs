namespace PBO_ModuleTask
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public double Gaji { get; set; }

        public Karyawan(string nama, double gaji)
        {
            Nama = nama;
            Gaji = gaji;
        }

        public virtual void Kerja()
        {
            Console.WriteLine($"{Nama} sedang bekerja.");
        }

        public void InfoKaryawan()
        {
            Console.WriteLine($"Nama: {Nama}, Gaji: Rp{Gaji:N0}");
        }
    }
}
