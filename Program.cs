using System.Text.Json;

HttpClient clienteHttp = new();

string url = "https://catfact.ninja/fact";

string respostaJson = await clienteHttp.GetStringAsync(url);

CatFactResponse? fatoRecebido =
JsonSerializer.Deserialize<CatFactResponse>(
respostaJson,
new JsonSerializerOptions
{
PropertyNameCaseInsensitive = true
});

Console.WriteLine("Fato sobre Gatos:");

if (fatoRecebido != null)
{
Console.WriteLine(fatoRecebido.Fact);
}