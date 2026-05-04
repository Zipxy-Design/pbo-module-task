# PBO Module Task - Sistem Manajemen Karyawan

Project ini adalah implementasi konsep Object-Oriented Programming (OOP) dalam C# untuk sistem manajemen karyawan perusahaan.

## Struktur Kelas

### Hierarki Inheritance

```
Karyawan (Base Class)
├── Tetap
│   ├── Manager
│   └── Staff
└── Kontrak
    ├── Magang
    └── Freelancer
```

## Deskripsi Kelas

### 1. Karyawan (Base Class)
- **Properti**: Nama, Gaji
- **Method**: 
  - `Kerja()` - virtual method yang dapat di-override
  - `InfoKaryawan()` - menampilkan informasi karyawan

### 2. Tetap (extends Karyawan)
- **Properti**: Tunjangan
- **Method**: 
  - `HitungGajiTotal()` - menghitung gaji + tunjangan
  - `Kerja()` - override method dari Karyawan

### 3. Kontrak (extends Karyawan)
- **Properti**: Durasi (dalam bulan)
- **Method**: 
  - `CekKontrak()` - mengecek status kontrak
  - `Kerja()` - override method dari Karyawan

### 4. Manager (extends Tetap)
- **Method**: 
  - `Memimpin()` - method khusus manager
  - `Kerja()` - override method

### 5. Staff (extends Tetap)
- **Method**: 
  - `KerjakanTugas()` - method khusus staff
  - `Kerja()` - override method

### 6. Magang (extends Kontrak)
- **Method**: 
  - `Belajar()` - method khusus magang
  - `Kerja()` - override method

### 7. Freelancer (extends Kontrak)
- **Method**: 
  - `AmbilProyek()` - method khusus freelancer
  - `Kerja()` - override method

### 8. Perusahaan
- **Method**: 
  - `TambahKaryawan(Karyawan karyawan)` - menambah karyawan ke perusahaan
  - `DaftarKaryawan()` - menampilkan semua karyawan
  - `GetKaryawan()` - mendapatkan list karyawan

## Konsep OOP yang Diimplementasikan

1. **Encapsulation**: Properti dengan getter/setter
2. **Inheritance**: Hierarki kelas dengan pewarisan
3. **Polymorphism**: Override method `Kerja()` di setiap subclass
4. **Abstraction**: Base class Karyawan sebagai template

## Cara Menjalankan

```bash
dotnet build
dotnet run
```

## Output Program

Program akan menampilkan:
1. Proses penambahan karyawan
2. Daftar semua karyawan
3. Demonstrasi polymorphism (memanggil method Kerja() melalui referensi base class)
4. Method khusus dari setiap tipe karyawan
5. Demonstrasi polymorphism dengan type checking

## Struktur File

```
PBO-ModuleTask/
├── Karyawan.cs       # Base class
├── Tetap.cs          # Karyawan tetap
├── Kontrak.cs        # Karyawan kontrak
├── Manager.cs        # Manager (extends Tetap)
├── Staff.cs          # Staff (extends Tetap)
├── Magang.cs         # Magang (extends Kontrak)
├── Freelancer.cs     # Freelancer (extends Kontrak)
├── Perusahaan.cs     # Class untuk manage karyawan
└── Program.cs        # Main program
```

## Teknologi

- .NET 10.0
- C# Console Application

## Author

Project ini dibuat untuk memenuhi tugas modul PBO (Pemrograman Berorientasi Objek).
