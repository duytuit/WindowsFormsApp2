using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       private readonly string Client_Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhcHBfaWQiOiJjOGQxMjhjMS0wODU4LTQwNGQtODczYi1jZGY0OGQ3NTY5YmYiLCJlbmRwb2ludHMiOlsibGlzdF9jaXRpZXMiLCJsaXN0X21ldGEiLCJsaXN0X3JvbGVzIiwiY3JlYXRlX3JvbGVzIiwic2hvd19yb2xlcyIsInVwZGF0ZV9yb2xlcyIsImRlbGV0ZV9yb2xlcyIsInVwbG9hZF9tZWRpYSIsInVwbG9hZF9tdWx0aV9tZWRpYSIsInNob3dfbWVkaWEiLCJkZWxldGVfbWVkaWEiLCJsaXN0X3Byb2ZpbGVzIiwidXBkYXRlX3Byb2ZpbGVzIiwic2hvd19wcm9maWxlcyIsImxpc3RfcmVzb3VyY2VzIiwiY3JlYXRlX3Jlc291cmNlIiwibGlzdF9yZXNvdXJjZV9pdGVtIiwiY3JlYXRlX3Jlc291cmNlX2l0ZW0iLCJ1cGRhdGVfcmVzb3VyY2VfaXRlbSIsImRlbGV0ZV9yZXNvdXJjZV9pdGVtIiwic2hvd19yZXNvdXJjZV9pdGVtIiwic2hvd19yZXNvdXJjZSIsInVwZGF0ZV9yZXNvdXJjZSIsImRlbGV0ZV9yZXNvdXJjZSIsImJvb2tfZXZlbnQiLCJsaXN0X3Jlc291cmNlX2NhdGVnb3J5IiwiY3JlYXRlX3Jlc291cmNlX2NhdGVnb3J5Iiwic2hvd19yZXNvdXJjZV9jYXRlZ29yeSIsInVwZGF0ZV9yZXNvdXJjZV9jYXRlZ29yeSIsImRlbGV0ZV9yZXNvdXJjZV9jYXRlZ29yeSIsImxpc3Rfcm9vbXNfYXZhaWxhYmxlIiwic2hvd19ib29raW5ncyIsImxpc3RfZGlzdHJpY3RzIiwibGlzdF9ib29raW5ncyIsImJvb2tpbmdzX2NvbnZlcnQiLCJjYW5jZWxfYm9va2luZyIsImxpc3RfY29udHJhY3QiLCJsaXN0X2NvbnRyYWN0X2l0ZW1zIiwic2hvd19jb250cmFjdHMiLCJzaG93X2NvbnRyYWN0X2l0ZW1zIiwic2hvd19pdGVtX2NvbnRyYWN0cyIsInN0b3JlX2NvbnRyYWN0X2l0ZW1zIiwiY3JlYXRlX3BheW1lbnRzIiwiZ2V0X3BheW1lbnRfY29udHJhY3QiLCJzaG93X3BheW1lbnRzIiwidXBkYXRlX2Jvb2tpbmdzIiwibGlzdF9ib29raW5nc19ob3N0IiwiYm9va2luZ19kaXJlY3QiLCJhdXRoX2xvZ2luIiwiYXV0aF9yZWdpc3RlciJdLCJhZG1pbl9pZCI6MjUsImVuZF90aW1lIjoxNTgzOTIzOTc2fQ.aUWTo7aCK9qdYvLl-W-P8L-a0mg_mxOxT725WplCKCgyY5OFc28voYsBGrI4UZ3retoP_SEbyOzps4e-0IbqpbH7zFZVXM9sXImYai6uGNwa3KcfMULXuYjudLc8fTW9Q45X0h2adA6VCSBBQwgvJQZwaO-ak-xGz-Ss2ldcigs";
       private readonly string privateToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJwcm9maWxlX2lkIjoyOCwibGlzdF9lbmRwb2ludCI6W10sInJvbGVfaWQiOjAsImFwcF9pZCI6ImM4ZDEyOGMxLTA4NTgtNDA0ZC04NzNiLWNkZjQ4ZDc1NjliZiIsImVuZF90aW1lIjoxNTg1MTQ3Nzg3fQ.wwM8VEm7-5fTLYbJvSH2Sins4R7uR0KaQ6jjrjE5DIuFOwks2Xticlf6LyBtnYaH7bEDcYo5j7dSO4aEMqwJ0HhFtMcoMkoASksKRdqPrUwAGEVmccHUiLfMuJTDF5EBj-KjglhtVqgGewSwvijvS6aEZKkwxfui9Q65E-O27BrdSSWKLgqA1UnspNMtEdzzBVwJvX98Xs8u4Nyw3-QL1Ee54uoeQf59k6xuKNpcpqtewKlc6_5HIeHVK3PL54Z_8iofIrBaQ1_oZKJwtm0WHH-dfqk2e7jAvW5vwNzdpnqjUs4XwXxHvlnL0VFEvnRWrtGdMJP6Gr1k-TL764tjZA";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private async Task<BaseDataResponse<LoginResponse>> login()
        {
           
            BaseDataResponse<LoginResponse> loginResponse = null;
            var parameters = new Dictionary<string, string> {
                { "username", "demogateway@gmail.com" },
                { "password", "123456789" }
            };
            var encodedContent = new FormUrlEncodedContent(parameters);
            HttpClient _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("client", Client_Token);
            var response = _client.PostAsync("http://devapi.dxmb.vn/api/v1/login", encodedContent).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                loginResponse = JsonConvert.DeserializeObject<BaseDataResponse<LoginResponse>>(result);
            }
            return loginResponse;
        }
        public class BaseApiResponse
        {
            [JsonProperty(PropertyName = "success")]
            public string success { get; set; }

            [JsonProperty(PropertyName = "messages")]
            public List<string> messages { get; set; }
        }

        public class BaseDataResponse<T> : BaseApiResponse
        {
            public T data { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // var rs = login();
          //var rs1 =Profile();
            Resource resource = new Resource()
            {
                name= "Homestay đi bộ",
                owner_id=42,
                contact_id=2,
                city_id=1,
                address= "sadasdasdasdsa",
                base_price= 123123213,
                weekend_price= 123123213,
                resource_category_id=19,
                slot=2,
                total_pic=9,
                thumbnail_url= "http://api.booking.localstorage/upload/resources/2020/01/08/e32da5ee4937501510d71052e2802bf21578489605.jpg",
                thumbnail_type=2,
                latitude= "345646",
                longitude= "34564676"
            };
          // var rs2 = AddResource(resource);
            var rs3 = GetResource();
        }
        public async Task<BaseApiResponse> Profile()
        {
           
            BaseDataResponse<Profile> registerResponse = null;
            HttpClient _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("client", Client_Token);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", privateToken);
            var response = _client.PostAsync("http://devapi.dxmb.vn/api/v1/get-profile", null).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                registerResponse = JsonConvert.DeserializeObject<BaseDataResponse<Profile>>(result);
            }
            return registerResponse;
        }
        private async Task<BaseDataResponse<dynamic>> AddResource(Resource resource)
        {

            BaseDataResponse<dynamic> ResourceResponse = null;
            var serializedProduct = JsonConvert.SerializeObject(resource);
            var myAwesomeDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedProduct);
            var encodedContent = new FormUrlEncodedContent(myAwesomeDictionary);
            var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
            HttpClient _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("client", Client_Token);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", privateToken);
            var response = _client.PostAsync("http://devapi.dxmb.vn/api/v1/resources", encodedContent).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                ResourceResponse = JsonConvert.DeserializeObject<BaseDataResponse<dynamic>>(result);
            }
            return ResourceResponse;
        }
        private async Task<BaseDataResponse<dynamic>> GetResource()
        {

            BaseDataResponse<dynamic> ResourceResponse = null;
           
            HttpClient _client = new HttpClient();
            //_client.BaseAddress = new Uri("http://devapi.dxmb.vn");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("client", Client_Token);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", privateToken);
            _client.Timeout = TimeSpan.FromSeconds(100);
            var response =await _client.GetAsync("http://devapi.dxmb.vn/api/v1/resources");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                ResourceResponse = JsonConvert.DeserializeObject<BaseDataResponse<dynamic>>(result);
            }
            return ResourceResponse;
        }

    }
}
