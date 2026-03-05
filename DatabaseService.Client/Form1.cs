namespace DatabaseService.Client
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:7002/api/Database/")
            };
        }
        private async void btnConnect_Click_1(object sender, EventArgs e)
        {
            await SendRequestAsync("connect", HttpMethod.Post);
        }
        private async void btnGetVersion_Click_1(object sender, EventArgs e)
        {
            await SendRequestAsync("version", HttpMethod.Get);
        }

        private async void btnDisconnect_Click_1(object sender, EventArgs e)
        {
            await SendRequestAsync("disconnect", HttpMethod.Post);
        }

        private async Task SendRequestAsync(string endpoint, HttpMethod method)
        {
            try
            {
                HttpResponseMessage response;

                if (method == HttpMethod.Get)
                    response = await _httpClient.GetAsync(endpoint);
                else
                    response = await _httpClient.PostAsync(endpoint, null);

                var content = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                    SetResult($"Success: {content}");
                else
                    SetResult($"Error: {content}");
            }
            catch (Exception ex)
            {
                SetResult($"Exception: {ex.Message}");
            }
        }

        private void SetResult(string text)
        {
            if (txtResult.InvokeRequired)
            {
                txtResult.Invoke(new Action(() => txtResult.Text = text));
            }
            else
            {
                txtResult.Text = text;
            }
        }
    }
}