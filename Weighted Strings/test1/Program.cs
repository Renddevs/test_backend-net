var data = weightString("abbcccd", [1,3,9,8]);
Console.WriteLine("Result => ");
foreach (var item in data.countAlphas)
{
    Console.WriteLine($@"{item.Alphabet} : {item.Count}");
}
Console.WriteLine("Bobot total : " + data.bobot);
Console.WriteLine("Queries");
foreach (var item in data.queriesResult)
{
	Console.Write($@"{item.qr} ");
}
Console.ReadLine();

WeightedStringObject weightString(string s, int[] queries) {
	HashSet<char> set = new HashSet<char>(s.ToCharArray());
	char[] cArray = set.ToArray();

	

	Dictionary<char, int> cn = new Dictionary<char, int>();
	foreach (var item in cArray)
	{
		cn[item] = 0;	
		foreach (char c in s.ToCharArray())
		{
			if (item == c)
			{
				cn[item]++;
			}
		}
	}

	int bobot = 0;

	List<CountAlpha> sumArray = new();

	int loop = 0;
	foreach (var item in cn)
    {
        for (int i = 0; i < item.Value; i++)
        {
			sumArray.Add(new CountAlpha() { Alphabet = item.Key, Count = (char.ToUpper(item.Key) - 64) * (i+1)});
			bobot += (char.ToUpper(item.Key) - 64) * i;
		}
		loop++;
    }

	List<QueriesResult> qr = new();

    for (int i = 0; i < queries.Length; i++)
    {
		string result = "No";
        foreach (var item1 in sumArray)
        {
			if (queries[i] == item1.Count) {
				result = "Yes";
			}
        }

		qr.Add(new QueriesResult()
		{
			qr = result
		});
    };


	return new WeightedStringObject()
	{
		bobot = bobot,
		countAlphas = sumArray,
		summaryAlphabet = cn,
		queriesResult = qr
	};
}

public class WeightedStringObject { 
	public int bobot { get; set; }
	public List<CountAlpha> countAlphas { get; set; }
	public Dictionary<char, int> summaryAlphabet { get; set; }
	public List<QueriesResult> queriesResult { get; set; }
}

public class CountAlpha
{ 
	public char Alphabet { get; set; }
	public int Count { get; set; }
}

public class QueriesResult { 
	public string qr { get; set; }
}