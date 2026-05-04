namespace PBO_ModuleTask
{
    public class Manager : Tetap
    {
        public Manager(string nama, double gaji, double tunjangan) : base(nama, gaji, tunjangan)
        {
        }

        public void Memimpin()
        {
            Console.WriteLine($"{Nama} sedang memimpin tim.");
        }

        public override void Kerja()
        {
            Console.WriteLine($"{Nama} (Manager) sedang memimpin dan mengkoordinasi pekerjaan tim.");
        }
    }
}
