using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QLTV.Models
{
    /// <summary>
    /// Obj Tác giả
    /// </summary>
    class Author
    {
        public string AuthorCode { get; set; }
        public string AuthorName { get; set; }
        public string Website { get; set; }
        public string Note { get; set; }

        public Author()
        {

        }
        public Author(DataRow dataRow)
        {
            this.AuthorName = dataRow["AuthorName"].ToString();
            this.Website = dataRow["Website"].ToString();
            this.AuthorCode = dataRow["AuthorCode"].ToString();
            this.Note = dataRow["Note"].ToString();
        }
    }
}
