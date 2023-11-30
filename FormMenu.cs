using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using ImplementacionFramework1;


namespace autenticacion
{
    public partial class FormMenu : Form
    {
        private string nombreUsuarioLogueado;
        private string nombreEmpresaLogueado;
        private string nombreRolLogueado;
        
        public FormMenu(string nombreUsuario, string nombreEmpresa, string nombreRol)
        {
            InitializeComponent();

            

            MenuStrip menuStrip1 = new MenuStrip();
            this.MainMenuStrip = menuStrip1;
            this.Controls.Add(menuStrip1);

            CargarMenuDinamico();

            nombreUsuarioLogueado = nombreUsuario;
            labelUsrLogueado2.Text = "Bienvenido(a): " + nombreUsuarioLogueado;

            nombreEmpresaLogueado = nombreEmpresa;
            labelNmEmpresa.Text = nombreEmpresaLogueado;

            nombreRolLogueado = nombreRol;
            labelRolEmpresa.Text = nombreRolLogueado;
            
            string connectionString = "Server=DESKTOP-0NF1K3O\\SQLEXPRESS;Database=autenticacion;User ID=sa;Password=admin12345";


        }

        private void CargarMenuDinamico()
        {
            // cadena de conexión
            string connectionString = "Server=DESKTOP-0NF1K3O\\SQLEXPRESS;Database=autenticacion;User ID=sa;Password=admin12345";
            List<Tuple<string, ToolStripMenuItem>> menuItems = new List<Tuple<string, ToolStripMenuItem>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Obtener elementos de menú principales
                string queryElementosMenu = "SELECT IDElementoMenu, Componente FROM ElementosMenu ORDER BY Orden";
                using (SqlCommand cmdElementosMenu = new SqlCommand(queryElementosMenu, connection))
                {
                    using (SqlDataReader readerElementosMenu = cmdElementosMenu.ExecuteReader())
                    {
                        while (readerElementosMenu.Read())
                        {
                            ToolStripMenuItem menuItem = new ToolStripMenuItem(readerElementosMenu["Componente"].ToString());
                            menuStripPrincipal.Items.Add(menuItem);
                            menuItems.Add(new Tuple<string, ToolStripMenuItem>(readerElementosMenu["IDElementoMenu"].ToString(), menuItem));
                        }
                    }
                }
            }

            // Cargar subelementos después de cerrar el readerElementosMenu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var item in menuItems)
                {
                    CargarSubelementosMenu(connection, item.Item1, item.Item2);
}
            }
        }

        private void CargarSubelementosMenu(SqlConnection connection, string elementoMenuID, ToolStripMenuItem menuItem)
        {
            string querySubelementosMenu = "SELECT Componente FROM SubElementosMenu WHERE IDElementoMenu = @IDElementoMenu ORDER BY Orden";
            SqlCommand cmdSubelementosMenu = new SqlCommand(querySubelementosMenu, connection);
            cmdSubelementosMenu.Parameters.AddWithValue("@IDElementoMenu", elementoMenuID);

            using (SqlDataReader readerSubelementosMenu = cmdSubelementosMenu.ExecuteReader())
            {
                while (readerSubelementosMenu.Read())
                {
                    string subMenuName = readerSubelementosMenu["Componente"].ToString();
                    ToolStripMenuItem subMenuItem = new ToolStripMenuItem(subMenuName);

                    subMenuItem.Click += SubMenu_Click;
                    subMenuItem.Tag = subMenuName;

                    menuItem.DropDownItems.Add(subMenuItem);
                }
            }
        }
        private void SubMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem subMenu = sender as ToolStripMenuItem;
            string subMenuName = subMenu.Tag.ToString();

            // Configurar la cadena de conexión
            string connectionString = "Server=DESKTOP-0NF1K3O\\SQLEXPRESS;Database=autenticacion;User ID=sa;Password=admin12345";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Consultar la base de datos para obtener Libreria y Componente basados en subMenuName
                string query = "SELECT Libreria, Componente FROM SubElementosMenu WHERE Componente = @SubMenuName";

                // Crear el comando SQL
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Añadir parámetro
                    cmd.Parameters.AddWithValue("@SubMenuName", subMenuName);

                    // Ejecutar la consulta
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string libreria = reader["Libreria"].ToString();
                            string componente = reader["Componente"].ToString();

                            // Cargar dinámicamente el formulario basado en libreria y componente
                            Form ctrGUI = SmartControl.LoadSmartControl(libreria, componente) as Form;

                            if (ctrGUI != null)
                            {
                                // Mostrar el formulario
                                ctrGUI.Show();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo cargar el formulario: " + subMenuName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Submenú no encontrado en la base de datos: " + subMenuName);
                        }
                    }
                }
            }
        }



        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual (FormPrincipal)
            this.Close();

            // Abre el formulario de inicio de sesión (Form1)
            Form1 form1 = new Form1();
            form1.Show();
        }

        

      

        
    }
}

