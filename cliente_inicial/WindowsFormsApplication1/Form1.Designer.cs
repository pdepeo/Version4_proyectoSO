namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_registro = new System.Windows.Forms.TextBox();
            this.button_registro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password_registro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonconectar = new System.Windows.Forms.Button();
            this.botondesc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.password_login = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.nombre_login = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Invitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // nombre_registro
            // 
            this.nombre_registro.Location = new System.Drawing.Point(151, 30);
            this.nombre_registro.Name = "nombre_registro";
            this.nombre_registro.Size = new System.Drawing.Size(164, 20);
            this.nombre_registro.TabIndex = 3;
            // 
            // button_registro
            // 
            this.button_registro.BackColor = System.Drawing.Color.Silver;
            this.button_registro.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registro.Location = new System.Drawing.Point(163, 133);
            this.button_registro.Name = "button_registro";
            this.button_registro.Size = new System.Drawing.Size(96, 28);
            this.button_registro.TabIndex = 5;
            this.button_registro.Text = "Registrarse";
            this.button_registro.UseVisualStyleBackColor = false;
            this.button_registro.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.password_registro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_registro);
            this.groupBox1.Controls.Add(this.nombre_registro);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 179);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // password_registro
            // 
            this.password_registro.Location = new System.Drawing.Point(151, 97);
            this.password_registro.Name = "password_registro";
            this.password_registro.Size = new System.Drawing.Size(164, 20);
            this.password_registro.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // botonconectar
            // 
            this.botonconectar.BackColor = System.Drawing.Color.DarkGray;
            this.botonconectar.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonconectar.Location = new System.Drawing.Point(65, 36);
            this.botonconectar.Name = "botonconectar";
            this.botonconectar.Size = new System.Drawing.Size(141, 48);
            this.botonconectar.TabIndex = 9;
            this.botonconectar.Text = "Conectar";
            this.botonconectar.UseVisualStyleBackColor = false;
            this.botonconectar.Click += new System.EventHandler(this.botonconectar_Click);
            // 
            // botondesc
            // 
            this.botondesc.BackColor = System.Drawing.Color.DarkGray;
            this.botondesc.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botondesc.Location = new System.Drawing.Point(244, 36);
            this.botondesc.Name = "botondesc";
            this.botondesc.Size = new System.Drawing.Size(141, 48);
            this.botondesc.TabIndex = 10;
            this.botondesc.Text = "Desconectar";
            this.botondesc.UseVisualStyleBackColor = false;
            this.botondesc.Click += new System.EventHandler(this.botondesc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.password_login);
            this.groupBox2.Controls.Add(this.button_login);
            this.groupBox2.Controls.Add(this.nombre_login);
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 179);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Usuario";
            // 
            // password_login
            // 
            this.password_login.Location = new System.Drawing.Point(153, 95);
            this.password_login.Name = "password_login";
            this.password_login.Size = new System.Drawing.Size(164, 20);
            this.password_login.TabIndex = 7;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Silver;
            this.button_login.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(153, 133);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(95, 28);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Iniciar Sesión";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // nombre_login
            // 
            this.nombre_login.Location = new System.Drawing.Point(153, 31);
            this.nombre_login.Name = "nombre_login";
            this.nombre_login.Size = new System.Drawing.Size(164, 20);
            this.nombre_login.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(206, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Enviar Petición";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Partidas ganadas por un jugador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Numero de partidas entre dos jugadores";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(136, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Enviar Petición";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Numero de jugadores registrados";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(136, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Enviar Petición";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 20);
            this.textBox3.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(672, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 269);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(456, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(158, 190);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Conectados";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invitar});
            this.dataGridView2.Location = new System.Drawing.Point(456, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(158, 161);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Invitar
            // 
            this.Invitar.HeaderText = "Invitar a:";
            this.Invitar.Name = "Invitar";
            this.Invitar.ReadOnly = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(501, 447);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Invitar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 507);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.botondesc);
            this.Controls.Add(this.botonconectar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bingo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_registro;
        private System.Windows.Forms.Button button_registro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonconectar;
        private System.Windows.Forms.Button botondesc;
        private System.Windows.Forms.TextBox password_registro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox password_login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox nombre_login;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invitar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}

