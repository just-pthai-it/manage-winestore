using ManageWineStore.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageWineStore.app.Controllers.ModelControllers.Abastract
{
    abstract class AModelController<T>
    {
        protected DatabaseConnector databaseConnector;

        protected AModelController()
        {
            this.databaseConnector = new DatabaseConnector();
        }

        protected DataTable executeQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            try
            {
                databaseConnector.OpenConnect();
                SqlCommand command = new SqlCommand(query, databaseConnector.SqlConnect);
                if (parameters != null)
                {
                    string[] placeHolders = query.Split(' ');
                    int i = 0;
                    foreach (string item in placeHolders)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i] ?? DBNull.Value);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                databaseConnector.CloseConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return data;
        }

        protected int executeNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            try
            {
                databaseConnector.OpenConnect();
                SqlCommand command = new SqlCommand(query, databaseConnector.SqlConnect);
                if (parameters != null)
                {
                    string[] placeHolders = query.Split(' ');
                    int i = 0;
                    foreach (string item in placeHolders)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i] ?? DBNull.Value);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                databaseConnector.CloseConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        protected object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;
            try
            {
                databaseConnector.OpenConnect();
                SqlCommand command = new SqlCommand(query, databaseConnector.SqlConnect);
                if (parameters != null)
                {
                    string[] placeHolders = query.Split(' ');
                    int i = 0;
                    foreach (string item in placeHolders)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameters[i] ?? DBNull.Value);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                databaseConnector.CloseConnect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public abstract void insert(T obj);

        public abstract DataTable find(string id);

        public abstract DataTable findAll();

        public abstract void update(T obj);

        public abstract void delete(string id);

    }
}
