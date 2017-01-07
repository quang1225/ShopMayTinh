using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopMayTinh.Models;

namespace ShopMayTinh.Controllers
{
    public class KhachHangController : Controller
    {

        public ActionResult LoginPartial()
        {
            
            return PartialView();
        }


        //TAO 1 DOI TUONG CHUA TOAN BO CSDL
        dbShopMayTinhDataContext db = new dbShopMayTinhDataContext();

        // GET: KhachHang
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public ActionResult DangnhapDangky()
        {
            return View();
        }

        
        [HttpPost]  //NHẬN DỮ LIỆU TỪ TRANG DangnhapDangky

        public ActionResult DangnhapDangky(FormCollection collection, KHACHHANG khDK)
        {
            var emailDN = collection["emailDN"];
            var passDN = collection["passDN"];

            if (String.IsNullOrEmpty(emailDN) && String.IsNullOrEmpty(passDN))
            {     
                //DANG KY
                khDK.TenKH = collection["hoten"];
                khDK.Email = collection["emailDK"];
                khDK.Pass = collection["passDK"];
                khDK.Address = collection["diachi"];
                khDK.Phone = collection["phone"];
                db.KHACHHANGs.InsertOnSubmit(khDK);
                db.SubmitChanges();

                return RedirectToAction("DangnhapDangky");
            }

            else
            {
                //DANG NHAP

                KHACHHANG khDN = db.KHACHHANGs.SingleOrDefault(a => a.Email == emailDN && a.Pass == passDN);

                if (khDN != null)
                {
                    ViewBag.ThongbaoDN = "Đăng nhập thành công !";
                    Session["Email"] = khDN;

                }
                else
                    ViewBag.ThongbaoDN = "Email hoặc mật khẩu sai !";

                return View();
            }
        }

        [HttpGet]
        //SỬA TÀI KHOẢN
        public ActionResult SuaTK()
        {
            if (Session["Email"] == null || Session["Email"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                var khDN = Session["Email"];
                return View(khDN);
            }
        }

        [HttpPost]
        //SỬA TÀI KHOẢN
        public ActionResult SuaTK(KHACHHANG khDN)
        {
            khDN = (ShopMayTinh.Models.KHACHHANG)Session["Email"];
            UpdateModel(khDN);
            db.SubmitChanges();


            return RedirectToAction("Index","Home");
        }

        //ĐĂNG XUẤT
        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("Index","Home");
        }

    }
}