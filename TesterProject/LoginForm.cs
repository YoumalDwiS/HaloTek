using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TesterProject
{
    public partial class LoginForm : Form
    {
        string jabatan;
        string id;
       
        // SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Apotek"].ConnectionString);
        private Form currchildform;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void openChildForm(Form childform)
        {
            currchildform = new LoginForm();
            if (currchildform != null)
            {
                currchildform.Close();
            }
            currchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
           // LoginForm.Controls.Add(childform);
           // panelUtama.Tag = childform;
           // childform.BringToFront();
           // childform.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=MSI; initial catalog=Apotek";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                DataTable st = new DataTable();
                SqlCommand view = new SqlCommand("sp_PwUname", connection);
                view.CommandType = CommandType.StoredProcedure;
                view.Parameters.AddWithValue("username", txtUsername.Text);
                view.Parameters.AddWithValue("password",txtPassword.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(view);
                adapter.Fill(st);
                connection.Close();
                if (st.Rows.Count != 0)
                {
                    if (st.Rows[0][1].ToString() == "0")
                    {
                        MessageBox.Show("Username/Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        id = st.Rows[0][0].ToString();
                        jabatan = st.Rows[0][1].ToString();
                        if (jabatan == "kepala")
                        {
                            login();
                            MessageBox.Show("Selamat datang Bapak/Ibu Kepala Toko", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            openChildForm(new DashKepalaForm());

                        }
                        else if (jabatan == "kasir")
                        {
                            login();
                            MessageBox.Show("Selamat datang Bapak/Ibu Kasir!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            openChildForm(new DashKasirForm());
                        }
                        else if (jabatan == "admin")
                        {
                            login();
                            MessageBox.Show("Selamat datang Bapak/Ibu Admin!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DashAdminForm a = new DashAdminForm();
                            this.Hide();
                            a.Show();
                            //openChildForm(new DashAdminForm());
                        }
                        else
                        {
                            MessageBox.Show("Anda tidak memiliki hak akses login!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Username/password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
        public void clear()
        {
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
           // txtPassword.isP = false;
        }

        public void login()
        {
            string id = "";
            string connectionString = "integrated security=true; data source=MSI; initial catalog=Apotek";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand login = new SqlCommand("sp_Login", connection);
            login.CommandType = CommandType.StoredProcedure;
            login.Parameters.AddWithValue("@id_user", id);
            try
            {
                login.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save pegawai login: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm a = new MainForm();
            this.Hide();
            a.Visible = true;
        }
    }
}
