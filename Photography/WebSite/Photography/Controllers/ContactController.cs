using System.Web.Mvc;
using Common;
using System;
using Photography.Interfaces;

namespace Photography.Controllers
{
    public class ContactController : BaseController
    {
        public ContactController() : this(null)
        {

        }

        public ContactController(ICategoryService categoryService) : base(categoryService)
        {

        }

        [HttpPost]
        public ActionResult ContactPost(FormCollection contactForm)
        {
            EmailHelper emailHelper = new EmailHelper(contactForm["txtName"],
                                                      contactForm["txtEmail"],
                                                      contactForm["txtSubject"],
                                                      contactForm["txtMessage"]);

            try
            {
                emailHelper.Send();
            }
            catch (Exception)
            {
                return PartialView("_Fail");
            }

            return PartialView("_Success");
        }
    }
}
