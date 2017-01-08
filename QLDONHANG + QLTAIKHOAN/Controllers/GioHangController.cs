using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopMayTinh.Models;

namespace ShopMayTinh.Controllers
{
    public class GioHangController : Controller
    {

        public ActionResult ChuaCoSP()
        {
            return View();
        }

        dbShopMayTinhDataContext data = new dbShopMayTinhDataContext();

        //Lấy giỏ hàng
        public List<Giohang> LayGioHang()
        {
            List<Giohang> lstGiohang = Session["GioHang"] as List<Giohang>;

            if ( lstGiohang == null )
            {
                //Nếu chưa có giỏ hàng thì tạo
                lstGiohang = new List<Giohang>();
                Session["GioHang"] = lstGiohang;
            }

            return lstGiohang;
        }

        [HttpPost]
        //THÊM HÀNG VÀO GIỎ HÀNG
        public JsonResult ThemGioHang( int sMaSP )
        {
            //Lấy ra Session giỏ hàng
            List<Giohang> lstGiohang = LayGioHang();

            //Kiểm tra sách này tồn tại trong giỏ hàng chưa
            Giohang sanpham = lstGiohang.Find(a => a.sMaSP == sMaSP);
            if ( sanpham == null )
            {
                sanpham = new Giohang(sMaSP);
                lstGiohang.Add(sanpham);
                return Json(new { TongSoLuong = TongSoLuong() } );
            }
            else
            {
                sanpham.sSoLuong++;
                return Json(new { TongSoLuong = TongSoLuong() });
            }
        }

        //Phương thức tính tổng số lượng
        private int TongSoLuong()
        {
            int sTongSoLuong = 0;
            List<Giohang> lstGiohang = Session["GioHang"] as List<Giohang>;
            if ( lstGiohang != null )
            {
                sTongSoLuong = lstGiohang.Sum(a => a.sSoLuong);
            }
            return sTongSoLuong;
        }

        //Tính tổng tiền
        private float TongTien()
        {
            float sTongTien = 0;
            List<Giohang> lstGiohang = Session["GioHang"] as List<Giohang>;
            if (lstGiohang != null)
            {
                sTongTien = Convert.ToInt64((lstGiohang.Sum(a => a.sThanhTien)));
            }

            return sTongTien;
        }

        //Xây dựng View giỏ hàng
        public ActionResult chitietGH()
        {
            List<Giohang> lstGiohang = LayGioHang();
            if ( lstGiohang.Count == 0 )
            {
                return RedirectToAction("ChuaCoSP","GioHang");
            }

            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();

            return View(lstGiohang);
        }

        //Xóa hàng trong giỏ hàng
        public ActionResult XoaGioHang( int sMaSP)
        {
            List<Giohang> lstGiohang = LayGioHang();

            //Kiểm tra sản phẩm đã có trong Session["GioHang"]
            Giohang sanpham = lstGiohang.SingleOrDefault(n => n.sMaSP == sMaSP);
            
            //Nếu tồn tại thì cho xóa
            if ( sanpham != null )
            {
                lstGiohang.RemoveAll(a => a.sMaSP == sMaSP);
                return RedirectToAction("chitietGH");
            }
            if ( lstGiohang.Count == 0 )
                return RedirectToAction("ChuaCoSP", "GioHang");

            return RedirectToAction("chitietGH");
        }

        //Cập nhật giỏ hàng
        public ActionResult capnhatGH( int sMaSP, FormCollection f)
        {
            List<Giohang> lstGiohang = LayGioHang();

            Giohang sanpham = lstGiohang.SingleOrDefault(n => n.sMaSP == sMaSP);

            if ( sanpham != null )
            {
                sanpham.sSoLuong = int.Parse(f["txtSoLuong"].ToString());
            }
            return RedirectToAction("chitietGH");
        }

        //Xóa hết SP trong giỏ hàng
        public ActionResult xoahetSP()
        {
            List<Giohang> lstGiohang = LayGioHang();
            lstGiohang.Clear();

            return RedirectToAction("chitietGH");
        }

        public ActionResult GiohangPartial()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            return PartialView();
        }

        //TRANG CHƯA ĐĂNG NHẬP
        public ActionResult chuaDN()
        {
            return View();
        }

        //THANH TOÁN

        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["Email"] == null || Session["Email"].ToString() == "")
            {
                return RedirectToAction("chuaDN", "GioHang");
            }
            if (Session["giohang"] == null)
            {
                return RedirectToAction("chuacoSP", "GioHang");
            }
            List<Giohang> lstGiohang = LayGioHang();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return View(lstGiohang);
        }

        [HttpPost]
        public ActionResult DatHang(FormCollection collection)
        {
            DONHANG dh = new DONHANG();
            KHACHHANG kh = (KHACHHANG)Session["Email"];
            List<Giohang> gh = LayGioHang();

            dh.MaKH = kh.MaKH;
            dh.NgayLap = DateTime.Now;
            var NgayGiao = String.Format("{0:MM/dd/yyyy}", collection["NgayGiao"]);
            dh.NgayGiao = DateTime.Parse(NgayGiao);
            dh.DaThanhToan = false;
            dh.ThanhTien = TongTien();

            data.DONHANGs.InsertOnSubmit(dh);
            data.SubmitChanges();
            foreach (var item in gh)
            {
                CHITIETDONHANG ctdh = new CHITIETDONHANG();
                ctdh.MaDH = dh.MaDH;
                ctdh.MaSP = item.sMaSP;
                ctdh.Soluong = item.sSoLuong;
                ctdh.DonGia = (int)item.sDonGia;
                ctdh.TongCong = ctdh.Soluong * ctdh.DonGia;
                data.CHITIETDONHANGs.InsertOnSubmit(ctdh);
            }
            data.SubmitChanges();
            Session["GioHang"] = null;
            return RedirectToAction("XacNhanDonHang", "GioHang");

        }

        //MUA LUÔN
        public ActionResult MuaLuon(int sMaSP)
        {
            if (Session["Email"] == null || Session["Email"].ToString() == "")
            {
                return RedirectToAction("chuaDN", "GioHang");
            }
            else
            {
                List<Giohang> lstGiohang = LayGioHang();
                lstGiohang.Clear();

                Giohang sanpham = lstGiohang.Find(a => a.sMaSP == sMaSP);
                sanpham = new Giohang(sMaSP);
                lstGiohang.Add(sanpham);

                return RedirectToAction("DatHang", "GioHang");
            }

        }

        public ActionResult XacNhanDonHang()
        {
            return View();
        }

    }
}