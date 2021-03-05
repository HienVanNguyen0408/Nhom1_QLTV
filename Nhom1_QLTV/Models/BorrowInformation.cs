using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QLTV.Models
{
    /// <summary>
    /// Obj Thông tin mượn trả
    /// </summary>
    class BorrowInformation
    {
        public string BorrowCode { get; set; }
        public string CardCode { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime BorrowDate { get; set; }


        public BorrowInformation()
        {

        }
        public BorrowInformation(DataRow dataRow)
        {
            this.BorrowCode = dataRow["BorrowCode"].ToString();
            this.CardCode = dataRow["CardCode"].ToString();
            this.EmployeeCode = dataRow["EmployeeCode"].ToString();
            this.BorrowDate = DateTime.Parse(dataRow["BorrowDate"].ToString());
        }
    }
}
