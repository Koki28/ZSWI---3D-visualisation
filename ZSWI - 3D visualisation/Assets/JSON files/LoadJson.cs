using System;

public class LoadJson
{
	using(StreamReader r = new StreamReader("file.json"))
	{
		string json = r.ReadToEnd();
		List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);

		dynamic array = JsonConvert.DeserializeObject(json);
		foreach(var item in array)
		{
			Console.WriteLine("{0} {1}", item.temp, item.vcc);
		}
	}
}
