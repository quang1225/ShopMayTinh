using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMayTinh.Models
{
    public class Giohang
    {
        //Tạo đối tượng chứa dữ liệu
        dbShopMayTinhDataContext data = new dbShopMayTinhDataContext();

        public int sMaSP { set; get; }
        public string sTenSP { set; get; }
        public string sHinhAnh { set; get; }
        public Double sDonGia { set; get; }
        public int sSoLuong { set; get; }
        public Double sThanhTien
        {
            get { return (sSoLuong * sDonGia); }
        }

        //Khởi tạo giỏ hàng theo MaSP với số lượng mặc định là 1
        public Giohang( int MaSP)
        {
            sMaSP = MaSP;
            SANPHAM sp = data.SANPHAMs.Single( a => a.MaSP == sMaSP);
            sTenSP = sp.TenSP;
            sHinhAnh = sp.HinhAnh;
            sDonGia = double.Parse(sp.DonGia.ToString());
            sSoLuong = 1;
        }


    }
}