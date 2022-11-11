using AgriculturePresentation.Models;
using ClosedXML.Excel;
using DataAccesLayer.Contexts;
using DocumentFormat.OpenXml.Spreadsheet;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AgriculturePresentation.Controllers
{
    public class ReportController : Controller
    {
        private string stream;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticReport()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workBook = excelPackage.Workbook.Worksheets.Add("deneme");

            workBook.Cells[1, 1].Value = "Ürün Adı";
            workBook.Cells[1, 2].Value = "Ürün Kategorisi";
            workBook.Cells[1, 3].Value = "Ürün Stok";

            workBook.Cells[2, 1].Value = "Şeftali";
            workBook.Cells[2, 2].Value = "Meyve";
            workBook.Cells[2, 3].Value = "40 Ton";

            workBook.Cells[3, 1].Value = "Buğday";
            workBook.Cells[3, 2].Value = "Bakliyat";
            workBook.Cells[3, 3].Value = "20 Ton";

            var bytes = excelPackage.GetAsByteArray();

            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ÜrünRaporu.xlsx");

        }

        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using (var context = new AgricultureContext())
            {
                contactModels = context.Contacts.Select(x => new ContactModel
                {
                    ContactId = x.ContactId,
                    ContactName = x.Name,
                    ContactDate = x.Date,
                    ContactMail = x.Mail,
                    ContactDetail = x.Message


                }).ToList();
            }
            return contactModels;
        }
        public IActionResult ContactReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Mesaj Listesi");
                workSheet.Cell(1, 1).Value = "Mesaj Id";
                workSheet.Cell(1, 2).Value = "Mesajı Gönderen";
                workSheet.Cell(1, 3).Value = "Mail Adresi";
                workSheet.Cell(1, 4).Value = "Mesaj İçeriği";
                workSheet.Cell(1, 5).Value = "Mesaj Tarihi";

                int contactRowCount = 2;
                foreach (var item in ContactList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.ContactId;
                    workSheet.Cell(contactRowCount, 2).Value = item.ContactName;
                    workSheet.Cell(contactRowCount, 3).Value = item.ContactMail;
                    workSheet.Cell(contactRowCount, 4).Value = item.ContactDetail;
                    workSheet.Cell(contactRowCount, 5).Value = item.ContactDate;
                    contactRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MesajRaporu.xlsx");
                }
            }

        }
        public List<AnnouncemenetModel> AnnouncementList()
        {
            List<AnnouncemenetModel> announcementModels = new List<AnnouncemenetModel>();
            using (var context = new AgricultureContext())
            {
                announcementModels = context.Announcements.Select(x => new AnnouncemenetModel
                {
                    Id=x.AnnouncementId,
                    Date=x.Date,
                    Description=x.Description,
                    Status=x.Status,
                    Title = x.Title

                    

                }).ToList();
            }
            return announcementModels;
        }
        
        public IActionResult AnnouncementReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Duyuru Listesi");
                workSheet.Cell(1,1).Value="Duyuru Id";
                workSheet.Cell(1,2).Value="Başlık";
                workSheet.Cell(1,3).Value="Açıklama";
                workSheet.Cell(1,4).Value="Tarih";
                workSheet.Cell(1,5).Value="Durum";

                int contactRowCount = 2;
                foreach (var item in AnnouncementList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.Id;
                    workSheet.Cell(contactRowCount, 2).Value = item.Title;
                    workSheet.Cell(contactRowCount, 3).Value = item.Description;
                    workSheet.Cell(contactRowCount, 4).Value = item.Date;
                    workSheet.Cell(contactRowCount, 5).Value = item.Status;

                    contactRowCount++;
                }

                using (var stream = new MemoryStream())
                    {
                        workBook.SaveAs(stream);
                        var content = stream.ToArray();
                        return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Duyurular.xlsx");
                    }
               
            }
            
                
        }
    }
}
