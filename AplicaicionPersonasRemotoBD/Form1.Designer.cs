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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(151, 190);
            button1.Name = "button1";
            button1.Size = new Size(112, 87);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(269, 190);
            button2.Name = "button2";
            button2.Size = new Size(112, 87);
            button2.TabIndex = 9;
            button2.Text = "Cancalar";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(634, 190);
            button3.Name = "button3";
            button3.Size = new Size(112, 87);
            button3.TabIndex = 12;
            button3.Text = "Salir";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(516, 190);
            button4.Name = "button4";
            button4.Size = new Size(112, 87);
            button4.TabIndex = 11;
            button4.Text = "Eliminar";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(395, 190);
            button5.Name = "button5";
            button5.Size = new Size(112, 87);
            button5.TabIndex = 10;
            button5.Text = "Editar";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(716, 225);
            dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 540);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
    }
}
