using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp2.Models;

namespace WebApp2.Pages.Forms
{
    public class RegistrationModel : PageModel
    {
        [BindProperty]
        public RegisterModel Create { get; set; }
        public void OnGet()
        {
           
        }


        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Content("USERNAME: " + HttpContext.Request.Form["Create.UserName"] + "\n" +
                "NAME: " + HttpContext.Request.Form["Create.Name"] + "\n" +
                "EMAIL: " + HttpContext.Request.Form["Create.Email"] + "\n" +
                "ADDRESS: " + HttpContext.Request.Form["Create.Address"] + "\n" +
                "CONTACT NUMBER: " + HttpContext.Request.Form["Create.Contact"] + "\n"+
                "AGE: " + HttpContext.Request.Form["Create.Age"] + "\n" +
                "GENDER: " + HttpContext.Request.Form["Create.Gender"] + "\n"
                );
        }
    }
}
