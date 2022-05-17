// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

HttpClient client = new HttpClient();

var message = new HttpRequestMessage();
message.RequestUri = new Uri(@"https://api.openbrewerydb.org/breweries");

var response = client.Send(message);
response.EnsureSuccessStatusCode();
var responseBody = response.Content.ReadAsStringAsync().Result;

List <Brewery> myDeserializedClass = JsonConvert.DeserializeObject<List<Brewery>>(responseBody);

var sorted = myDeserializedClass.OrderByDescending(c => c.Name);

for (int i = 0; i < myDeserializedClass.Count; i++)
{
    //Console.WriteLine(myDeserializedClass[i].Name);
    Console.WriteLine(sorted.ElementAt(i).Name);
}

foreach (var item in sorted)
{
    Console.WriteLine(item.Name);
}

Console.WriteLine(sorted);

