using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Profile
    {
        public int id { get; set; }
        public int account_id { get; set; }
        public string app_id { get; set; }
        public string name { get; set; }
        public string avatar { get; set; }
        public string date_of_birth { get; set; }
        public int? gender { get; set; }
        public int? role_id { get; set; }
        public string meta { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }
        public string admin_log { get; set; }
        public string sys_log { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
        public int? end_time { get; set; }

    }
}
