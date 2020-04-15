using System;
namespace ResponsiPemograman2898
{
	class Karyawan
	{
		public Karyawan(string name, int no, int nik, int gaji)
		{
			Nama = name;
			No = no;
			NIK = nik;
			Gaji = gaji;
		}
	    public string Nama { get; set; }
		public int No { get; set; }
		public int NIK { get; set; }
		public void gaji()
		{
			Console.WriteLine("Karyawan has name : {0} no : {1} nik : {2} gaji {3}", Nama, No, NIK, Gaji);
		}
		public void gajinaik()
		{
			Console.WriteLine("Karyawan has name : {1} nik : {2} gaji {3}", Nama, No, NIK, Gaji + (Gaji * 10 / 100));
		}
	}
}
		