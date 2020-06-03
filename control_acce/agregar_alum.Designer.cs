namespace control_acce
{
    partial class agregar_alum
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
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtnumtel = new System.Windows.Forms.TextBox();
            this.lblnumTel = new System.Windows.Forms.Label();
            this.lblfechNac = new System.Windows.Forms.Label();
            this.lblcarrera = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcarr = new System.Windows.Forms.ComboBox();
            this.datenac = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(220, 264);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(271, 20);
            this.txtemail.TabIndex = 23;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(88, 265);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(129, 15);
            this.lblemail.TabIndex = 22;
            this.lblemail.Text = "Correo electronico:";
            // 
            // txtnumtel
            // 
            this.txtnumtel.Location = new System.Drawing.Point(220, 228);
            this.txtnumtel.Name = "txtnumtel";
            this.txtnumtel.Size = new System.Drawing.Size(271, 20);
            this.txtnumtel.TabIndex = 21;
            // 
            // lblnumTel
            // 
            this.lblnumTel.AutoSize = true;
            this.lblnumTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumTel.Location = new System.Drawing.Point(78, 229);
            this.lblnumTel.Name = "lblnumTel";
            this.lblnumTel.Size = new System.Drawing.Size(138, 15);
            this.lblnumTel.TabIndex = 20;
            this.lblnumTel.Text = "Numero de telefono:";
            // 
            // lblfechNac
            // 
            this.lblfechNac.AutoSize = true;
            this.lblfechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechNac.Location = new System.Drawing.Point(72, 193);
            this.lblfechNac.Name = "lblfechNac";
            this.lblfechNac.Size = new System.Drawing.Size(145, 15);
            this.lblfechNac.TabIndex = 18;
            this.lblfechNac.Text = "Fecha de nacimiento:";
            // 
            // lblcarrera
            // 
            this.lblcarrera.AutoSize = true;
            this.lblcarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarrera.Location = new System.Drawing.Point(155, 157);
            this.lblcarrera.Name = "lblcarrera";
            this.lblcarrera.Size = new System.Drawing.Size(59, 15);
            this.lblcarrera.TabIndex = 16;
            this.lblcarrera.Text = "Carrera:";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(220, 112);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(274, 20);
            this.txtnom.TabIndex = 15;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.Location = new System.Drawing.Point(152, 113);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(62, 15);
            this.lblnom.TabIndex = 14;
            this.lblnom.Text = "Nombre:";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(220, 74);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(274, 20);
            this.txtnum.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero de control:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtcarr
            // 
            this.txtcarr.FormattingEnabled = true;
            this.txtcarr.Items.AddRange(new object[] {
            "Arquitectura",
            "Administración",
            "Ingeniería Civil",
            "Ingeniería Electrónica",
            "Ingeniería Electromecánica",
            "Ingeniería en Gestión Empresarial",
            "Ingeniería Industrial",
            "Ingeniería Mecatrónica",
            "Ingeniería Petrolera",
            "Ingeniería en Tecnologías de la Información y Comunicaciones"});
            this.txtcarr.Location = new System.Drawing.Point(220, 156);
            this.txtcarr.Name = "txtcarr";
            this.txtcarr.Size = new System.Drawing.Size(274, 21);
            this.txtcarr.TabIndex = 25;
            // 
            // datenac
            // 
            this.datenac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datenac.Location = new System.Drawing.Point(220, 193);
            this.datenac.Name = "datenac";
            this.datenac.Size = new System.Drawing.Size(271, 20);
            this.datenac.TabIndex = 26;
            // 
            // agregar_alum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datenac);
            this.Controls.Add(this.txtcarr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtnumtel);
            this.Controls.Add(this.lblnumTel);
            this.Controls.Add(this.lblfechNac);
            this.Controls.Add(this.lblcarrera);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Name = "agregar_alum";
            this.Text = "agregar_alum";
            this.Load += new System.EventHandler(this.Agregar_alum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtnumtel;
        private System.Windows.Forms.Label lblnumTel;
        private System.Windows.Forms.Label lblfechNac;
        private System.Windows.Forms.Label lblcarrera;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtcarr;
        private System.Windows.Forms.DateTimePicker datenac;
    }
}