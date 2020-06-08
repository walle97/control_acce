namespace control_acce
{
    partial class control_acce
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcarr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfechreg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthoraent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txthorasal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idreg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de control:";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(387, 121);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(236, 20);
            this.txtnum.TabIndex = 1;
            this.txtnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnum_KeyPress);
            // 
            // txtnom
            // 
            this.txtnom.Enabled = false;
            this.txtnom.Location = new System.Drawing.Point(387, 159);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(236, 20);
            this.txtnom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtcarr
            // 
            this.txtcarr.Enabled = false;
            this.txtcarr.Location = new System.Drawing.Point(387, 202);
            this.txtcarr.Name = "txtcarr";
            this.txtcarr.Size = new System.Drawing.Size(236, 20);
            this.txtcarr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carrera";
            // 
            // txtfechreg
            // 
            this.txtfechreg.Enabled = false;
            this.txtfechreg.Location = new System.Drawing.Point(387, 240);
            this.txtfechreg.Name = "txtfechreg";
            this.txtfechreg.Size = new System.Drawing.Size(236, 20);
            this.txtfechreg.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de registro:";
            // 
            // txthoraent
            // 
            this.txthoraent.Enabled = false;
            this.txthoraent.Location = new System.Drawing.Point(387, 276);
            this.txthoraent.Name = "txthoraent";
            this.txthoraent.Size = new System.Drawing.Size(236, 20);
            this.txthoraent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora de entrada:";
            // 
            // txthorasal
            // 
            this.txthorasal.Enabled = false;
            this.txthorasal.Location = new System.Drawing.Point(387, 315);
            this.txthorasal.Name = "txthorasal";
            this.txthorasal.Size = new System.Drawing.Size(236, 20);
            this.txthorasal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hora de salida:";
            // 
            // idreg
            // 
            this.idreg.AutoSize = true;
            this.idreg.Location = new System.Drawing.Point(125, 9);
            this.idreg.Name = "idreg";
            this.idreg.Size = new System.Drawing.Size(35, 13);
            this.idreg.TabIndex = 12;
            this.idreg.Text = "label7";
            this.idreg.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(315, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "Control de acceso";
            // 
            // control_acce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 469);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idreg);
            this.Controls.Add(this.txthorasal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txthoraent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfechreg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcarr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Name = "control_acce";
            this.Text = "control_acce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcarr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfechreg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthoraent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthorasal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idreg;
        private System.Windows.Forms.Label label7;
    }
}