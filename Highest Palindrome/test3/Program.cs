

var teks = "932239";
int result = _palindrome(teks, 0, teks.Length - 1, 2);

Console.WriteLine($"Dari bentuk palindrom yang diperoleh maka highest palindrome-nya adalah : {result}");

int _palindrome(string teks, int left, int right, int k)
{
	if (left >= right)
		return k < 0 ? -1 : int.Parse(teks);

	if (teks[left] != teks[right])
	{
		Char? mx = null;
		var test = teks[left];
		var test2 = teks[right];
		if (teks[left] < teks[right])
		{
			mx = teks[left];
		}
		else
		{
			mx = teks[right];
		}
		teks = teks.Substring(0, left) + mx + teks.Substring(left + 1, right - left - 1) + mx + teks.Substring(right + 1);
		k--;
	}

	return _palindrome(teks, left + 1, right - 1, k);
}