using AgendaContactos.GUI;
using AgendaContactos.GUI.Contactos;
// Importante: Esto le dice al programa que busque dentro de tu carpeta de Contactos
using GUI.Contactos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

      // CONFIGURACIÓN PROFESIONAL
      this.IsMdiContainer = true; // Permite que las ventanas se abran adentro
      this.WindowState = FormWindowState.Maximized; // Abre en pantalla completa
      this.Text = "Smart Contacts - Agenda de Contactos";
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    //  MENÚ ARCHIVO

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("¿Estás seguro de que deseas salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
      {
        Application.Exit();
      }
    }

    //  MENÚ CONTACTOS (REDIRECCIONES)


    // 1. Ver Lista
    private void listaDeContactosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmListaContactos frm = new FrmListaContactos();
      frm.MdiParent = this;
      frm.Show();
    }

    // 2. Agregar Nuevo
    private void agregarContactoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmAgregarContacto frm = new FrmAgregarContacto();
      frm.MdiParent = this;
      frm.Show();
    }

    // 3. Buscar
    private void buscarContactoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmBuscarContacto frm = new FrmBuscarContacto();
      frm.MdiParent = this;
      frm.Show();
    }

    // 4. Editar (Agregado)
    private void editarContactoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmEditarContacto frm = new FrmEditarContacto();
      frm.MdiParent = this;
      frm.Show();
    }

    // 5. Eliminar (Agregado)
    private void eliminarContactoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmEliminarContacto frm = new FrmEliminarContacto();
      frm.MdiParent = this;
      frm.Show();
    }

    // ==========================================
    //  MENÚ OTROS / AYUDA
    // ==========================================
    private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Smart Contacts v1.0\n\n" +
              "Sistema de Gestión de Contactos\n\n" +
              "Proyecto Académico UNAB - 2026",
              "Acerca de Smart Contacts",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      // Se deja vacío para evitar errores del diseñador visual
    }


    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      // Esto mata el proceso completo de la agenda
      Application.Exit();
    }

    private void MainForm_Load_1(object sender, EventArgs e)
    {
      // Esto busca el contenedor gris y le pega tu imagen de fondo
      foreach (Control ctl in this.Controls)
      {
        if (ctl is MdiClient)
        {
          ctl.BackgroundImage = this.BackgroundImage;
          ctl.BackgroundImageLayout = ImageLayout.Stretch;
          break;
        }
      }
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void respaldoDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Módulo de Seguridad: Registro de eventos activo. Los registros se están almacenando en la base de datos.", "Bitácora", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
      LoginForm Login = new LoginForm();
    }

    private void respaldoDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      try
      {
        // 1. Verificamos si existe la carpeta C:\temp y si no, la creamos
        string carpeta = @"C:\temp";
        if (!System.IO.Directory.Exists(carpeta))
        {
          System.IO.Directory.CreateDirectory(carpeta);
        }

        string nombreBackup = "Backup_Agenda_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".bak";
        string rutaCompleta = System.IO.Path.Combine(carpeta, nombreBackup);

        // 2. Comando SQL (Asegurate que tu base se llame AgendaContactos)
        string comando = $"BACKUP DATABASE [AgendaContactos] TO DISK = '{rutaCompleta}'";

        DAL.Conexion conector = new DAL.Conexion();
        using (SqlConnection conn = DAL.Conexion.ObtenerConexion())
        {
          SqlCommand cmd = new SqlCommand(comando, conn);
          conn.Open();
          cmd.ExecuteNonQuery();
          MessageBox.Show("¡Respaldo creado con éxito en " + rutaCompleta + "!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al respaldar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void restaurarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        // 1. Pedir al usuario que elija el archivo .bak
        OpenFileDialog buscar = new OpenFileDialog();
        buscar.Filter = "Archivos de Respaldo (*.bak)|*.bak";
        buscar.Title = "Seleccione el archivo de restauración";

        if (buscar.ShowDialog() == DialogResult.OK)
        {
          string rutaArchivo = buscar.FileName;

          // 2. Comando SQL para restaurar usando la base 'master' para que no de error de "base en uso"
          // Cambiamos el nombre de la base si es necesario
          string dbNombre = "AgendaContactos";
          string sql = $"USE master; ALTER DATABASE [{dbNombre}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                $"RESTORE DATABASE [{dbNombre}] FROM DISK = '{rutaArchivo}' WITH REPLACE; " +
                $"ALTER DATABASE [{dbNombre}] SET MULTI_USER;";

          DAL.Conexion conector = new DAL.Conexion();
          using (SqlConnection conn = DAL.Conexion.ObtenerConexion())
          {
            // Cambiamos la conexión temporalmente a master
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("¡Base de Datos restaurada con éxito!", "Proceso Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al restaurar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      // Doble clic en Configuración del Servidor
      MessageBox.Show("Para cambiar el servidor, edite el archivo 'Conexion.cs' en la capa DAL.\nServidor actual: .\\SQL", "Configuración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void gestionarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // 1. Creamos la instancia del formulario
      Categorias.FrmGestionarCategorias frm = new Categorias.FrmGestionarCategorias();

      // 2. Lo mostramos como una ventana emergente
      frm.ShowDialog();
    }

    private void verEstadisticaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        // Usamos tu clase Conexion de la capa DAL que ya arreglamos
        DAL.Conexion conector = new DAL.Conexion();

        // PEGA ESTA LÍNEA:
        using (SqlConnection conn = DAL.Conexion.ObtenerConexion())
        {
          // Este comando cuenta cuántas filas hay en tu tabla de contactos
          string sql = "SELECT COUNT(*) FROM Contactos";

          SqlCommand cmd = new SqlCommand(sql, conn);

          conn.Open();

          // Ejecutamos y guardamos el número
          int total = (int)cmd.ExecuteScalar();

          // Mostramos el mensaje profesional
          MessageBox.Show("RESUMEN DE LA BASE DE DATOS\n\n" +
             "Total de contactos registrados: " + total + "\n" +
             "Estado del Servidor: En línea",
             "Estadísticas del Sistema",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        // Por si el SQL está apagado o la tabla se llama diferente
        MessageBox.Show("Error al conectar con SQL Server: " + ex.Message,
            "Error de Conexión",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
      }
    }

    private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        System.Diagnostics.Process.Start("calc.exe");
      }
      catch (Exception ex)
      {
        MessageBox.Show("No se pudo abrir la calculadora: " + ex.Message);
      }
    }

    private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        // Este comando abre la ventana de configuración de Fecha y Hora de Windows
        System.Diagnostics.Process.Start("control", "timedate.cpl");
      }
      catch (Exception ex)
      {
        MessageBox.Show("No se pudo abrir el calendario del sistema: " + ex.Message);
      }
    }


    private void acercaDeSmartContactsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Smart Contacts v1.0\n\n" +
          "EQUIPO DE DESARROLLO:\n" +
          "• María Guadalupe Canjura Díaz\n" +
          "• Mallerli Yamileth Ventura Escobar\n" +
          "• José Angel Gutierrez Cortez\n" +
          "• Luis Ángel Escobar Leiva\n" +
          "• Noe Steve Mejía Hernández\n\n" +
          "Ingeniería de Sistemas - Universidad Dr. Andrés Bello\n" +
          "© 2026 Todos los derechos reservados.",
          "Información del Equipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void manualDeUusuarioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Código para mostrar el Manual de Usuario en pantalla
      string manual = @"MANUAL DE USUARIO: SMART CONTACTS v1.0
--------------------------------------------------
DESARROLLADORES (UNAB):
1. María Guadalupe Canjura Díaz
2. Mallerli Yamileth Ventura Escobar
3. José Angel Gutierrez Cortez
4. Luis Ángel Escobar Leiva
5. Noe Steve Mejía Hernández
--------------------------------------------------

1. INICIO DE SESIÓN:
Ingrese su usuario y contraseña en la pantalla de bienvenida. 
Si es nuevo usuario, use las credenciales por defecto.

2. GESTIÓN DE CONTACTOS:
Vaya al menú 'Contactos' para ver la lista completa. 
Desde ahí puede Agregar, Editar, Buscar o Eliminar registros.

3. RESPALDOS (SEGURIDAD):
En el menú 'Archivo' encontrará las opciones de Backup. 
Se recomienda crear un respaldo semanal de su información.

4. HERRAMIENTAS:
El sistema incluye acceso rápido a Calculadora y Calendario 
para facilitar su trabajo diario.

5. SOPORTE TÉCNICO:
Para errores de conexión, verifique la configuración del 
servidor en el menú Archivo.";

      MessageBox.Show(manual, "Manual de Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Question);
    }
  }

}
