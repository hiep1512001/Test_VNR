using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class MonHoc_KhoaHoc
    {
        public String tenKhoaHoc { get; set; }
        public List<MonHoc> listMonhoc { get; set; }
        public List<KhoaHoc> listKhoaHoc { get; set; }
    }
}