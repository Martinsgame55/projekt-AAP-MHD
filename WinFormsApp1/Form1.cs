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
        JsonNode stops = JsonNode.Parse(json);
        var data = stops.AsArray().Select(u => new
        {
            Id = u["unique_id"].ToString(),
            Nazev = u["stop_name"].ToString()
        }).ToList();

        comboBox1.DataSource = data;
    }
    private async void Form1_Load(object sender, EventArgs e)
    {
        await LoadStops();
        await LoadLines();
    }

    private void Form1_Load_1(object sender, EventArgs e)
    {
        
    }

    private void label1_Click(object sender, EventArgs e)
    {
        
    }

    private async Task LoadLines()
    {
        {

        }
        HttpClient client = new HttpClient();
        string json = await client.GetStringAsync("https://mhd.adamhojer.cz/lines");
        JsonNode lines = JsonNode.Parse(json);
        foreach (var line in lines.AsArray())
        {
            comboBox2.Items.Add(line.ToString());
        }
    }

    private async Task LoadDepartures()
        {
            if (comboBox1.SelectedValue != null && comboBox2.SelectedValue != null)
            {
                string stop = comboBox1.SelectedValue.ToString();
                string line = comboBox2.SelectedValue.ToString();
                HttpClient client = new HttpClient();
                string url = $"https://mhd.adamhojer.cz/departures?stopId={stop}&line={line}";
                string json = await client.GetStringAsync(url);
                JsonNode data = JsonNode.Parse(json);
                dataGridView1.Rows.Clear();
                foreach (var item in data.AsArray())
                {
                    dataGridView1.Rows.Add(
                        item["linka"],
                        item["smer"],
                        item["cas_odjezdu"]
                    );

                }
            }
        }
    private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
     {
         await LoadDepartures();
     }
     private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
     {
         await LoadDepartures();
     }
}