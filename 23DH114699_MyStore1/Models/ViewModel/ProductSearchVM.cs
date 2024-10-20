using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23DH114699_MyStore1.Models.ViewModel
{
    public class ProductSearchVM
    {
        //tiêu chí để search theo tên, mô tả sp
        //hoặc loại sản phẩm
        public string SearchTerm { get; set; } 
        //các tiêu chí để search theo giá
        public decimal? MinPrice { get; set; }  
        public decimal? MaxPrice { get; set; }
        //thứ tự sắp xếp
        public string SortOrder { get; set; }
        //các thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; } //Trang hiện tại
        public int PageSize { get; set; }  //số sản phẩm mỗi trang
        //Danh sách sản phẩm đã phân trang
        public PageList.IPagedList<Product> Products { get; set; }
        //danh sách sản phẩm thỏa điều kiện tìm kiếm
        //public List<product> Products {get; set;}
    }
}