using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Sign_up_form.DAL;
using Sign_up_form.Models;

namespace Sign_up_form.Controllers
{
    public class AccountController : Controller
    {
        private User_DAL userDAL = new User_DAL();

        // Load the main page and the list of registered users
        public ActionResult Index()
        {
            return View();
        }

        // GET: SignUp form and registered users list
        public ActionResult SignUp()
        {
            List<User> users = userDAL.Get_all_users();  // Get all users from DAL
            ViewBag.Users = users;
            return View(new User()); // Pass an empty User model for sign-up
        }

        // POST: Handle form submission for sign-up
        [HttpPost]
        public ActionResult SignUp(User newUser)
        {
            if (ModelState.IsValid)
            {
                userDAL.AddUser(newUser);  // Add the new user to the database
                return RedirectToAction("SignUp"); // Redirect to the same page to show updated list
            }

            // If model state is invalid, return to the same view with the form data
            List<User> users = userDAL.Get_all_users();
            ViewBag.Users = users;
            return View(newUser);
        }

        [HttpPost]
        public ActionResult DeleteUser(string username)
        {
            userDAL.DeleteUser(username);  // Remove the user from the database
            return RedirectToAction("SignUp");  // Redirect to refresh the list
        }

        // GET: Load the Edit User page
        public ActionResult EditUser(string username)
        {
            var user = userDAL.GetUserByUsername(username);

            if (user == null)
            {
                return HttpNotFound(); // Handle case where user is not found
            }

            return View(user); // Pass the user model to the EditUser view
        }

        // POST: Handle the update of the user
        [HttpPost]
        public ActionResult EditUser(User updatedUser)
        {
            if (ModelState.IsValid)
            {
                userDAL.EditUser(updatedUser); // Update the user in the database
                return RedirectToAction("SignUp"); // Redirect to the sign-up page after update
            }

            // If model state is invalid, return to the same view with the form data
            return View(updatedUser); // Stay on the edit page to correct errors
        }






    }
}
