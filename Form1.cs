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

namespace ADO_TaskLearn
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet data = new DataSet();
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data source = .\SQLEXPRESS; Initial Catalog = TaskLearnPlatform; Integrated security = true;");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            data.Tables.Clear();
            adapter = new SqlDataAdapter("select * from Groups", connection);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            
        }

        private void button_AllStudents_Click(object sender, EventArgs e)
        {
            data.Tables.Clear();
            adapter = new SqlDataAdapter("select * from Students", connection);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
        }

        private void button_AllSubject_Click(object sender, EventArgs e)
        {
            data.Tables.Clear();
            adapter = new SqlDataAdapter("select * from Subjects", connection);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "Update Groups set GroupName = @pGroupName where id = @pId";
                SqlCommand update = new SqlCommand(command, connection);

                update.Parameters.Add(new SqlParameter("@pGroupName", SqlDbType.NVarChar, 50));
                update.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int));

                update.Parameters["@pGroupName"].SourceVersion = DataRowVersion.Current;
                update.Parameters["@pId"].SourceVersion = DataRowVersion.Current;

                update.Parameters["@pGroupName"].SourceColumn = "GroupName";
                update.Parameters["@pId"].SourceColumn = "Id";

                adapter.UpdateCommand = update;
                adapter.Update(data);
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Save2_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "Update Students set FirstName = @pFirstName, LastName = @pLastName, Group_FK = @pGroup_FK where id = @pId";
                SqlCommand update = new SqlCommand(command, connection);

                update.Parameters.Add(new SqlParameter("@pFirstName", SqlDbType.NVarChar, 50));
                update.Parameters.Add(new SqlParameter("@pLastName", SqlDbType.NVarChar, 50));
                update.Parameters.Add(new SqlParameter("@pGroup_FK", SqlDbType.Int));
                update.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int));

                update.Parameters["@pFirstName"].SourceVersion = DataRowVersion.Current;
                update.Parameters["@pLastName"].SourceVersion = DataRowVersion.Current;
                update.Parameters["@pGroup_FK"].SourceVersion = DataRowVersion.Current;
                update.Parameters["@pId"].SourceVersion = DataRowVersion.Current;

                update.Parameters["@pFirstName"].SourceColumn = "FirstName";
                update.Parameters["@pLastName"].SourceColumn = "LastName";
                update.Parameters["@pGroup_FK"].SourceColumn = "Group_FK";
                update.Parameters["@pId"].SourceColumn = "Id";

                adapter.UpdateCommand = update;
                adapter.Update(data);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_Save3_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "Update Subjects set SubjectName = @pSubjectName where id = @pId ";
                SqlCommand sqlCommand = new SqlCommand(command, connection);

                sqlCommand.Parameters.Add(new SqlParameter("@pSubjectName", SqlDbType.NVarChar, 50));
                sqlCommand.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int));

                sqlCommand.Parameters["@pSubjectName"].SourceVersion = DataRowVersion.Current;
                sqlCommand.Parameters["@pId"].SourceVersion = DataRowVersion.Current;

                sqlCommand.Parameters["@pSubjectName"].SourceColumn = "SubjectName";
                sqlCommand.Parameters["@pId"].SourceColumn = "Id";

                adapter.UpdateCommand = sqlCommand;
                adapter.Update(data);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    data.Tables.Clear();
                    adapter = new SqlDataAdapter ("select * from Students order by LastName desc ",connection);
                    adapter.Fill(data);
                    dataGridView1.DataSource = data.Tables[0];
                    break;
                case 1:
                    data.Tables.Clear();
                    adapter = new SqlDataAdapter("select * from Students order by LastName ", connection);
                    adapter.Fill(data);
                    dataGridView1.DataSource = data.Tables[0];
                    break;
                case 2:
                    data.Tables.Clear();
                    adapter = new SqlDataAdapter("select * from Students where Id>3 ", connection);
                    adapter.Fill(data);
                    dataGridView1.DataSource = data.Tables[0];
                    break;                
            }
        }
    }
}
