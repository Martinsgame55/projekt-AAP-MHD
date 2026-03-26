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
        foreach (var stop in stops.AsArray())
        {
            comboBox1.Items.Add(stop["stop_name"].ToString());
        }
    }
    private async void Form1_Load(object sender, EventArgs e)
    {
        await LoadStops();
    }

    private void Form1_Load_1(object sender, EventArgs e)
    {
        
    }

    private void label1_Click(object sender, EventArgs e)
    {
        
            }
        }
            
        
    


    

