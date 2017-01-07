using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopMayTinh.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace ShopMayTinh.Controllers
{
    public class AdminController : Controller
    {

        //TAO 1 DOI TUONG CHUA TOAN BO CSDL
        dbShopMayTinhDataContext db = new dbShopMayTinhDataContext();

        public ActionResult Index()
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
                return View();
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
                return View();
            else
                return RedirectToAction("QLsanpham", "Admin");
        }

        [HttpPost]  //NHẬN DỮ LIỆU
        public ActionResult DangNhap(FormCollection collection)
        {

            var userAdmin = collection["userAdmin"];
            var passAdmin = collection["passAdmin"];

            ADMIN adminDN = db.ADMINs.SingleOrDefault(a => a.ID == userAdmin && a.Pass == passAdmin);

            if (adminDN != null)
            {
                ViewBag.ThongbaoAdmin = "Đăng nhập thành công !";
                Session["admin"] = adminDN;
                return RedirectToAction("QLsanpham", "Admin");
            }
            else
                ViewBag.ThongbaoAdmin = "Email hoặc mật khẩu sai !";

            return View();
        }

        //ĐĂNG XUẤT
        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }

        //QUẢN LÝ SẢN PHẨM
        public ActionResult QLsanpham(int? trang)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                //Tạo biến quy đinh số SP mỗi trang
                int pageSize = 5;

                //Tạo biến số trang
                int pageNum = (trang ?? 1);

                return View(db.SANPHAMs.ToList().ToPagedList(pageNum, pageSize));
            }
        }

        //THÊM SẢN PHẨM
        [HttpGet]
        public ActionResult ThemSP()
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                //Đưa dữ liệu DropdownList kết nối tới DANH MỤC vào
                ViewBag.MaDM = new SelectList(db.DANHMUCs.ToList().OrderBy(a => a.TenDM), "MaDM", "TenDM");

                return View();
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemSP(SANPHAM sp, HttpPostedFileBase fileupload)
        {
            if (ModelState.IsValid)
            {
                var fileName = Path.GetFileName(fileupload.FileName);

                var path = Path.Combine(Server.MapPath("~/img/sanpham"), fileName);

                if (System.IO.File.Exists(path))
                {
                    ViewBag.ThongBao = "Hình ảnh bị trùng tên !";
                }
                else
                {
                    fileupload.SaveAs(path);
                }

                sp.HinhAnh = fileName;
                db.SANPHAMs.InsertOnSubmit(sp);
                db.SubmitChanges();
            }

            return RedirectToAction("QLsanpham");
        }

        //XÓA SẨN PHẨM
        public ActionResult XoaSP(int id)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                SANPHAM sanpham = db.SANPHAMs.SingleOrDefault(a => a.MaSP == id);
                if (sanpham == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }

                db.SANPHAMs.DeleteOnSubmit(sanpham);
                db.SubmitChanges();

                return RedirectToAction("QLsanpham");
            }
        }

        //SỬA SẢN PHẨM
        [HttpGet]
        public ActionResult SuaSP(int? id)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                SANPHAM sanpham = db.SANPHAMs.SingleOrDefault(a => a.MaSP == id);

                if (sanpham == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }

                //Đưa dữ liệu DropdownList kết nối tới DANH MỤC vào
                ViewBag.MaDM = new SelectList(db.DANHMUCs.ToList().OrderBy(a => a.TenDM), "MaDM", "TenDM");

                return View(sanpham);
            }

        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaSP(int id, HttpPostedFileBase fileupload)
        {
            if (ModelState.IsValid)
            {
                SANPHAM sanpham = db.SANPHAMs.SingleOrDefault(a => a.MaSP == id);

                if (fileupload != null && fileupload.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/img/sanpham"), fileName);

                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.ThongBao = "Hình ảnh bị trùng tên !";
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }

                    sanpham.HinhAnh = fileName;
                }

                UpdateModel(sanpham);
                db.SubmitChanges();
            }

            return RedirectToAction("QLsanpham");
        }


        //QUẢN LÝ DANH MỤC
        public ActionResult QLdanhmuc(int? trang)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                //Tạo biến quy đinh số SP mỗi trang
                int pageSize = 5;

                //Tạo biến số trang
                int pageNum = (trang ?? 1);

                return View(db.DANHMUCs.ToList().ToPagedList(pageNum, pageSize));
            }
        }

        //THÊM DANH MỤC
        [HttpGet]
        public ActionResult ThemDM()
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
                return View();
        }

        [HttpPost]
        public ActionResult ThemDM(DANHMUC dm)
        {
            if (ModelState.IsValid)
            {
                db.DANHMUCs.InsertOnSubmit(dm);
                db.SubmitChanges();
            }

            return RedirectToAction("QLdanhmuc");
        }

        //XÓA DANH MỤC
        public ActionResult XoaDM(int id)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                DANHMUC danhmuc = db.DANHMUCs.SingleOrDefault(a => a.MaDM == id);
                if (danhmuc == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }

                db.DANHMUCs.DeleteOnSubmit(danhmuc);
                db.SubmitChanges();

                return RedirectToAction("QLdanhmuc");
            }
        }

        //SỬA DANH MỤC
        [HttpGet]
        public ActionResult SuaDM(int? id)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                DANHMUC danhmuc = db.DANHMUCs.SingleOrDefault(a => a.MaDM == id);

                if (danhmuc == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }

                return View(danhmuc);
            }

        }

        [HttpPost]
        public ActionResult SuaDM(int id)
        {
            if (ModelState.IsValid)
            {
                DANHMUC danhmuc = db.DANHMUCs.SingleOrDefault(a => a.MaDM == id);
                UpdateModel(danhmuc);
                db.SubmitChanges();
            }

            return RedirectToAction("QLdanhmuc");
        }

        //DANH SÁCH ĐƠN ĐẶT HÀNG
        public ActionResult DSdonhang(int? trang)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                //Tạo biến quy đinh số SP mỗi trang
                int pageSize = 5;

                //Tạo biến số trang
                int pageNum = (trang ?? 1);

                return View(db.DONHANGs.ToList().ToPagedList(pageNum, pageSize));
            }
        }

        //XÓA ĐƠN HÀNG
        public ActionResult XoaDH(int id)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                DONHANG dh = db.DONHANGs.SingleOrDefault(a => a.MaDH == id);

                if (dh == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                
                db.DONHANGs.DeleteOnSubmit(dh);

                db.SubmitChanges();

                return RedirectToAction("DSdonhang");
            }
        }

        //CHI TIẾT ĐƠN ĐẶT HÀNG
        public ActionResult chitietDH(int id, int? trang)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                //Tạo biến quy đinh số SP mỗi trang
                int pageSize = 5;

                //Tạo biến số trang
                int pageNum = (trang ?? 1);

                var CTDH = from ctdh in db.CHITIETDONHANGs where ctdh.MaDH == id select ctdh;
                return View(CTDH.ToPagedList(pageNum, pageSize));
            }
        }

        //XÓA CTDH
        public ActionResult XoaCTDH(int id, int dh, string URL)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                CHITIETDONHANG CTDH = db.CHITIETDONHANGs.SingleOrDefault(a => a.MaSP == id && a.MaDH == dh);
                if (CTDH == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }

                db.CHITIETDONHANGs.DeleteOnSubmit(CTDH);
                db.SubmitChanges();



                return Redirect(URL);
            }
        }


        // QUẢN LÝ TÀI KHOẢN

        public ActionResult QLtaikhoan(int? trang)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                //Tạo biến quy đinh số SP mỗi trang
                int pageSize = 5;

                //Tạo biến số trang
                int pageNum = (trang ?? 1);

                return View(db.KHACHHANGs.ToList().ToPagedList(pageNum, pageSize));
            }
        }

        //THÊM TÀI KHOẢN
        [HttpGet]
        public ActionResult ThemTK()
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                //Đưa dữ liệu DropdownList kết nối tới table PHÂN QUYỀN vào
                ViewBag.MaQuyen = new SelectList(db.PHANQUYENs.ToList().OrderBy(a => a.TenQuyen), "MaQuyen", "TenQuyen");

                return View();
            }
                
        }

        [HttpPost]
        public ActionResult ThemTK(KHACHHANG tk)
        {
            if (ModelState.IsValid)
            {
                db.KHACHHANGs.InsertOnSubmit(tk);
                db.SubmitChanges();
            }

            return RedirectToAction("QLtaikhoan");
        }

        //SỬA TÀI KHOẢN
        [HttpGet]
        public ActionResult SuaTK(int? id)
        {
            if (Session["admin"] == null || Session["admin"].ToString() == "")
            {
                return RedirectToAction("DangNhap");
            }

            else
            {
                KHACHHANG tk = db.KHACHHANGs.SingleOrDefault(a => a.MaKH == id);

                if (tk == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }

                //Đưa dữ liệu DropdownList kết nối tới table PHÂN QUYỀN vào
                ViewBag.MaQuyen = new SelectList(db.PHANQUYENs.ToList().OrderBy(a => a.TenQuyen), "MaQuyen", "TenQuyen");

                return View(tk);
            }

        }

        [HttpPost]
        public ActionResult SuaTK(int id)
        {
            if (ModelState.IsValid)
            {
                KHACHHANG tk = db.KHACHHANGs.SingleOrDefault(a => a.MaKH == id);
                UpdateModel(tk);
                db.SubmitChanges();
            }

            return RedirectToAction("QLtaikhoan");
        }

    }
}