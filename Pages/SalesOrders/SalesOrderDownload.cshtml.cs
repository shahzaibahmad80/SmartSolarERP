using SmartSolarERP.Infrastructures.Pdfs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSolarERP.Pages.SalesOrders
{
    public class SalesOrderDownloadModel : PageModel
    {
        private readonly IPdfService _pdfService;
        public SalesOrderDownloadModel(IPdfService pdfService)
        {
            _pdfService = pdfService;
        }
        public IActionResult OnGet(string? id)
        {
            string fileName = $"SalesOrder-{Guid.NewGuid()}.pdf";
            string baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
            string htmlUrl = $"{baseUrl}/SalesOrders/SalesOrderPdf/{id}";
            byte[] pdfBytes = _pdfService.CreatePdfFromPage(htmlUrl, fileName);

            //old-1 //return File(pdfBytes, "application/pdf", fileName);
            //old-2, below
            // Return PDF as inline content to display in browser           
            //return new FileContentResult(pdfBytes, "application/pdf")
            //{
            //    FileDownloadName = fileName
            //};
            //old-2
           // Response.Headers.Add("Content-Disposition", "inline; filename=" + fileName);
            return File(pdfBytes, "application/pdf");
        }
    }
}
