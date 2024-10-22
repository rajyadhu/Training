using System;
using System.Data.SqlClient;
using System.Web.Mvc;
using Sign_up_form.Models;

namespace Sign_up_form.Controllers
{
    public class AccountController : Controller
    {
        private string connectionString = "Server=YADHU\\SQLEXPRESS;Database=signupform;Trusted_Connection=True;";

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sign Up
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: Sign Up
        [HttpPost]
        public ActionResult SignUp(User newUser)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("AddUser", sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@FirstName", newUser.FirstName);
                        sqlCommand.Parameters.AddWithValue("@LastName", newUser.LastName);
                        sqlCommand.Parameters.AddWithValue("@Username", newUser.Username);
                        sqlCommand.Parameters.AddWithValue("@Place", newUser.Place);
                        sqlCommand.Parameters.AddWithValue("@PhoneNo", newUser.PhoneNo);
                        sqlCommand.Parameters.AddWithValue("@Password", newUser.Password);

                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }

                return RedirectToAction("Index", "Home");
            }
            return View(newUser);
        }
    }
}
