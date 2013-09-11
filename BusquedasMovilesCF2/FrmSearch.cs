using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace BusquedasMovilesCF2
{
  public partial class FrmSearch : Form
  {
    private SQLiteConnection _connection;
    private string _sDataSource;
    private SQLiteDataReader sqlReader;

    public FrmSearch()
    {
      InitializeComponent();
    }

    private bool connectDB()
    { 
      _connection = new SQLiteConnection();
      _connection.ConnectionString = "Data Source=" + _sDataSource + ";New=false;Compress=True;Synchronous=Off";
      try
      {
        _connection.Open();
        return true;
      }
      catch (Exception ex)
      {
        System.Console.WriteLine(ex.Message);
        return false;
      }
    }

    private void menuItem1_Click(object sender, EventArgs e)
    {
      openFileDialog1.Filter = "*.sqlite|*.sqlite";
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        _sDataSource = openFileDialog1.FileName;
      }

      bool b = connectDB();
      if (!b)
      {
        MessageBox.Show("Problemas conectando a la BD");
      }
      return;

    }

    private void mnuItemSearch_Click(object sender, EventArgs e)
    {
      if (_connection == null)
      {
        MessageBox.Show("Conectese a una BD");
        return;
      }

      
      try
      {
        SQLiteCommand command;
        command = _connection.CreateCommand();
        String sTabla = "apoyo_logistico";
        String sCampo = "placa";
        ////command.CommandText = "SELECT id, no_localid, barrio_cam, direccion, nombre_com FROM establecimientos_prost";
        string sSQL = "SELECT * FROM " + sTabla + " WHERE " + sCampo + " = ? ";
        //string sSQL2 = "SELECT * FROM FAMILIAS_EN_ACCION WHERE documento like ?  limit 10";
        command.CommandText = sSQL;
        SQLiteParameter param = command.CreateParameter();
        param.Value = txtSearch.Text;
        command.Parameters.Add(param);

        dataGridResult.DataSource = null;
        SQLiteDataReader reader = command.ExecuteReader();
        if (!reader.HasRows)
        {
          //command.Dispose();
          //command = _connection.CreateCommand();
          //command.CommandText = sSQL2;
          //param = command.CreateParameter();
          //param.Value = txtSearch.Text;
          //command.Parameters.Add(param);
          //reader.Close();
          //reader = command.ExecuteReader();
          if (!reader.HasRows)
          {
            MessageBox.Show("no existe informacion para el documento ingresado" );
            return;
          }
        }
        sqlReader = reader;
        
        FillDataset();
      }
      catch (MissingMethodException ex)
      {
        MessageBox.Show("Error creando la conexion. verifique con el administrador.\n" + ex.Message);
        return;
      }                      

    }

    /// <summary>
    /// Llena el objeto Dataset
    /// </summary>
    public void FillDataset()
    {

      int iNumeroColumnas;
      object[] clObjetos;
      DataTable dataTabla = new DataTable();
      DataColumn dataColumn;
      DataRow dataRow = dataTabla.NewRow();

      // Variables para cambiar la apariencia del DataGrid.
      DataGridTableStyle dgTableStyle = new DataGridTableStyle();
      dgTableStyle.MappingName = dataTabla.TableName;
      DataGridColumnStyle colStayle = new DataGridTextBoxColumn();

      while (sqlReader.Read())
      {
        // Se crean las columnas.

        iNumeroColumnas = sqlReader.FieldCount;
        clObjetos = new Object[iNumeroColumnas];

        if (dataTabla.Columns.Count <= 0)
        {
          for (int i = 0; i < iNumeroColumnas; i++)
          {
            dataColumn = new DataColumn();
            dataColumn.ColumnName = sqlReader.GetName(i);
            dataColumn.DataType = Type.GetType("System.String");
            dataColumn.ReadOnly = true;
            dataColumn.AllowDBNull = true;
            dataTabla.Columns.Add(dataColumn);

            colStayle = new DataGridTextBoxColumn();
            colStayle.HeaderText = dataColumn.ColumnName;
            colStayle.MappingName = dataColumn.ColumnName;

            /* Modificamos el ancho de las columnas
             * cuando el Nº de columnas es menor que 3.*/
            if (iNumeroColumnas == 1 && i == 0)
            {
              colStayle.Width = 210;
            }
            else //(iNumeroColumnas==2)
            {
              if (i == 0) colStayle.Width = 50;
              else if (i == 1) colStayle.Width = 150;
              else colStayle.Width = 70;
            }

            dgTableStyle.GridColumnStyles.Add(colStayle);
          }
        }
        sqlReader.GetValues(clObjetos);
        dataTabla.Rows.Add(clObjetos);
      }
      dataGridResult.DataSource = dataTabla;
      Cursor.Current = Cursors.Default;
    }

    private void mnuItemClear_Click(object sender, EventArgs e)
    {
      txtSearch.Text = "";
    }

    private void mnuItemClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }


  }
}