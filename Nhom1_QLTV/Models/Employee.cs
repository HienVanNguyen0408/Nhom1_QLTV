﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QLTV.Models
{
    /// <summary>
    /// Obj Nhân viên
    /// </summary>
    class Employee
    {
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

        public Employee()
        {

        }

        public Employee(DataRow dataRow)
        {
            this.EmployeeCode = dataRow["EmployeeCode"].ToString();
            this.DateOfBirth = DateTime.Parse(dataRow["DateOfBirth"].ToString());
            this.FullName = dataRow["FullName"].ToString();
            this.PhoneNumber = dataRow["PhoneNumber"].ToString();
        }
    }
}
