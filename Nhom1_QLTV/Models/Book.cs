using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QLTV.Models
{
    /// <summary>
    /// Obj Sách
    /// </summary>
    class Book
    {
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string AuthorCode { get; set; }
        public string CategoryCode { get; set; }
        public string PublishingHouseCode { get; set; }
        public DateTime PublishingYear { get; set; }

        public Book()
        {

        }
        public Book(DataRow dataRow)
        {
            this.BookCode = dataRow["BookCode"].ToString();
            this.BookName = dataRow["BookName"].ToString();
            this.AuthorCode = dataRow["AuthorCode"].ToString();
            this.CategoryCode = dataRow["CategoryCode"].ToString();
            this.PublishingHouseCode = dataRow["PublishingHouseCode"].ToString();
            this.PublishingYear = DateTime.Parse(dataRow["PublishingYear"].ToString());
        }
    }
}
