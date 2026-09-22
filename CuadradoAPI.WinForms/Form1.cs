using System.Net.Http;
using System.Text.Json;

namespace CuadradoAPI.WinForms
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        private const string ApiUrl = "http://localhost:5000";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                string url = $"{ApiUrl}/api/Numeros";

                HttpResponseMessage response =
                    await httpClient.GetAsync(url);

                string json =
                    await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var productos =
                        JsonSerializer.Deserialize<List<Producto>>(json,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                    dataGridView1.DataSource = productos;
                }
                else
                {
                    MessageBox.Show("Error de la API: " + json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
    }
}