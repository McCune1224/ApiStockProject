using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
//Newtsonsoft is required
using Newtonsoft.Json;
using System.Linq.Expressions;

namespace API_Stock_Project
{
    public partial class StockApiForm : Form
    {
        public StockApiForm()
        {
            InitializeComponent();
        }
        //This is what is used to communicate with the web and get HTTP responses (aka the page we need).
        HttpClient client = new HttpClient();

        public void stockInfoCollectionButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //Just some checking for any numbers, whitespaces, or special characters
            string unwantedChars = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,1234567890 ";
            foreach (var ch in unwantedChars)
            {
                if (textBox2.Text.Contains(ch))
                {
                    errorProvider1.SetError(textBox2, "Please only use Characters! (No numbers, spaces, or special characters (!@#$...etc))");
                }
            }
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "No Symbol Inputted. Please input a Stock Symbol");

            }
            string symbol = textBox2.Text.Trim().ToUpper();
            GetStockInfo("A7DCOEYGJAAD85T5", symbol);
        }

        //function that gets the stock info with the API key we have.
        public async Task GetStockInfo(string apiKey = "demo", string symbol = "IBM")
        {
            string response = await client.GetStringAsync(
                $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={apiKey}");

            //I imported from NuGet packages Newtonsoft.Json which is SUPER helpful for converting info into JSON info we can access and manipulate
            //The JsonConvert.DeserializeObject breaks the item down into a .Net object which we can work with similar to a key/value pair
            dynamic stockJson = JsonConvert.DeserializeObject(response);

            //so I wanted to use getters and setters for these, but due to the whitespaces in the JSON's key
            //I didn't know how to declare the variables since they must match the name of the JSON object's key
            string mostRecentDate = stockJson["Meta Data"]["3. Last Refreshed"];
            string open = stockJson["Time Series (Daily)"][mostRecentDate]["1. open"];
            string high = stockJson["Time Series (Daily)"][mostRecentDate]["2. high"];
            string low = stockJson["Time Series (Daily)"][mostRecentDate]["3. low"];
            string close = stockJson["Time Series (Daily)"][mostRecentDate]["4. close"];
            string volume = stockJson["Time Series (Daily)"][mostRecentDate]["5. volume"];
           
            //print info to textbox
            outputInfoBox.AppendLine($"Most Recent Date - {mostRecentDate}");
            outputInfoBox.AppendLine($"Open Price - {open}");
            outputInfoBox.AppendLine($"Close Price - {close}");

            ;
        }

    }
    //helper function for creating new line on multi-lined textbox
    public static class WinFormsExtensions
    {
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
}
