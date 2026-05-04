namespace PBO_ModuleTask
{
    public class Magang : Kontrak
    {
        public Magang(string nama, double gaji, int durasi) : base(nama, gaji, durasi)
        {
        }

        public void Belajar()
        {
            Console.WriteLine($"{Nama} sedang belajar dan mengembangkan skill.");
        }

        public override void Kerja()
        {
            Console.WriteLine($"{Nama} (Magang) sedang belajar sambil bekerja.");
        }
    }
}
