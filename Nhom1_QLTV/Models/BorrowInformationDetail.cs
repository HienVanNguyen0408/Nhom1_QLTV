using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QLTV.Models
{
    /// <summary>
    /// Obj Chi tiết thông tin mượn trả
    /// </summary>
    class BorrowInformationDetail
    {
        public string BorrowCode { get; set; }
        public string Note { get; set; }
        public DateTime BookReturnDate { get; set; }
        public int ReturnStatus { get; set; }
        public string BookCode { get; set; }

        public BorrowInformationDetail()
        {

        }
        public BorrowInformationDetail(DataRow dataRow)
        {
            this.BorrowCode = dataRow["BorrowCode"].ToString();
            this.Note = dataRow["Note"].ToString();
            this.BookCode = dataRow["BookCode"].ToString();
            this.BookReturnDate = DateTime.Parse(dataRow["BookReturnDate"].ToString());
            this.ReturnStatus = Int32.Parse(dataRow["ReturnStatus"].ToString());
        }
    }
}
