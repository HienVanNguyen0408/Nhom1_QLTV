using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QLTV.Models
{
    /// <summary>
    /// Obj Nhà xuất bản
    /// </summary>
    class PublishingHouse
    {
        public string PublishingHouseCode { get; set; }
        public string PublishingHouseName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string RepresentativeInfo { get; set; }

        public PublishingHouse()
        {

        }
        public PublishingHouse(DataRow dataRow)
        {
            this.PublishingHouseCode = dataRow["PublishingHouseCode"].ToString();
            this.PublishingHouseName = dataRow["PublishingHouseName"].ToString();
            this.Address = dataRow["Address"].ToString();
            this.Email = dataRow["Email"].ToString();
            this.RepresentativeInfo = dataRow["RepresentativeInfo"].ToString();
        }
    }
}
