using System;

using AppKit;
using Foundation;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using CoreServices;

namespace CaluclatorAssignment
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

        private string connectionString = "Server=localhost;Database=CalculatorDB;User Id=SA;Password=Ozzy03004504393_;";

        public void ConnectAndQuery()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // Example query
                    string query = "SELECT * FROM Addition_Table;";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Process each row
                        Console.WriteLine(reader.GetString(0)); // Example: assuming the first column is a string
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to database: " + ex.Message);
                }
            }
        }

        partial void pushButton1(NSButton sender)
        {
            double num1 = Convert.ToDouble(textInput1.StringValue);
            double num2 = Convert.ToDouble(textInput2.StringValue);
            string result = "";

            if (selected1 == 0)
            {
                SetText1(Convert.ToString(num1 + num2));
                result = Convert.ToString(num1 + num2);
                StoreResultInDatabase(num1, num2, result, "Addition_Table");
            }
            else if (selected1 == 1)
            {
                SetText1(Convert.ToString(num1 - num2));
                result = Convert.ToString(num1 - num2);
                StoreResultInDatabase(num1, num2, result, "Subtraction_Table");
            }
            else if (selected1 == 2)
            {
                SetText1(Convert.ToString(num1 * num2));
                result = Convert.ToString(num1 * num2);
                StoreResultInDatabase(num1, num2, result, "Multiplication_Table");
            }
            else if (selected1 == 3)
            {
                SetText1(Convert.ToString(num1 / num2));
                result = Convert.ToString(num1 / num2);
                StoreResultInDatabase(num1, num2, result, "Division_Table");
            }
            //ConnectAndQuery();
        }

        private void StoreResultInDatabase(double operand1, double operand2, string result, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // Prepare the SQL command
                    string query = $"INSERT INTO {tableName} (Operand1, Operand2, Result) VALUES (@Operand1, @Operand2, @Result)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Specify parameters and their values
                    command.Parameters.AddWithValue("@Operand1", operand1);
                    command.Parameters.AddWithValue("@Operand2", operand2);
                    command.Parameters.AddWithValue("@Result", result);

                    // Execute the command
                    command.ExecuteNonQuery();
                    Console.WriteLine("Result stored in database successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error storing result in database: " + ex.Message);
                }
            }
        }

        partial void pushButton2(NSButton sender)
        {
            double num3 = Convert.ToDouble(textInput3.StringValue);
            string result = "";

            if (selected2 == 0)
            {
                SetText2(Convert.ToString(num3 * num3));
                result = Convert.ToString(num3 * num3);
                StoreResultInDatabase1(num3, result, "Square_Table");
            }
            else if (selected2 == 1)
            {
                SetText2(Convert.ToString(Math.Sqrt(num3)));
                result = Convert.ToString(Math.Sqrt(num3));
                StoreResultInDatabase1(num3, result, "SquareRoot_Table");
            }
        }

        private void StoreResultInDatabase1(double operand, string result, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    // Prepare the SQL command
                    string query = $"INSERT INTO {tableName} (Operand, Result) VALUES (@Operand, @Result)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Specify parameters and their values
                    command.Parameters.AddWithValue("@Operand", operand);
                    command.Parameters.AddWithValue("@Result", result);

                    // Execute the command
                    command.ExecuteNonQuery();
                    Console.WriteLine("Result stored in database successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error storing result in database: " + ex.Message);
                }
            }
        }

        private void SetText1(string text)
		{
			infoLabel1.StringValue = text;
		}

		private void SetText2(string text)
		{
			infoLabel2.StringValue = text;
		}

		int selected1 = 0;
		int selected2 = 0;

        partial void addAction(NSButton sender)
        {
            SetRadio(addOutlet);
            selected1 = 0;
        }

        partial void subtractAction(NSButton sender)
        {
            SetRadio(subtractOutlet);
            selected1 = 1;
        }

        partial void multiplyAction(NSButton sender)
        {
            SetRadio(multiplyOutlet);
            selected1 = 2;
        }

        partial void divideAction(NSButton sender)
        {
            SetRadio(divideOutlet);
            selected1 = 3;
        }

        partial void squareAction(NSButton sender)
        {
            SetRadio(squareOutlet);
            selected2 = 0;
        }

        partial void squareRootAction(NSButton sender)
        {
            SetRadio(squareRootOutlet);
            selected2 = 1;
        }

        public void SetRadio(NSButton selected)
        {
            addOutlet.State = NSCellStateValue.Off;
            subtractOutlet.State = NSCellStateValue.Off;
            multiplyOutlet.State = NSCellStateValue.Off;
            divideOutlet.State = NSCellStateValue.Off;
            squareRootOutlet.State = NSCellStateValue.Off;
            squareOutlet.State = NSCellStateValue.Off;
            selected.State = NSCellStateValue.On;
        }

        
    }
}
