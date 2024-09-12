using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Security;
using static ClientCRUD.Pages.Clients.IndexModel;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace ClientCRUD.Pages.Clients
{
    public class CreateModel : PageModel
    {
        public ClientInfo clientInfo1 = new ClientInfo();
		public String errorMessage = "";
		public String successMessage = "";

        public void OnGet()
        {
        }

		public void OnPost()
		{
			// Capture form data
			clientInfo1.name = Request.Form["name"];
			clientInfo1.email = Request.Form["email"];
			clientInfo1.phone = Request.Form["phone"];
			clientInfo1.address = Request.Form["address"];


			// Validate fields using string.IsNullOrEmpty()
			if (string.IsNullOrEmpty(clientInfo1.name) ||
				string.IsNullOrEmpty(clientInfo1.email) ||
				string.IsNullOrEmpty(clientInfo1.phone) ||
				string.IsNullOrEmpty(clientInfo1.address))
			{
				errorMessage = "All the fields are required.";
				return;
			}

			try
			{
				String connectionString = "Data Source=.\\SQLEXPRESS;Database =clientCRUD ;Integrated Security=True;MultipleActiveResultSets=True";
				using (SqlConnection connection = new SqlConnection(connectionString)) 
				{ 
					connection.Open();
					//String query = "insert into Clients " + "(name, email,phone, address) values " + "(@name, @email, @phone ,@address);";
					String query = "INSERT INTO Clients(name, email, phone, address) VALUES(@name, @email, @phone, @address)";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@name", clientInfo1.name);
						command.Parameters.AddWithValue("@email", clientInfo1.email);
						command.Parameters.AddWithValue("@phone", clientInfo1.phone);
						command.Parameters.AddWithValue("@address", clientInfo1.address);

						command.ExecuteNonQuery();

					}
				}


			}
			catch (Exception ex)
			{
				errorMessage = ex.Message;
			}

			clientInfo1.name = ""; clientInfo1.email = ""; clientInfo1.phone = ""; clientInfo1.address = "";
			successMessage = "New Client Added successfully.";

			Response.Redirect("/Clients/Index"); 

		}
	}
}
