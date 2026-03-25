using System.Net.Http;
using System.Text.Json.Nodes;
namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private async Task LoadStops()
    {
        HttpClient client = new HttpClient();
        string json = await client.GetStringAsync("https://mhd.adamhojer.cz/stops");
        JsonNode data = JsonNode.Parse(json);
        var list = data.AsArray().Select(s => new
        {
            Id = s["unique_id"].ToString(),
            Nazev = s["stop_name"].ToString()
        }).ToList();
        cbStops.DataSource = list;
        cbStops.DisplayMember = "Nazev";
    }
}
