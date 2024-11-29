namespace SG_BIBLIOTECA_CarlosMurilloGomez
{
    partial class FormAdministrarLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label ejemplaresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrarLibros));
            this.lIBROSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.lIBROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet = new SG_BIBLIOTECA_CarlosMurilloGomez.bdDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lIBROSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.gENEROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejemplaresNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caratulaPictureBox = new System.Windows.Forms.PictureBox();
            this.btnCambiarCaratula = new System.Windows.Forms.Button();
            this.lIBROSTableAdapter = new SG_BIBLIOTECA_CarlosMurilloGomez.bdDataSetTableAdapters.LIBROSTableAdapter();
            this.tableAdapterManager = new SG_BIBLIOTECA_CarlosMurilloGomez.bdDataSetTableAdapters.TableAdapterManager();
            this.gENEROSTableAdapter = new SG_BIBLIOTECA_CarlosMurilloGomez.bdDataSetTableAdapters.GENEROSTableAdapter();
            this.ofdCaratula = new System.Windows.Forms.OpenFileDialog();
            this.epCampos = new System.Windows.Forms.ErrorProvider(this.components);
            iSBNLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            ejemplaresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lIBROSBindingNavigator)).BeginInit();
            this.lIBROSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIBROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENEROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemplaresNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(107, 79);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(41, 16);
            iSBNLabel.TabIndex = 1;
            iSBNLabel.Text = "ISBN:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(107, 149);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(43, 16);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "Titulo:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(109, 219);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(41, 16);
            autorLabel.TabIndex = 5;
            autorLabel.Text = "Autor:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(107, 287);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(55, 16);
            generoLabel.TabIndex = 7;
            generoLabel.Text = "Genero:";
            // 
            // ejemplaresLabel
            // 
            ejemplaresLabel.AutoSize = true;
            ejemplaresLabel.Location = new System.Drawing.Point(161, 349);
            ejemplaresLabel.Name = "ejemplaresLabel";
            ejemplaresLabel.Size = new System.Drawing.Size(79, 16);
            ejemplaresLabel.TabIndex = 9;
            ejemplaresLabel.Text = "Ejemplares:";
            // 
            // lIBROSBindingNavigator
            // 
            this.lIBROSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lIBROSBindingNavigator.BindingSource = this.lIBROSBindingSource;
            this.lIBROSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lIBROSBindingNavigator.DeleteItem = null;
            this.lIBROSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lIBROSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lIBROSBindingNavigatorSaveItem});
            this.lIBROSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lIBROSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lIBROSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lIBROSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lIBROSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lIBROSBindingNavigator.Name = "lIBROSBindingNavigator";
            this.lIBROSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lIBROSBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.lIBROSBindingNavigator.TabIndex = 0;
            this.lIBROSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // lIBROSBindingSource
            // 
            this.lIBROSBindingSource.DataMember = "LIBROS";
            this.lIBROSBindingSource.DataSource = this.bdDataSet;
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // lIBROSBindingNavigatorSaveItem
            // 
            this.lIBROSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lIBROSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lIBROSBindingNavigatorSaveItem.Image")));
            this.lIBROSBindingNavigatorSaveItem.Name = "lIBROSBindingNavigatorSaveItem";
            this.lIBROSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.lIBROSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.lIBROSBindingNavigatorSaveItem.Click += new System.EventHandler(this.lIBROSBindingNavigatorSaveItem_Click);
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIBROSBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(192, 76);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(188, 22);
            this.iSBNTextBox.TabIndex = 2;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIBROSBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(192, 146);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(188, 22);
            this.tituloTextBox.TabIndex = 4;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lIBROSBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(194, 216);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(188, 22);
            this.autorTextBox.TabIndex = 6;
            // 
            // generoComboBox
            // 
            this.generoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gENEROSBindingSource, "Nombre", true));
            this.generoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lIBROSBindingSource, "Genero", true));
            this.generoComboBox.DataSource = this.gENEROSBindingSource;
            this.generoComboBox.DisplayMember = "Nombre";
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Location = new System.Drawing.Point(192, 284);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(188, 24);
            this.generoComboBox.TabIndex = 8;
            this.generoComboBox.ValueMember = "Id_genero";
            // 
            // gENEROSBindingSource
            // 
            this.gENEROSBindingSource.DataMember = "GENEROS";
            this.gENEROSBindingSource.DataSource = this.bdDataSet;
            // 
            // ejemplaresNumericUpDown
            // 
            this.ejemplaresNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lIBROSBindingSource, "Ejemplares", true));
            this.ejemplaresNumericUpDown.Location = new System.Drawing.Point(246, 349);
            this.ejemplaresNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ejemplaresNumericUpDown.Name = "ejemplaresNumericUpDown";
            this.ejemplaresNumericUpDown.Size = new System.Drawing.Size(73, 22);
            this.ejemplaresNumericUpDown.TabIndex = 10;
            // 
            // caratulaPictureBox
            // 
            this.caratulaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.lIBROSBindingSource, "Caratula", true));
            this.caratulaPictureBox.Location = new System.Drawing.Point(486, 79);
            this.caratulaPictureBox.Name = "caratulaPictureBox";
            this.caratulaPictureBox.Size = new System.Drawing.Size(190, 195);
            this.caratulaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caratulaPictureBox.TabIndex = 12;
            this.caratulaPictureBox.TabStop = false;
            // 
            // btnCambiarCaratula
            // 
            this.btnCambiarCaratula.Location = new System.Drawing.Point(486, 325);
            this.btnCambiarCaratula.Name = "btnCambiarCaratula";
            this.btnCambiarCaratula.Size = new System.Drawing.Size(190, 23);
            this.btnCambiarCaratula.TabIndex = 13;
            this.btnCambiarCaratula.Text = "CAMBIAR";
            this.btnCambiarCaratula.UseVisualStyleBackColor = true;
            this.btnCambiarCaratula.Click += new System.EventHandler(this.btnCambiarCaratula_Click);
            // 
            // lIBROSTableAdapter
            // 
            this.lIBROSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GENEROSTableAdapter = null;
            this.tableAdapterManager.LIBROSTableAdapter = this.lIBROSTableAdapter;
            this.tableAdapterManager.PRESTAMOSTableAdapter = null;
            this.tableAdapterManager.SOCIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SG_BIBLIOTECA_CarlosMurilloGomez.bdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gENEROSTableAdapter
            // 
            this.gENEROSTableAdapter.ClearBeforeFill = true;
            // 
            // ofdCaratula
            // 
            this.ofdCaratula.Filter = "\"Archivos de imagen\" | *.jpg;*jpeg";
            // 
            // epCampos
            // 
            this.epCampos.ContainerControl = this;
            // 
            // FormAdministrarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCambiarCaratula);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(ejemplaresLabel);
            this.Controls.Add(this.ejemplaresNumericUpDown);
            this.Controls.Add(this.caratulaPictureBox);
            this.Controls.Add(this.lIBROSBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdministrarLibros";
            this.Text = "FormAdministrarLibros";
            this.Load += new System.EventHandler(this.FormAdministrarLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lIBROSBindingNavigator)).EndInit();
            this.lIBROSBindingNavigator.ResumeLayout(false);
            this.lIBROSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIBROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENEROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemplaresNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource lIBROSBindingSource;
        private bdDataSetTableAdapters.LIBROSTableAdapter lIBROSTableAdapter;
        private bdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lIBROSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton lIBROSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.NumericUpDown ejemplaresNumericUpDown;
        private System.Windows.Forms.PictureBox caratulaPictureBox;
        private System.Windows.Forms.Button btnCambiarCaratula;
        private System.Windows.Forms.BindingSource gENEROSBindingSource;
        private bdDataSetTableAdapters.GENEROSTableAdapter gENEROSTableAdapter;
        private System.Windows.Forms.OpenFileDialog ofdCaratula;
        private System.Windows.Forms.ErrorProvider epCampos;
    }
}