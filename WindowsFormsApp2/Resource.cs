using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Resource
    {
        public int id { get; set; }
        public string name { get; set; }
        public int owner_id { get; set; }
        public int contact_id { get; set; }
        public int city_id { get; set; }
        public string address { get; set; }
        public float base_price { get; set; }
        public float weekend_price { get; set; }
        public int resource_category_id { get; set; }
        public int slot { get; set; }
        public int total_pic { get; set; }
        public string media { get; set; }
        public string thumbnail_url { get; set; }
        public int thumbnail_type { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }

    }
}
