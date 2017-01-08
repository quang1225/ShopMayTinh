using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopMayTinh.Models;
using PagedList;
using PagedList.Mvc;

namespace ShopMayTinh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            return View();
        }

        public ActionResult TinTuc()
        {
            return View();
        }

        //TAO 1 DOI TUONG CHUA TOAN BO CSDL
        dbShopMayTinhDataContext data = new dbShopMayTinhDataContext();

        //TÌM SẢN PHẨM
        [HttpPost]
        public ActionResult TimKiem( int ? trang, FormCollection form )
        {
            var text = form["timkiem"];
            if (!String.IsNullOrEmpty(text))
            {
                //Tạo biến quy đinh số SP mỗi trang
                int pageSize = 3;

                //Tạo biến số trang
                int pageNum = (trang ?? 1);

                var kq = from a in data.SANPHAMs select a;

                kq = kq.Where(s => s.TenSP.Contains(text));
                ViewBag.Text = text;

                return View(kq.ToPagedList(pageNum, pageSize));
            }
            else
                return RedirectToAction("Index","Home");
        }
   

        public ActionResult Index( int ? trang)
        {

            //Tạo biến quy đinh số SP mỗi trang
            int pageSize = 6;

            //Tạo biến số trang
            int pageNum = (trang ?? 1);

            // Hiển thị tất cả SP từ mới --> cũ
            var SPmoi = data.SANPHAMs.OrderByDescending(a => a.NgayNhap);

            return View(SPmoi.ToPagedList(pageNum, pageSize));
        }

        public ActionResult linhkienmoi()
        {
            var linhkienmoi = from lkmoi in data.DANHMUCs select lkmoi;
            return PartialView(linhkienmoi);
        }

        public ActionResult DSlinhkienmoi(int id, int ? trang)
        {
            //Tạo biến quy đinh số SP mỗi trang
            int pageSize = 6;

            //Tạo biến số trang
            int pageNum = (trang ?? 1);

            var ALLmoi = from SPmoi in data.SANPHAMs where SPmoi.TinhTrang == "moi" select SPmoi;
            var TheoDanhMuc = from SPmoi in data.SANPHAMs where (SPmoi.MaDM == id) && (SPmoi.TinhTrang == "moi") select SPmoi;


            if (id == 0)
            {
                ViewBag.TenDM = "TẤT CẢ LINH KIỆN";
                return View(ALLmoi.ToPagedList(pageNum, pageSize));
            }
            else
            {
                ViewBag.TenDM = data.DANHMUCs.SingleOrDefault(a => a.MaDM == id).TenDM;
                return View(TheoDanhMuc.ToPagedList(pageNum, pageSize));
            }

        }

        public ActionResult linhkiencu()
        {
            var linhkiencu = from lkcu in data.DANHMUCs
                             select lkcu;
            return PartialView(linhkiencu);
        }

        public ActionResult DSlinhkiencu(int id, int ? trang)
        {
            //Tạo biến quy đinh số SP mỗi trang
            int pageSize = 6;

            //Tạo biến số trang
            int pageNum = (trang ?? 1);

            var ALLcu = from SPcu in data.SANPHAMs
                        where SPcu.TinhTrang == "cu"
                        select SPcu;
            var TheoDanhMuc = from SPcu in data.SANPHAMs
                              where (SPcu.MaDM == id) && (SPcu.TinhTrang == "cu")
                              select SPcu;

            if (id == 0)
            {
                ViewBag.TenDM = "TẤT CẢ LINH KIỆN";
                return View(ALLcu.ToPagedList(pageNum, pageSize));
            }
            else
            {
                ViewBag.TenDM = data.DANHMUCs.SingleOrDefault(a => a.MaDM == id).TenDM;
                return View(TheoDanhMuc.ToPagedList(pageNum, pageSize));
            }
        }

        public ActionResult chitietSP(int id)
        {
            var sanpham = from s in data.SANPHAMs
                          where s.MaSP == id
                          select s;

            return View(sanpham.Single());
        }

    }
}