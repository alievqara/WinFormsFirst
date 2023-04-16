using Binance.Net.Clients.SpotApi;
using Bybit.Net.Clients.SpotApi;
using CryptoExchange.Net;
using CryptoExchange.Net.CommonObjects;
using LiveChartsCore;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using TestApp.Models;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //initDataBinance
            string urlBinance = "https://api.binance.com/api/v1/exchangeInfo";
            var clientBinance = new HttpClient();
            var response = await clientBinance.GetAsync(urlBinance);
            string json = response.ToString();

      
                MessageBox.Show(json);


                //if (person == "BTCUSDT")
                //{

                //    Base BTCUSDT = new Base()
                //    {
                //        Symbol = person.Symbol,
                //        Exchange = person.Exchange

                //    };
                //    MessageBox.Show(BTCUSDT.Exchange.ToString(), BTCUSDT.Symbol.ToString());
                //}
            


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //initDataByBit
            try
            {
                string urlByBit = "https://api.bybit.com/spot/v3/public/symbols";
                var client = new HttpClient();
                var requestDate = new { key = "value" };
                string json = System.Text.Json.JsonSerializer.Serialize(requestDate);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.GetAsync(urlByBit);
                //await response.Content.ReadFromJsonAsync();

                MessageBox.Show(await response.Content.ReadAsStringAsync());




            }
            catch
            {
                MessageBox.Show("YoxduElCek");

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //initDataKucoin


        }
    }
}