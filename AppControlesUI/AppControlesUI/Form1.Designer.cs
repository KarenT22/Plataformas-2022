namespace AppControlesUI
{
    partial class FrmControles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControles));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblNavegador = new System.Windows.Forms.Label();
            this.chkGoogle = new System.Windows.Forms.CheckBox();
            this.chkOpera = new System.Windows.Forms.CheckBox();
            this.chkMicrosoft = new System.Windows.Forms.CheckBox();
            this.rd800 = new System.Windows.Forms.RadioButton();
            this.rd1024 = new System.Windows.Forms.RadioButton();
            this.rd1280 = new System.Windows.Forms.RadioButton();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.cmbRojo = new System.Windows.Forms.ComboBox();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.cmbVerde = new System.Windows.Forms.ComboBox();
            this.lblAzul = new System.Windows.Forms.Label();
            this.cmbAzul = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.imgFotos = new System.Windows.Forms.PictureBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnMostrarFecha = new System.Windows.Forms.Button();
            this.rtbBiografia = new System.Windows.Forms.RichTextBox();
            this.lblBiografia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(48, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(115, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnMostrar.Location = new System.Drawing.Point(51, 311);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblNavegador
            // 
            this.lblNavegador.AutoSize = true;
            this.lblNavegador.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavegador.Location = new System.Drawing.Point(48, 74);
            this.lblNavegador.Name = "lblNavegador";
            this.lblNavegador.Size = new System.Drawing.Size(139, 16);
            this.lblNavegador.TabIndex = 6;
            this.lblNavegador.Text = "Navegador Favorito:";
            // 
            // chkGoogle
            // 
            this.chkGoogle.AutoSize = true;
            this.chkGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGoogle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGoogle.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkGoogle.Location = new System.Drawing.Point(51, 104);
            this.chkGoogle.Name = "chkGoogle";
            this.chkGoogle.Size = new System.Drawing.Size(96, 17);
            this.chkGoogle.TabIndex = 7;
            this.chkGoogle.Text = "Google Chrome";
            this.chkGoogle.UseVisualStyleBackColor = true;
            // 
            // chkOpera
            // 
            this.chkOpera.AutoSize = true;
            this.chkOpera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOpera.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOpera.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkOpera.Location = new System.Drawing.Point(51, 127);
            this.chkOpera.Name = "chkOpera";
            this.chkOpera.Size = new System.Drawing.Size(53, 17);
            this.chkOpera.TabIndex = 8;
            this.chkOpera.Text = "Opera";
            this.chkOpera.UseVisualStyleBackColor = true;
            // 
            // chkMicrosoft
            // 
            this.chkMicrosoft.AutoSize = true;
            this.chkMicrosoft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMicrosoft.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMicrosoft.ForeColor = System.Drawing.Color.SteelBlue;
            this.chkMicrosoft.Location = new System.Drawing.Point(51, 150);
            this.chkMicrosoft.Name = "chkMicrosoft";
            this.chkMicrosoft.Size = new System.Drawing.Size(94, 17);
            this.chkMicrosoft.TabIndex = 9;
            this.chkMicrosoft.Text = "Microsoft Edge";
            this.chkMicrosoft.UseVisualStyleBackColor = true;
            // 
            // rd800
            // 
            this.rd800.AutoSize = true;
            this.rd800.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rd800.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd800.ForeColor = System.Drawing.Color.SteelBlue;
            this.rd800.Location = new System.Drawing.Point(309, 104);
            this.rd800.Name = "rd800";
            this.rd800.Size = new System.Drawing.Size(72, 17);
            this.rd800.TabIndex = 10;
            this.rd800.TabStop = true;
            this.rd800.Text = "800 x 600";
            this.rd800.UseVisualStyleBackColor = true;
            // 
            // rd1024
            // 
            this.rd1024.AutoSize = true;
            this.rd1024.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rd1024.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1024.ForeColor = System.Drawing.Color.SteelBlue;
            this.rd1024.Location = new System.Drawing.Point(309, 127);
            this.rd1024.Name = "rd1024";
            this.rd1024.Size = new System.Drawing.Size(78, 17);
            this.rd1024.TabIndex = 11;
            this.rd1024.TabStop = true;
            this.rd1024.Text = "1024 x 768";
            this.rd1024.UseVisualStyleBackColor = true;
            // 
            // rd1280
            // 
            this.rd1280.AutoSize = true;
            this.rd1280.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rd1280.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1280.ForeColor = System.Drawing.Color.SteelBlue;
            this.rd1280.Location = new System.Drawing.Point(309, 150);
            this.rd1280.Name = "rd1280";
            this.rd1280.Size = new System.Drawing.Size(78, 17);
            this.rd1280.TabIndex = 12;
            this.rd1280.TabStop = true;
            this.rd1280.Text = "1280 x 720";
            this.rd1280.UseVisualStyleBackColor = true;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolucion.Location = new System.Drawing.Point(306, 74);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(81, 16);
            this.lblResolucion.TabIndex = 13;
            this.lblResolucion.Text = "Resolución:";
            this.lblResolucion.Click += new System.EventHandler(this.lblResolucion_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCambiar.Location = new System.Drawing.Point(132, 311);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(143, 23);
            this.btnCambiar.TabIndex = 14;
            this.btnCambiar.Text = "Cambiar Resolución";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // cmbRojo
            // 
            this.cmbRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRojo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRojo.FormattingEnabled = true;
            this.cmbRojo.Location = new System.Drawing.Point(115, 182);
            this.cmbRojo.Name = "cmbRojo";
            this.cmbRojo.Size = new System.Drawing.Size(266, 21);
            this.cmbRojo.TabIndex = 15;
            this.cmbRojo.SelectedIndexChanged += new System.EventHandler(this.cmbRojo_SelectedIndexChanged);
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRojo.Location = new System.Drawing.Point(48, 184);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(41, 16);
            this.lblRojo.TabIndex = 16;
            this.lblRojo.Text = "Rojo:";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde.Location = new System.Drawing.Point(48, 211);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(51, 16);
            this.lblVerde.TabIndex = 18;
            this.lblVerde.Text = "Verde:";
            // 
            // cmbVerde
            // 
            this.cmbVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVerde.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVerde.FormattingEnabled = true;
            this.cmbVerde.Location = new System.Drawing.Point(115, 209);
            this.cmbVerde.Name = "cmbVerde";
            this.cmbVerde.Size = new System.Drawing.Size(266, 21);
            this.cmbVerde.TabIndex = 17;
            this.cmbVerde.SelectedIndexChanged += new System.EventHandler(this.cmbVerde_SelectedIndexChanged);
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzul.Location = new System.Drawing.Point(48, 238);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(40, 16);
            this.lblAzul.TabIndex = 20;
            this.lblAzul.Text = "Azul:";
            // 
            // cmbAzul
            // 
            this.cmbAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAzul.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAzul.FormattingEnabled = true;
            this.cmbAzul.Location = new System.Drawing.Point(115, 236);
            this.cmbAzul.Name = "cmbAzul";
            this.cmbAzul.Size = new System.Drawing.Size(266, 21);
            this.cmbAzul.TabIndex = 19;
            this.cmbAzul.SelectedIndexChanged += new System.EventHandler(this.cmbAzul_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnColor.Location = new System.Drawing.Point(281, 311);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(106, 23);
            this.btnColor.TabIndex = 21;
            this.btnColor.Text = "Cambiar Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // imgFotos
            // 
            this.imgFotos.Image = ((System.Drawing.Image)(resources.GetObject("imgFotos.Image")));
            this.imgFotos.Location = new System.Drawing.Point(417, 35);
            this.imgFotos.Name = "imgFotos";
            this.imgFotos.Size = new System.Drawing.Size(188, 132);
            this.imgFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFotos.TabIndex = 22;
            this.imgFotos.TabStop = false;
            this.imgFotos.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(408, 182);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(206, 20);
            this.dtpFechaNac.TabIndex = 23;
            // 
            // btnMostrarFecha
            // 
            this.btnMostrarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFecha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarFecha.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnMostrarFecha.Location = new System.Drawing.Point(408, 211);
            this.btnMostrarFecha.Name = "btnMostrarFecha";
            this.btnMostrarFecha.Size = new System.Drawing.Size(104, 23);
            this.btnMostrarFecha.TabIndex = 24;
            this.btnMostrarFecha.Text = "Mostrar Fecha";
            this.btnMostrarFecha.UseVisualStyleBackColor = true;
            this.btnMostrarFecha.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbBiografia
            // 
            this.rtbBiografia.Location = new System.Drawing.Point(408, 263);
            this.rtbBiografia.Name = "rtbBiografia";
            this.rtbBiografia.Size = new System.Drawing.Size(206, 71);
            this.rtbBiografia.TabIndex = 25;
            this.rtbBiografia.Text = "";
            // 
            // lblBiografia
            // 
            this.lblBiografia.AutoSize = true;
            this.lblBiografia.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiografia.Location = new System.Drawing.Point(405, 244);
            this.lblBiografia.Name = "lblBiografia";
            this.lblBiografia.Size = new System.Drawing.Size(69, 16);
            this.lblBiografia.TabIndex = 26;
            this.lblBiografia.Text = "Biografía:";
            // 
            // FrmControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 367);
            this.Controls.Add(this.lblBiografia);
            this.Controls.Add(this.rtbBiografia);
            this.Controls.Add(this.btnMostrarFecha);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.imgFotos);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.cmbAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.cmbVerde);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.cmbRojo);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.rd1280);
            this.Controls.Add(this.rd1024);
            this.Controls.Add(this.rd800);
            this.Controls.Add(this.chkMicrosoft);
            this.Controls.Add(this.chkOpera);
            this.Controls.Add(this.chkGoogle);
            this.Controls.Add(this.lblNavegador);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmControles";
            this.Text = "Interfaz UI";
            this.Load += new System.EventHandler(this.FrmControles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblNavegador;
        private System.Windows.Forms.CheckBox chkGoogle;
        private System.Windows.Forms.CheckBox chkOpera;
        private System.Windows.Forms.CheckBox chkMicrosoft;
        private System.Windows.Forms.RadioButton rd800;
        private System.Windows.Forms.RadioButton rd1024;
        private System.Windows.Forms.RadioButton rd1280;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.ComboBox cmbRojo;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.ComboBox cmbVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.ComboBox cmbAzul;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox imgFotos;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button btnMostrarFecha;
        private System.Windows.Forms.RichTextBox rtbBiografia;
        private System.Windows.Forms.Label lblBiografia;
    }
}

