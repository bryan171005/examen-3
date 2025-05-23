namespace examen_3
{
    partial class ActualizarProducto
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textdescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textfecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btbeliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Producto";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(124, 75);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 1;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(124, 119);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(100, 22);
            this.textnombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // textcantidad
            // 
            this.textcantidad.Location = new System.Drawing.Point(124, 227);
            this.textcantidad.Name = "textcantidad";
            this.textcantidad.Size = new System.Drawing.Size(100, 22);
            this.textcantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(124, 196);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(100, 22);
            this.textprecio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            // 
            // textdescripcion
            // 
            this.textdescripcion.Location = new System.Drawing.Point(124, 160);
            this.textdescripcion.Name = "textdescripcion";
            this.textdescripcion.Size = new System.Drawing.Size(100, 22);
            this.textdescripcion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "descripcion";
            // 
            // textfecha
            // 
            this.textfecha.Location = new System.Drawing.Point(152, 268);
            this.textfecha.Name = "textfecha";
            this.textfecha.Size = new System.Drawing.Size(100, 22);
            this.textfecha.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de registro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "cerrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btbeliminar
            // 
            this.btbeliminar.Location = new System.Drawing.Point(172, 338);
            this.btbeliminar.Name = "btbeliminar";
            this.btbeliminar.Size = new System.Drawing.Size(75, 23);
            this.btbeliminar.TabIndex = 15;
            this.btbeliminar.Text = "Eliminar";
            this.btbeliminar.UseVisualStyleBackColor = true;
            this.btbeliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.btbeliminar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textfecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textdescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarProducto";
            this.Text = "ActualizarProducto";
            this.Load += new System.EventHandler(this.ActualizarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textdescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
     
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btbeliminar;
    }
}