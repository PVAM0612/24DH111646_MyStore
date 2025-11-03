using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;
using PagedList;

namespace _24DH111646_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        // Tiêu chí để search theo tên, mô tả sp hoặc loại sản phẩm
        public string SearchTerm { get; set; }
        // Các tiêu chí để search theo giá
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        // Thuộc tính sắp xếp (theo tên hoặc giá)
        public string SortOrder { get; set; }

        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 10;

        //danh sachs san pham phan trang
        public PagedList.IPagedList<Product> Products { get; set; }

        // Danh sách sản phẩm thỏa điều kiện tìm kiếm
        //public List<Product> Products { get; set; }


    }
}