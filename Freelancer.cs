namespace PBO_ModuleTask
{
    public class Freelancer : Kontrak
    {
        public Freelancer(string nama, double gaji, int durasi) : base(nama, gaji, durasi)
        {
        }

        public void AmbilProyek()
        {
            Console.WriteLine($"{Nama} sedang mengambil proyek baru.");
        }

        public override void Kerja()
        {
            Console.WriteLine($"{Nama} (Freelancer) sedang mengerjakan proyek secara mandiri.");
        }
    }
}
