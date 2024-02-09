
var teks = "{ ( ( [ ] ) [ ] ) [ ] }";
var cek = cekBalancedBracket(teks);
Console.WriteLine("Teks : " + teks);
Console.WriteLine("Result : " + (cek ? "Yes" : "No"));
Console.ReadLine();

bool cekBalancedBracket(string teks) {
	var c = teks.Replace(" ", "").ToCharArray();

	int[] arr = new int[c.Length];

	for (int i = 0; i < c.Length; i++)
	{
		 
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
	}

	bool result = true;

	if (c.Length % 2 != 0)
	{
		result = false;
	}
	else {
		List<int> arrOpen = new List<int>();
		arrOpen.Add(arr[0]);
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
		if (arrOpen.Count > 0) {
			result = false;
		}
	}
	return result;
}