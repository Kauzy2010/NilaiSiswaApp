string namaSiswa;
int nilaiSiswa;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Masukkan Nama: ");
namaSiswa = Console.ReadLine();

Console.Write("Masukkan Nilai: ");
nilaiSiswa = int.Parse(Console.ReadLine());

if (nilaiSiswa >= 75)
{
    Console.WriteLine("Lulus");
}
else
{
    Console.WriteLine("Tidak Lulus");
}