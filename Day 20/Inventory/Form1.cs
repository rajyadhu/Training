using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        // Static connection string variable
        private static string connectionString = "Data Source=YADHU\\SQLEXPRESS;Initial Catalog=inventory;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int productId;
            string productName = product_name_txt.Text;
            int quantity;
            int pricePerUnit;
            string supplier = supplier_txt.Text;

            // Validate inputs
            if (!int.TryParse(product_id_txt.Text, out productId) ||
                string.IsNullOrWhiteSpace(productName) ||
                !int.TryParse(quantity_txt.Text, out quantity) ||
                !int.TryParse(price_per_unit_txt.Text, out pricePerUnit) ||
                string.IsNullOrWhiteSpace(supplier))
            {
                MessageBox.Show("Please enter valid values for all fields.");
                return;
            }

            string storedProcedure = "AddProduct";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);
                        command.Parameters.AddWithValue("@Supplier", supplier);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product added successfully!");
                            LoadProducts();
                            ClearTextBoxes(); // clear the textboxes
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the product.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Ensure the connection is closed
                }
            }
        }

        private void LoadProducts()
        {
            string storedProcedure = "GetAllProducts";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        inventory_db_view_grid.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Ensure the connection is closed
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            int productId;
            int quantity;
            int pricePerUnit;

            // Validate inputs
            if (!int.TryParse(product_id_txt.Text, out productId) || // Product ID
                !int.TryParse(quantity_txt.Text, out quantity) || // Quantity
                !int.TryParse(price_per_unit_txt.Text, out pricePerUnit)) // Price Per Unit
            {
                MessageBox.Show("Please enter valid values for Product ID, Quantity, and Price Per Unit.");
                return;
            }

            // Define the stored procedure for updating a product
            string storedProcedure = "UpdateProduct";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL command for the stored procedure
                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@PricePerUnit", pricePerUnit);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully!");
                            LoadProducts(); // Refresh the DataGridView
                            ClearTextBoxes(); // clear the textboxes
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the product.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int productId;

            if (!int.TryParse(product_id_txt.Text, out productId) )// Product ID
            {
                MessageBox.Show("Please enter valid values for Product ID");
                return;
            }

            // Define the stored procedure for deleting a product
            string storedProcedure = "DeleteProduct";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL command for the stored procedure
                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        command.Parameters.AddWithValue("@ProductID", productId);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully!");
                            LoadProducts(); // Refresh the DataGridView
                            ClearTextBoxes(); // clear the textboxes
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the product.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //  method to clear all text box
        private void ClearTextBoxes()
        {
            product_id_txt.Text = "";
            product_name_txt.Text = "";
            quantity_txt.Text = "";
            price_per_unit_txt.Text = "";
            supplier_txt.Text = "";
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string productName = product_name_txt.Text;
            int productId;

            // Initialize the search flag
            bool searchById = false;
            bool searchByName = !string.IsNullOrWhiteSpace(productName);

            // Check if the Product ID textbox contains a valid integer
            if (int.TryParse(product_id_txt.Text, out productId))
            {
                searchById = true; // We're searching by ID
            }

            string storedProcedure = "SearchProduct"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        if (searchById)
                        {
                            command.Parameters.AddWithValue("@ProductID", productId);
                        }

                        if (searchByName)
                        {
                            command.Parameters.AddWithValue("@ProductName", productName);
                        }

                        // Execute the command and process results
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the results to the grid
                        inventory_db_view_grid.DataSource = dataTable;

                        // Check if no results were found
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No products found matching the criteria.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void show_table_btn_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}