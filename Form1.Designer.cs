namespace _1._4_Veterinaria_Dueño_Mascota
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtNombnreMascota = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.Mascotas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCantPerros = new System.Windows.Forms.Label();
            this.lblPorcPerros = new System.Windows.Forms.Label();
            this.lblEdadPromPerros = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblEdadPromGatos = new System.Windows.Forms.Label();
            this.lblCantGatos = new System.Windows.Forms.Label();
            this.lblPorcGatos = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblEdadPromArañas = new System.Windows.Forms.Label();
            this.lblCantArañas = new System.Windows.Forms.Label();
            this.lblPorcArañas = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblEdadPromIguanas = new System.Windows.Forms.Label();
            this.lblCantIguanas = new System.Windows.Forms.Label();
            this.lblPorcIguanas = new System.Windows.Forms.Label();
            this.lblMujeresConIguana = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblHombresConGato = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblNombrePerroMasViejo = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblNombreMascotaMasJoven = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Mascotas.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtNombreDueño);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Dueño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEdad);
            this.groupBox2.Controls.Add(this.txtNombnreMascota);
            this.groupBox2.Controls.Add(this.cboTipo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(286, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos De La Mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Edad";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Araña",
            "Iguana"});
            this.cboTipo.Location = new System.Drawing.Point(82, 105);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 2;
            // 
            // txtNombnreMascota
            // 
            this.txtNombnreMascota.Location = new System.Drawing.Point(82, 69);
            this.txtNombnreMascota.Name = "txtNombnreMascota";
            this.txtNombnreMascota.Size = new System.Drawing.Size(104, 20);
            this.txtNombnreMascota.TabIndex = 1;
            this.txtNombnreMascota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(71, 128);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(69, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(71, 33);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(135, 20);
            this.txtNombreDueño.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(82, 33);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(69, 20);
            this.txtEdad.TabIndex = 0;
            this.txtEdad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtOtro);
            this.groupBox3.Controls.Add(this.rbtFemenino);
            this.groupBox3.Controls.Add(this.rbtMasculino);
            this.groupBox3.Location = new System.Drawing.Point(17, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(12, 19);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(91, 19);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 1;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Location = new System.Drawing.Point(172, 19);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(45, 17);
            this.rbtOtro.TabIndex = 2;
            this.rbtOtro.Text = "Otro";
            this.rbtOtro.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(286, 163);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 37);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Mascotas
            // 
            this.Mascotas.BackColor = System.Drawing.Color.Silver;
            this.Mascotas.Controls.Add(this.label12);
            this.Mascotas.Controls.Add(this.label2);
            this.Mascotas.Controls.Add(this.label7);
            this.Mascotas.Controls.Add(this.label8);
            this.Mascotas.Controls.Add(this.lblEdadPromPerros);
            this.Mascotas.Controls.Add(this.lblCantPerros);
            this.Mascotas.Controls.Add(this.lblPorcPerros);
            this.Mascotas.Location = new System.Drawing.Point(19, 209);
            this.Mascotas.Name = "Mascotas";
            this.Mascotas.Size = new System.Drawing.Size(156, 107);
            this.Mascotas.TabIndex = 3;
            this.Mascotas.TabStop = false;
            this.Mascotas.Text = "Perros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "%";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Edad Promedio";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantPerros
            // 
            this.lblCantPerros.AutoSize = true;
            this.lblCantPerros.Location = new System.Drawing.Point(106, 26);
            this.lblCantPerros.Name = "lblCantPerros";
            this.lblCantPerros.Size = new System.Drawing.Size(13, 13);
            this.lblCantPerros.TabIndex = 0;
            this.lblCantPerros.Text = "0";
            this.lblCantPerros.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorcPerros
            // 
            this.lblPorcPerros.AutoSize = true;
            this.lblPorcPerros.Location = new System.Drawing.Point(106, 55);
            this.lblPorcPerros.Name = "lblPorcPerros";
            this.lblPorcPerros.Size = new System.Drawing.Size(13, 13);
            this.lblPorcPerros.TabIndex = 0;
            this.lblPorcPerros.Text = "0";
            this.lblPorcPerros.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEdadPromPerros
            // 
            this.lblEdadPromPerros.AutoSize = true;
            this.lblEdadPromPerros.Location = new System.Drawing.Point(106, 85);
            this.lblEdadPromPerros.Name = "lblEdadPromPerros";
            this.lblEdadPromPerros.Size = new System.Drawing.Size(13, 13);
            this.lblEdadPromPerros.TabIndex = 0;
            this.lblEdadPromPerros.Text = "0";
            this.lblEdadPromPerros.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Porcentaje";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.lblEdadPromGatos);
            this.groupBox4.Controls.Add(this.lblCantGatos);
            this.groupBox4.Controls.Add(this.lblPorcGatos);
            this.groupBox4.Location = new System.Drawing.Point(188, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 107);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Porcentaje";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cantidad";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(136, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "%";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Edad Promedio";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEdadPromGatos
            // 
            this.lblEdadPromGatos.AutoSize = true;
            this.lblEdadPromGatos.Location = new System.Drawing.Point(105, 85);
            this.lblEdadPromGatos.Name = "lblEdadPromGatos";
            this.lblEdadPromGatos.Size = new System.Drawing.Size(13, 13);
            this.lblEdadPromGatos.TabIndex = 0;
            this.lblEdadPromGatos.Text = "0";
            this.lblEdadPromGatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantGatos
            // 
            this.lblCantGatos.AutoSize = true;
            this.lblCantGatos.Location = new System.Drawing.Point(105, 26);
            this.lblCantGatos.Name = "lblCantGatos";
            this.lblCantGatos.Size = new System.Drawing.Size(13, 13);
            this.lblCantGatos.TabIndex = 0;
            this.lblCantGatos.Text = "0";
            this.lblCantGatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorcGatos
            // 
            this.lblPorcGatos.AutoSize = true;
            this.lblPorcGatos.Location = new System.Drawing.Point(105, 55);
            this.lblPorcGatos.Name = "lblPorcGatos";
            this.lblPorcGatos.Size = new System.Drawing.Size(13, 13);
            this.lblPorcGatos.TabIndex = 0;
            this.lblPorcGatos.Text = "0";
            this.lblPorcGatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.lblEdadPromArañas);
            this.groupBox5.Controls.Add(this.lblCantArañas);
            this.groupBox5.Controls.Add(this.lblPorcArañas);
            this.groupBox5.Location = new System.Drawing.Point(19, 327);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(158, 107);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Araña";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Porcentaje";
            this.label20.Click += new System.EventHandler(this.label1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Cantidad";
            this.label21.Click += new System.EventHandler(this.label1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(135, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "%";
            this.label22.Click += new System.EventHandler(this.label1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 85);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Edad Promedio";
            this.label23.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEdadPromArañas
            // 
            this.lblEdadPromArañas.AutoSize = true;
            this.lblEdadPromArañas.Location = new System.Drawing.Point(104, 85);
            this.lblEdadPromArañas.Name = "lblEdadPromArañas";
            this.lblEdadPromArañas.Size = new System.Drawing.Size(13, 13);
            this.lblEdadPromArañas.TabIndex = 0;
            this.lblEdadPromArañas.Text = "0";
            this.lblEdadPromArañas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantArañas
            // 
            this.lblCantArañas.AutoSize = true;
            this.lblCantArañas.Location = new System.Drawing.Point(104, 26);
            this.lblCantArañas.Name = "lblCantArañas";
            this.lblCantArañas.Size = new System.Drawing.Size(13, 13);
            this.lblCantArañas.TabIndex = 0;
            this.lblCantArañas.Text = "0";
            this.lblCantArañas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorcArañas
            // 
            this.lblPorcArañas.AutoSize = true;
            this.lblPorcArañas.Location = new System.Drawing.Point(104, 55);
            this.lblPorcArañas.Name = "lblPorcArañas";
            this.lblPorcArañas.Size = new System.Drawing.Size(13, 13);
            this.lblPorcArañas.TabIndex = 0;
            this.lblPorcArañas.Text = "0";
            this.lblPorcArañas.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Silver;
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.lblEdadPromIguanas);
            this.groupBox6.Controls.Add(this.lblCantIguanas);
            this.groupBox6.Controls.Add(this.lblPorcIguanas);
            this.groupBox6.Location = new System.Drawing.Point(188, 327);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(158, 107);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Iguana";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 55);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Porcentaje";
            this.label27.Click += new System.EventHandler(this.label1_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Cantidad";
            this.label28.Click += new System.EventHandler(this.label1_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(136, 55);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(15, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "%";
            this.label29.Click += new System.EventHandler(this.label1_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 85);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Edad Promedio";
            this.label30.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEdadPromIguanas
            // 
            this.lblEdadPromIguanas.AutoSize = true;
            this.lblEdadPromIguanas.Location = new System.Drawing.Point(105, 85);
            this.lblEdadPromIguanas.Name = "lblEdadPromIguanas";
            this.lblEdadPromIguanas.Size = new System.Drawing.Size(13, 13);
            this.lblEdadPromIguanas.TabIndex = 0;
            this.lblEdadPromIguanas.Text = "0";
            this.lblEdadPromIguanas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantIguanas
            // 
            this.lblCantIguanas.AutoSize = true;
            this.lblCantIguanas.Location = new System.Drawing.Point(105, 26);
            this.lblCantIguanas.Name = "lblCantIguanas";
            this.lblCantIguanas.Size = new System.Drawing.Size(13, 13);
            this.lblCantIguanas.TabIndex = 0;
            this.lblCantIguanas.Text = "0";
            this.lblCantIguanas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorcIguanas
            // 
            this.lblPorcIguanas.AutoSize = true;
            this.lblPorcIguanas.Location = new System.Drawing.Point(105, 55);
            this.lblPorcIguanas.Name = "lblPorcIguanas";
            this.lblPorcIguanas.Size = new System.Drawing.Size(13, 13);
            this.lblPorcIguanas.TabIndex = 0;
            this.lblPorcIguanas.Text = "0";
            this.lblPorcIguanas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMujeresConIguana
            // 
            this.lblMujeresConIguana.AutoSize = true;
            this.lblMujeresConIguana.Location = new System.Drawing.Point(489, 412);
            this.lblMujeresConIguana.Name = "lblMujeresConIguana";
            this.lblMujeresConIguana.Size = new System.Drawing.Size(13, 13);
            this.lblMujeresConIguana.TabIndex = 0;
            this.lblMujeresConIguana.Text = "0";
            this.lblMujeresConIguana.Click += new System.EventHandler(this.label1_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(370, 412);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(102, 13);
            this.label35.TabIndex = 0;
            this.label35.Text = "Mujeres Con Iguana";
            this.label35.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHombresConGato
            // 
            this.lblHombresConGato.AutoSize = true;
            this.lblHombresConGato.Location = new System.Drawing.Point(489, 439);
            this.lblHombresConGato.Name = "lblHombresConGato";
            this.lblHombresConGato.Size = new System.Drawing.Size(13, 13);
            this.lblHombresConGato.TabIndex = 0;
            this.lblHombresConGato.Text = "0";
            this.lblHombresConGato.Click += new System.EventHandler(this.label1_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(370, 439);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(97, 13);
            this.label37.TabIndex = 0;
            this.label37.Text = "Hombres Con Gato";
            this.label37.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Silver;
            this.groupBox7.Controls.Add(this.lblNombrePerroMasViejo);
            this.groupBox7.Location = new System.Drawing.Point(368, 209);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(232, 186);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Dueño Con Perro Mas Viejo";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // lblNombrePerroMasViejo
            // 
            this.lblNombrePerroMasViejo.AutoSize = true;
            this.lblNombrePerroMasViejo.Location = new System.Drawing.Point(17, 23);
            this.lblNombrePerroMasViejo.Name = "lblNombrePerroMasViejo";
            this.lblNombrePerroMasViejo.Size = new System.Drawing.Size(10, 13);
            this.lblNombrePerroMasViejo.TabIndex = 0;
            this.lblNombrePerroMasViejo.Text = "-";
            this.lblNombrePerroMasViejo.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Silver;
            this.groupBox8.Controls.Add(this.lblNombreMascotaMasJoven);
            this.groupBox8.Location = new System.Drawing.Point(618, 209);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(232, 186);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Dueño Con Mascota Mas Joven";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // lblNombreMascotaMasJoven
            // 
            this.lblNombreMascotaMasJoven.AutoSize = true;
            this.lblNombreMascotaMasJoven.Location = new System.Drawing.Point(17, 28);
            this.lblNombreMascotaMasJoven.Name = "lblNombreMascotaMasJoven";
            this.lblNombreMascotaMasJoven.Size = new System.Drawing.Size(10, 13);
            this.lblNombreMascotaMasJoven.TabIndex = 0;
            this.lblNombreMascotaMasJoven.Text = "-";
            this.lblNombreMascotaMasJoven.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 505);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblHombresConGato);
            this.Controls.Add(this.Mascotas);
            this.Controls.Add(this.lblMujeresConIguana);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Veterinaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Mascotas.ResumeLayout(false);
            this.Mascotas.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombnreMascota;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox Mascotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEdadPromPerros;
        private System.Windows.Forms.Label lblCantPerros;
        private System.Windows.Forms.Label lblPorcPerros;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblEdadPromGatos;
        private System.Windows.Forms.Label lblCantGatos;
        private System.Windows.Forms.Label lblPorcGatos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblEdadPromArañas;
        private System.Windows.Forms.Label lblCantArañas;
        private System.Windows.Forms.Label lblPorcArañas;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblEdadPromIguanas;
        private System.Windows.Forms.Label lblCantIguanas;
        private System.Windows.Forms.Label lblPorcIguanas;
        private System.Windows.Forms.Label lblMujeresConIguana;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblHombresConGato;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblNombrePerroMasViejo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblNombreMascotaMasJoven;
    }
}

