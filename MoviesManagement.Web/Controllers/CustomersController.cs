using System.Web.Http.Results;
using System.Web.Mvc;
using MoviesManagement.DataContract;
using MoviesManagement.Management.Controllers;
using MoviesManagement.Web.ViewModels;

namespace MoviesManagement.Web.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customerManagement = new CustomerManagement();
            return View(customerManagement.GetCustomersWithMembershipTypes());
        }

        public ActionResult New()
        {
            var membershipTypeManagement = new MembershipTypeManagement();
            var customer = new CustomFormViewModel
            {
                MembershipTypes = membershipTypeManagement.GetMembershipType()
            };

            return View("CustomerForm", customer);
        }

        public ActionResult Edit(int id)
        {
            var customerManagement = new CustomerManagement();
            var customerDto = customerManagement.GetCustomerWithMembershipTypes(id);

            var customerFormViewModel = new CustomerViewModel
            {
                Customer = customerDto
            };

            return View(customerFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(CustomerDto customer)
        {
            if (!ModelState.IsValid)
            {
                return New();
            }

            var customerManagement = new CustomerManagement();
            if (customer.Id == 0)
            {
                customerManagement.Add(customer);
                TempData["Success"] = "Success";
            }
            else
            {
                var customerInDb = customerManagement.GetCustomerWithMembershipTypes(customer.Id);

                if (customerInDb == null)
                {
                    return HttpNotFound("No customer found");
                }
            }

            return RedirectToAction("Index", "Customers");
        }
    }
}