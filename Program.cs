using PBO_ModuleTask;

class Program
{
    static void Main(string[] args)
    {
        // a. Buat objek perusahaan
        Perusahaan perusahaan = new Perusahaan();

        // b. Buat beberapa objek karyawan
        Manager manager = new Manager("Budi Santoso", 15000000, 5000000);
        Staff staff = new Staff("Siti Rahayu", 8000000, 2000000);
        Magang magang = new Magang("Andi Pratama", 3000000, 6);
        Freelancer freelancer = new Freelancer("Dewi Lestari", 7000000, 12);

        // c. Tambahkan ke perusahaan
        Console.WriteLine("===== MENAMBAHKAN KARYAWAN =====");
        perusahaan.TambahKaryawan(manager);
        perusahaan.TambahKaryawan(staff);
        perusahaan.TambahKaryawan(magang);
        perusahaan.TambahKaryawan(freelancer);

        // d. Tampilkan semua data
        perusahaan.DaftarKaryawan();

        // e. Demonstrasikan polymorphism
        Console.WriteLine("===== DEMONSTRASI POLYMORPHISM =====");
        Console.WriteLine("Memanggil method Kerja() pada setiap karyawan melalui referensi Karyawan:");
        Console.WriteLine();
        foreach (Karyawan k in perusahaan.GetKaryawan())
        {
            k.Kerja();
        }
        Console.WriteLine();

        // f. Panggil method khusus
        Console.WriteLine("===== METHOD KHUSUS =====");

        // Method khusus Manager
        Console.WriteLine("-- Manager --");
        manager.InfoKaryawan();
        manager.Memimpin();
        Console.WriteLine($"Gaji Total (Gaji + Tunjangan): Rp{manager.HitungGajiTotal():N0}");
        Console.WriteLine();

        // Method khusus Staff
        Console.WriteLine("-- Staff --");
        staff.InfoKaryawan();
        staff.KerjakanTugas();
        Console.WriteLine($"Gaji Total (Gaji + Tunjangan): Rp{staff.HitungGajiTotal():N0}");
        Console.WriteLine();

        // Method khusus Magang
        Console.WriteLine("-- Magang --");
        magang.InfoKaryawan();
        magang.Belajar();
        Console.WriteLine(magang.CekKontrak());
        Console.WriteLine();

        // Method khusus Freelancer
        Console.WriteLine("-- Freelancer --");
        freelancer.InfoKaryawan();
        freelancer.AmbilProyek();
        Console.WriteLine(freelancer.CekKontrak());
        Console.WriteLine();

        // Demonstrasi tambahan: polymorphism dengan casting
        Console.WriteLine("===== DEMONSTRASI POLYMORPHISM DENGAN TYPE CHECKING =====");
        foreach (Karyawan k in perusahaan.GetKaryawan())
        {
            Console.WriteLine($"\n{k.Nama} bertipe: {k.GetType().Name}");
            k.Kerja();

            if (k is Tetap tetap)
            {
                Console.WriteLine($"  -> Gaji Total: Rp{tetap.HitungGajiTotal():N0}");
            }

            if (k is Kontrak kontrak)
            {
                Console.WriteLine($"  -> {kontrak.CekKontrak()}");
            }

            if (k is Manager mgr)
            {
                mgr.Memimpin();
            }
            else if (k is Staff stf)
            {
                stf.KerjakanTugas();
            }
            else if (k is Magang mag)
            {
                mag.Belajar();
            }
            else if (k is Freelancer fl)
            {
                fl.AmbilProyek();
            }
        }
    }
}
