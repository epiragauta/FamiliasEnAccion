namespace BusquedasMovilesCF2
{
  partial class FrmSearch
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.MainMenu mainMenu1;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && (components != null))
    //  {
    //    components.Dispose();
    //  }
    //  base.Dispose(disposing);
    //}

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.mnuItemSearch = new System.Windows.Forms.MenuItem();
      this.mnuItemClear = new System.Windows.Forms.MenuItem();
      this.mnuItemOptions = new System.Windows.Forms.MenuItem();
      this.mnuItemOpenDB = new System.Windows.Forms.MenuItem();
      this.mnuItemClose = new System.Windows.Forms.MenuItem();
      this.lblDoc = new System.Windows.Forms.Label();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.dataGridResult = new System.Windows.Forms.DataGrid();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.SuspendLayout();
      // 
      // mainMenu1
      // 
      this.mainMenu1.MenuItems.Add(this.mnuItemSearch);
      this.mainMenu1.MenuItems.Add(this.mnuItemClear);
      this.mainMenu1.MenuItems.Add(this.mnuItemOptions);
      this.mainMenu1.MenuItems.Add(this.mnuItemClose);
      // 
      // mnuItemSearch
      // 
      this.mnuItemSearch.Text = "Buscar";
      this.mnuItemSearch.Click += new System.EventHandler(this.mnuItemSearch_Click);
      // 
      // mnuItemClear
      // 
      this.mnuItemClear.Text = "Borrar";
      this.mnuItemClear.Click += new System.EventHandler(this.mnuItemClear_Click);
      // 
      // mnuItemOptions
      // 
      this.mnuItemOptions.MenuItems.Add(this.mnuItemOpenDB);
      this.mnuItemOptions.Text = "Opciones";
      // 
      // mnuItemOpenDB
      // 
      this.mnuItemOpenDB.Text = "Seleccionar BD";
      this.mnuItemOpenDB.Click += new System.EventHandler(this.menuItem1_Click);
      // 
      // mnuItemClose
      // 
      this.mnuItemClose.Text = "Cerrar";
      this.mnuItemClose.Click += new System.EventHandler(this.mnuItemClose_Click);
      // 
      // lblDoc
      // 
      this.lblDoc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.lblDoc.Location = new System.Drawing.Point(11, 4);
      this.lblDoc.Name = "lblDoc";
      this.lblDoc.Size = new System.Drawing.Size(205, 19);
      this.lblDoc.Text = "Placa:";
      // 
      // txtSearch
      // 
      this.txtSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
      this.txtSearch.Location = new System.Drawing.Point(6, 24);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(229, 23);
      this.txtSearch.TabIndex = 1;
      // 
      // dataGridResult
      // 
      this.dataGridResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.dataGridResult.Location = new System.Drawing.Point(9, 52);
      this.dataGridResult.Name = "dataGridResult";
      this.dataGridResult.Size = new System.Drawing.Size(224, 156);
      this.dataGridResult.TabIndex = 2;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(3, 214);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(50, 51);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(185, 223);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(52, 42);
      // 
      // FrmSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(240, 268);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.dataGridResult);
      this.Controls.Add(this.txtSearch);
      this.Controls.Add(this.lblDoc);
      this.Menu = this.mainMenu1;
      this.Name = "FrmSearch";
      this.Text = "Busquedas";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblDoc;
    private System.Windows.Forms.MenuItem mnuItemSearch;
    private System.Windows.Forms.MenuItem mnuItemClear;
    private System.Windows.Forms.MenuItem mnuItemOptions;
    private System.Windows.Forms.MenuItem mnuItemClose;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.DataGrid dataGridResult;
    private System.Windows.Forms.MenuItem mnuItemOpenDB;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
  }
}

