namespace AplicaicionPersonasRemotoBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TxtID = new TextBox();
            TxtNombre = new TextBox();
            label2 = new Label();
            TxtTelefono = new TextBox();
            label3 = new Label();
            BtnNuevo = new Button();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            BtnSalir = new Button();
            BtnEliminar = new Button();
            BtnEditar = new Button();
            DgvPersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(113, 11);
            TxtID.MaxLength = 19;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(238, 31);
            TxtID.TabIndex = 2;
            TxtID.KeyPress += TxtID_KeyPress;
            // 
            // TxtNombre
            // 
            TxtNombre.Enabled = false;
            TxtNombre.Location = new Point(113, 60);
            TxtNombre.MaxLength = 100;
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(362, 31);
            TxtNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Enabled = false;
            TxtTelefono.Location = new Point(113, 121);
            TxtTelefono.MaxLength = 100;
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(150, 31);
            TxtTelefono.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 127);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 5;
            label3.Text = "Telefono";
            // 
            // BtnNuevo
            // 
            BtnNuevo.Image = (Image)resources.GetObject("BtnNuevo.Image");
            BtnNuevo.ImageAlign = ContentAlignment.TopCenter;
            BtnNuevo.Location = new Point(30, 190);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(112, 87);
            BtnNuevo.TabIndex = 7;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextAlign = ContentAlignment.BottomCenter;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Enabled = false;
            BtnGuardar.Image = (Image)resources.GetObject("BtnGuardar.Image");
            BtnGuardar.ImageAlign = ContentAlignment.TopCenter;
            BtnGuardar.Location = new Point(151, 190);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(112, 87);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextAlign = ContentAlignment.BottomCenter;
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.ImageAlign = ContentAlignment.TopCenter;
            BtnCancelar.Location = new Point(269, 190);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(112, 87);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancalar";
            BtnCancelar.TextAlign = ContentAlignment.BottomCenter;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.ImageAlign = ContentAlignment.TopCenter;
            BtnSalir.Location = new Point(634, 190);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(112, 87);
            BtnSalir.TabIndex = 12;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.BottomCenter;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Image = (Image)resources.GetObject("BtnEliminar.Image");
            BtnEliminar.ImageAlign = ContentAlignment.TopCenter;
            BtnEliminar.Location = new Point(516, 190);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(112, 87);
            BtnEliminar.TabIndex = 11;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.BottomCenter;
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Image = (Image)resources.GetObject("BtnEditar.Image");
            BtnEditar.ImageAlign = ContentAlignment.TopCenter;
            BtnEditar.Location = new Point(395, 190);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(112, 87);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "Editar";
            BtnEditar.TextAlign = ContentAlignment.BottomCenter;
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // DgvPersonas
            // 
            DgvPersonas.AllowUserToAddRows = false;
            DgvPersonas.AllowUserToDeleteRows = false;
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPersonas.Location = new Point(30, 301);
            DgvPersonas.Name = "DgvPersonas";
            DgvPersonas.ReadOnly = true;
            DgvPersonas.RowHeadersWidth = 62;
            DgvPersonas.Size = new Size(716, 225);
            DgvPersonas.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 540);
            ControlBox = false;
            Controls.Add(DgvPersonas);
            Controls.Add(BtnSalir);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnNuevo);
            Controls.Add(TxtTelefono);
            Controls.Add(label3);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(TxtID);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Personas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox TxtID;
        private TextBox TxtNombre;
        private Label label2;
        private TextBox TxtTelefono;
        private Label label3;
        private Button BtnNuevo;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Button BtnSalir;
        private Button BtnEliminar;
        private Button BtnEditar;
        private DataGridView DgvPersonas;
    }
}
