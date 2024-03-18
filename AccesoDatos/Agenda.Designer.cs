namespace AccesoDatos
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtnombre = new TextBox();
            txtdireccion = new TextBox();
            txtmovil = new TextBox();
            txttelefono = new TextBox();
            txtapellido = new TextBox();
            txtcorreo = new TextBox();
            txtfecha = new TextBox();
            btnagregar = new Button();
            btnmodificar = new Button();
            btnbuscar = new Button();
            btneliminar = new Button();
            textnombreBuscar = new TextBox();
            label11 = new Label();
            btnMostrar = new Button();
            dgvTabla = new DataGridView();
            cmbGenero = new ComboBox();
            cmbEstadoCivil = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(417, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 55);
            label1.TabIndex = 0;
            label1.Text = "Agenda Electronica ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 257);
            label4.Name = "label4";
            label4.Size = new Size(175, 60);
            label4.TabIndex = 3;
            label4.Text = "Fecha de \r\nnacimiento:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(231, 99);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 4;
            label5.Text = "Dirección:";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(231, 187);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 5;
            label6.Text = "Genero:";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(231, 280);
            label7.Name = "label7";
            label7.Size = new Size(142, 25);
            label7.TabIndex = 6;
            label7.Text = "Estado civil:";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(427, 253);
            label8.Name = "label8";
            label8.Size = new Size(175, 64);
            label8.TabIndex = 9;
            label8.Text = "Correo \r\nElectronico:";
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(427, 187);
            label9.Name = "label9";
            label9.Size = new Size(142, 25);
            label9.TabIndex = 8;
            label9.Text = "Telefono:";
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(427, 99);
            label10.Name = "label10";
            label10.Size = new Size(142, 25);
            label10.TabIndex = 7;
            label10.Text = "Móvil:";
            label10.Click += label10_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(12, 136);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(175, 27);
            txtnombre.TabIndex = 10;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(231, 136);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(175, 27);
            txtdireccion.TabIndex = 11;
            // 
            // txtmovil
            // 
            txtmovil.Location = new Point(427, 136);
            txtmovil.Name = "txtmovil";
            txtmovil.Size = new Size(175, 27);
            txtmovil.TabIndex = 12;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(427, 230);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(179, 27);
            txttelefono.TabIndex = 15;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(12, 230);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(175, 27);
            txtapellido.TabIndex = 13;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(427, 320);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(175, 27);
            txtcorreo.TabIndex = 18;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(12, 320);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(175, 27);
            txtfecha.TabIndex = 16;
            // 
            // btnagregar
            // 
            btnagregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnagregar.BackColor = Color.White;
            btnagregar.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btnagregar.FlatAppearance.BorderSize = 2;
            btnagregar.FlatAppearance.MouseDownBackColor = Color.White;
            btnagregar.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnagregar.ForeColor = SystemColors.ActiveCaptionText;
            btnagregar.Image = (Image)resources.GetObject("btnagregar.Image");
            btnagregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregar.Location = new Point(25, 371);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(175, 55);
            btnagregar.TabIndex = 19;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.BackColor = Color.White;
            btnmodificar.FlatAppearance.BorderColor = Color.Cyan;
            btnmodificar.FlatAppearance.BorderSize = 2;
            btnmodificar.FlatStyle = FlatStyle.Flat;
            btnmodificar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnmodificar.ForeColor = Color.Black;
            btnmodificar.Image = (Image)resources.GetObject("btnmodificar.Image");
            btnmodificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnmodificar.Location = new Point(232, 371);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(176, 55);
            btnmodificar.TabIndex = 20;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = false;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.White;
            btnbuscar.FlatAppearance.BorderColor = Color.Cyan;
            btnbuscar.FlatAppearance.BorderSize = 2;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.Image = (Image)resources.GetObject("btnbuscar.Image");
            btnbuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnbuscar.Location = new Point(232, 450);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(176, 62);
            btnbuscar.TabIndex = 21;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.White;
            btneliminar.FlatAppearance.BorderColor = Color.Cyan;
            btneliminar.FlatAppearance.BorderSize = 2;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btneliminar.ForeColor = Color.Black;
            btneliminar.Image = (Image)resources.GetObject("btneliminar.Image");
            btneliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btneliminar.Location = new Point(427, 371);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(176, 55);
            btneliminar.TabIndex = 22;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // textnombreBuscar
            // 
            textnombreBuscar.Location = new Point(25, 491);
            textnombreBuscar.Name = "textnombreBuscar";
            textnombreBuscar.Size = new Size(176, 27);
            textnombreBuscar.TabIndex = 24;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(25, 450);
            label11.Name = "label11";
            label11.Size = new Size(176, 25);
            label11.TabIndex = 23;
            label11.Text = "Buscar Por ID:";
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.White;
            btnMostrar.FlatAppearance.BorderColor = Color.Cyan;
            btnMostrar.FlatAppearance.BorderSize = 2;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrar.ForeColor = Color.Black;
            btnMostrar.Image = (Image)resources.GetObject("btnMostrar.Image");
            btnMostrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrar.Location = new Point(427, 446);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(176, 62);
            btnMostrar.TabIndex = 26;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dgvTabla
            // 
            dgvTabla.AllowDrop = true;
            dgvTabla.AllowUserToOrderColumns = true;
            dgvTabla.BackgroundColor = Color.RoyalBlue;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvTabla.DefaultCellStyle = dataGridViewCellStyle5;
            dgvTabla.GridColor = Color.FromArgb(0, 0, 192);
            dgvTabla.Location = new Point(612, 130);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.ReadOnly = true;
            dgvTabla.RightToLeft = RightToLeft.No;
            dgvTabla.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvTabla.RowTemplate.Height = 29;
            dgvTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabla.Size = new Size(466, 378);
            dgvTabla.TabIndex = 27;
            dgvTabla.CellClick += tbTabla_CellContentClick;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Femenino", "Masculino", "Prefiero no decirlo" });
            cmbGenero.Location = new Point(231, 229);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(175, 28);
            cmbGenero.TabIndex = 28;
            cmbGenero.SelectedIndexChanged += cmbGenero_SelectedIndexChanged;
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Items.AddRange(new object[] { "Soltero/a", "Casado/a", "Divorciado/a", "Viudo/a" });
            cmbEstadoCivil.Location = new Point(232, 320);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(175, 28);
            cmbEstadoCivil.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1096, 545);
            Controls.Add(pictureBox1);
            Controls.Add(cmbEstadoCivil);
            Controls.Add(cmbGenero);
            Controls.Add(dgvTabla);
            Controls.Add(btnMostrar);
            Controls.Add(textnombreBuscar);
            Controls.Add(label11);
            Controls.Add(btneliminar);
            Controls.Add(btnbuscar);
            Controls.Add(btnmodificar);
            Controls.Add(btnagregar);
            Controls.Add(txtcorreo);
            Controls.Add(txtfecha);
            Controls.Add(txttelefono);
            Controls.Add(txtapellido);
            Controls.Add(txtmovil);
            Controls.Add(txtdireccion);
            Controls.Add(txtnombre);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Agenda";
            RightToLeft = RightToLeft.No;
            Text = "Agenda";
            Load += Agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtnombre;
        private TextBox txtdireccion;
        private TextBox txtmovil;
        private TextBox txttelefono;
        private TextBox txtapellido;
        private TextBox txtcorreo;
        private TextBox txtfecha;
        private Button btnagregar;
        private Button btnmodificar;
        private Button btnbuscar;
        private Button btneliminar;
        private TextBox textnombreBuscar;
        private Label label11;
        private Button btnMostrar;
        private DataGridView dgvTabla;
        private ComboBox cmbGenero;
        private ComboBox cmbEstadoCivil;
        private PictureBox pictureBox1;
    }
}