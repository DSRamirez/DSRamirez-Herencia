namespace Herencia
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
            this.btDocente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblLeg = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtLeg = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btDocente
            // 
            this.btDocente.Location = new System.Drawing.Point(113, 74);
            this.btDocente.Name = "btDocente";
            this.btDocente.Size = new System.Drawing.Size(75, 23);
            this.btDocente.TabIndex = 0;
            this.btDocente.Text = "Docente";
            this.btDocente.UseVisualStyleBackColor = true;
            this.btDocente.Click += new System.EventHandler(this.btDocente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Alumno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(68, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(68, 176);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            this.lblDNI.Visible = false;
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(68, 216);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(106, 13);
            this.lblFN.TabIndex = 5;
            this.lblFN.Text = "Fecha de nacimiento";
            this.lblFN.Visible = false;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(68, 258);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(31, 13);
            this.lblS.TabIndex = 6;
            this.lblS.Text = "Sexo";
            this.lblS.Visible = false;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(68, 299);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(41, 13);
            this.lblCar.TabIndex = 7;
            this.lblCar.Text = "Carrera";
            this.lblCar.Visible = false;
            // 
            // lblLeg
            // 
            this.lblLeg.AutoSize = true;
            this.lblLeg.Location = new System.Drawing.Point(68, 340);
            this.lblLeg.Name = "lblLeg";
            this.lblLeg.Size = new System.Drawing.Size(39, 13);
            this.lblLeg.TabIndex = 8;
            this.lblLeg.Text = "Legajo";
            this.lblLeg.Visible = false;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(68, 299);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(42, 13);
            this.lblMat.TabIndex = 9;
            this.lblMat.Text = "Materia";
            this.lblMat.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Visible = false;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(244, 169);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(264, 20);
            this.txtDNI.TabIndex = 11;
            this.txtDNI.Visible = false;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(244, 251);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(264, 20);
            this.txtS.TabIndex = 13;
            this.txtS.Visible = false;
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(244, 292);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(264, 20);
            this.txtMat.TabIndex = 14;
            this.txtMat.Visible = false;
            // 
            // txtLeg
            // 
            this.txtLeg.Location = new System.Drawing.Point(244, 333);
            this.txtLeg.Name = "txtLeg";
            this.txtLeg.Size = new System.Drawing.Size(264, 20);
            this.txtLeg.TabIndex = 16;
            this.txtLeg.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 386);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtLeg);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.lblLeg);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btDocente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDocente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblLeg;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtLeg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

