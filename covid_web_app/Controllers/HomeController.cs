using covid_web_app.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Diagnostics;

namespace covid_web_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(PatientModel model)
        {
            if (ModelState.IsValid)
            {
                NpgsqlConnection conn = Database.Database.GetConnection();
                Random rnd = new Random();

                int result = Database.Database.ExecuteUpdate(String.Format("insert into patient (first_name,last_name" +
                    ",email,phone,gender,age,diseases,address,date,id) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}');" 
                    , model.FirstName, model.LastName,model.Email,model.Phone,model.Gender,model.Age,model.UnderlyingDiseases,model.Address,
                    model.VaccinationDate.ToString("yyyy-M-dd hh:mm:ss"), rnd.Next(Int32.MaxValue)), conn);

                if (result != 0)
                {
                    conn.Close();
                    ViewBag.Success = true;
                    return View();
                }
                conn.Close();
            }
            ViewBag.Success = false;
            return View();
        }


        [HttpGet]
        public IActionResult ViewVaccinations()
        {
            List<PatientModel> list = new List<PatientModel>();

            NpgsqlConnection conn = Database.Database.GetConnection();

            NpgsqlDataReader reader = Database.Database.ExecuteQuery(String.Format("select * from patient"), conn);

            while (reader.Read())
            {
                PatientModel model = new PatientModel();
                model.FirstName = reader.GetString(0);
                model.LastName = reader.GetString(1);
                model.Email = reader.GetString(2);
                model.Phone = reader.GetString(3);
                model.Gender = reader.GetString(4);
                model.Age = reader.GetInt32(5);
                model.UnderlyingDiseases = reader.GetString(6);
                model.Address = reader.GetString(7);
                model.VaccinationDate = reader.GetDateTime(8);
                model.id = reader.GetInt32(9);

                list.Add(model);
            }

            conn.Close();

            return View(list) ;
        }

        
        public IActionResult DeletePage(int id)
        {

            NpgsqlConnection conn = Database.Database.GetConnection();

            NpgsqlDataReader reader = Database.Database.ExecuteQuery(String.Format("select * from patient where id='{0}'",id), conn);

            PatientModel model = new PatientModel();
            while (reader.Read())
            {
                model.FirstName = reader.GetString(0);
                model.LastName = reader.GetString(1);
                model.Email = reader.GetString(2);
                model.Phone = reader.GetString(3);
                model.Gender = reader.GetString(4);
                model.Age = reader.GetInt32(5);
                model.UnderlyingDiseases = reader.GetString(6);
                model.Address = reader.GetString(7);
                model.VaccinationDate = reader.GetDateTime(8);
                model.id = reader.GetInt32(9);

            }

            conn.Close();

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            NpgsqlConnection conn = Database.Database.GetConnection();

            int result = Database.Database.ExecuteUpdate(String.Format("delete from patient where id='{0}'",id), conn);
            
            if(result == 1)
            {
                ViewBag.Success = true;

            }
            else
            {
                ViewBag["success"] = false;
            }

            return View("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            NpgsqlConnection conn = Database.Database.GetConnection();

            NpgsqlDataReader reader = Database.Database.ExecuteQuery(String.Format("select * from patient where id='{0}'", id), conn);

            PatientModel model = new PatientModel();
            while (reader.Read())
            {
                model.FirstName = reader.GetString(0);
                model.LastName = reader.GetString(1);
                model.Email = reader.GetString(2);
                model.Phone = reader.GetString(3);
                model.Gender = reader.GetString(4);
                model.Age = reader.GetInt32(5);
                model.UnderlyingDiseases = reader.GetString(6);
                model.Address = reader.GetString(7);
                model.VaccinationDate = reader.GetDateTime(8);
                model.id = reader.GetInt32(9);

            }

            conn.Close();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(string str, string type, int id)
        {
            int result;

            NpgsqlConnection conn = Database.Database.GetConnection();

            bool isDate = DateTime.TryParse(str, out DateTime date);

            if (isDate)
            {

                result = Database.Database.ExecuteUpdate(String.Format("UPDATE patient SET {0} = '{1}' WHERE id = '{2}';", type, date.ToString("yyyy-M-dd hh:mm:ss"), id), conn);
                conn.Close();
            }
            else
            {

                result = Database.Database.ExecuteUpdate(String.Format("UPDATE patient SET {0} = '{1}' WHERE id = '{2}';", type, str, id), conn);
                conn.Close();
            }

            if (result == 1)
            {
                ViewBag.Success = true;

            }
            else
            {
                ViewBag["success"] = false;
            }


            NpgsqlDataReader reader = Database.Database.ExecuteQuery(String.Format("select * from patient where id='{0}'", id), conn);

            PatientModel model = new PatientModel();
            while (reader.Read())
            {
                model.FirstName = reader.GetString(0);
                model.LastName = reader.GetString(1);
                model.Email = reader.GetString(2);
                model.Phone = reader.GetString(3);
                model.Gender = reader.GetString(4);
                model.Age = reader.GetInt32(5);
                model.UnderlyingDiseases = reader.GetString(6);
                model.Address = reader.GetString(7);
                model.VaccinationDate = reader.GetDateTime(8);
                model.id = reader.GetInt32(9);

            }

            conn.Close();

            return View(model);
        }

        [HttpGet]
        public IActionResult SearchPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string str)
        {
            if (str == null)
            {
                ViewBag.Fail = true;
                return View("SearchPage");
            }

            List<PatientModel> list = new List<PatientModel>();

            NpgsqlConnection conn = Database.Database.GetConnection();

            if (str.Contains(' '))
            {
                string firstName = str.Substring(0, str.IndexOf(' '));
                string lastName = str.Substring(str.IndexOf(' ') + 1);

                NpgsqlDataReader reader = Database.Database.ExecuteQuery(String.Format("select * from patient where first_name='{0}' and last_name='{1}'", firstName, lastName), conn);

                while (reader.Read())
                {
                    PatientModel model = new PatientModel();
                    model.FirstName = reader.GetString(0);
                    model.LastName = reader.GetString(1);
                    model.Email = reader.GetString(2);
                    model.Phone = reader.GetString(3);
                    model.Gender = reader.GetString(4);
                    model.Age = reader.GetInt32(5);
                    model.UnderlyingDiseases = reader.GetString(6);
                    model.Address = reader.GetString(7);
                    model.VaccinationDate = reader.GetDateTime(8);
                    model.id = reader.GetInt32(9);

                    list.Add(model);
                }

                conn.Close();
            }
            else
            {
                DateTime date = DateTime.Parse(str);

                NpgsqlDataReader reader = Database.Database.ExecuteQuery(String.Format("select * from patient where date='{0}'",date.ToString("yyyy-M-dd hh:mm:ss")), conn);

                while (reader.Read())
                {
                    PatientModel model = new PatientModel();
                    model.FirstName = reader.GetString(0);
                    model.LastName = reader.GetString(1);
                    model.Email = reader.GetString(2);
                    model.Phone = reader.GetString(3);
                    model.Gender = reader.GetString(4);
                    model.Age = reader.GetInt32(5);
                    model.UnderlyingDiseases = reader.GetString(6);
                    model.Address = reader.GetString(7);
                    model.VaccinationDate = reader.GetDateTime(8);
                    model.id = reader.GetInt32(9);

                    list.Add(model);
                }

                conn.Close();
            }

            return View(list);

        }
    }
}