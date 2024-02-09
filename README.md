# test_backend-net
Result test backend .Net

# Penjelasan untuk Algoritma Balanced Bracket
1. Pertama teks input diubah menjadi array
2. value pada teks di convert menjadi angka dengan kondisi sebagai berikut:
   if (c[i] == '[') {
	    arr[i] = 1;
   } else if (c[i] == ']') {
	    arr[i] = -1;
   } else if (c[i] == '{') {
	    arr[i] = 2;
   } else if (c[i] == '}') {
	   arr[i] = -2;
   } else if (c[i] == '(') {
	   arr[i] = 3;
   }
   else {
	   arr[i] = -3;
   }
3. Selanjutnya buat variable list/array untuk menampung setiap bracket yang terbuka => List<int> arrOpen;
4. Isi index pertama variable list/array sebelumnya dengan value pertama dari array teks bracket yang sudah di konversi sebelumnnya
5. loop array teks bracket yang sudah di konversi sebelumnnya, dengan menambahkan kondisi di setiap loop seperti code dibawah ini: 
for (int i = 1; i < (arr.Length); i++)
{
	if (arrOpen[arrOpen.Count - 1] + arr[i] != 0)
	{
		arrOpen.Add(arr[i]);
	}
	else {
		arrOpen.RemoveAt(arrOpen.Count - 1);
	}
}
6. Setiap perulangan akan mengecek apakah nilai pada variable index terakhir arrOpen habis dijumlahkan dengan nilai index variable yang sedang di loop, jika iya maka artinya bracket sudah ditutup dan nilai bracker dikeluarkan pada variable arrOpen, jika tidak nilai index variable yang sedang di loop akan di masukan pada list/array variable arrOpen untuk di cek pada perulangan selanjutnya.
7. Pada tahapan akhir untuk mengetahui apakah bracket seimbang atau tidak, di cek berapa jumlah index yang ada pada variable arrOpen jika 0 makan seimbang dan jika > 0 maka tidak seimbang.
if (arrOpen.Count > 0) {
	result = false;
}
   
