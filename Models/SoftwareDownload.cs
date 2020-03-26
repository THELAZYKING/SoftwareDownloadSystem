using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareDownloadSystem.Models
{
    public class SoftwareDownload
    {
        [Key]
        [Column(TypeName = "nvarchar(20)")]
        public string ID { get; set; }
        [Column(TypeName="nvarchar(20)")]
        public string Employee_Code { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Employee_EmailID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Software_Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Software_Version { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Software_License { get; set; }        
        [Column(TypeName = "nvarchar(255)")]
        public string Tags { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Website_Link { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Team_Lead_ID { get; set; }
        
        public Nullable<System.DateTime> Employee_Request_Time { get; set; }
        public Nullable<bool> Team_Lead_Status { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Team_Lead_Reamrk { get; set; }
        public Nullable<System.DateTime> Team_Lead_Response_Time { get; set; }
        public Nullable<bool> NSD_Response_Status { get; set; }
        [Column(TypeName = "nvarchar(300)")]
        public string NSD_Response_Link { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string NSD_Response_Remark { get; set; }
        public Nullable<System.DateTime> NSD_Response_Time { get; set; }
        public Nullable<bool> Level_Status { get; set; }
    }
}
