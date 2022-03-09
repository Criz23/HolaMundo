namespace HolaMundo
{
    partial class registro
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPws1 = new System.Windows.Forms.TextBox();
            this.txtPws2 = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.checkBoxPws1 = new System.Windows.Forms.CheckBox();
            this.checkBoxPws2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmar contraseña:";
            // 
            // txtPws1
            // 
            this.txtPws1.Location = new System.Drawing.Point(90, 133);
            this.txtPws1.Name = "txtPws1";
            this.txtPws1.Size = new System.Drawing.Size(269, 20);
            this.txtPws1.TabIndex = 2;
            this.txtPws1.UseSystemPasswordChar = true;
            // 
            // txtPws2
            // 
            this.txtPws2.Location = new System.Drawing.Point(90, 259);
            this.txtPws2.Name = "txtPws2";
            this.txtPws2.Size = new System.Drawing.Size(269, 20);
            this.txtPws2.TabIndex = 3;
            this.txtPws2.UseSystemPasswordChar = true;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(148, 336);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(142, 69);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // checkBoxPws1
            // 
            this.checkBoxPws1.AutoSize = true;
            this.checkBoxPws1.Location = new System.Drawing.Point(90, 159);
            this.checkBoxPws1.Name = "checkBoxPws1";
            this.checkBoxPws1.Size = new System.Drawing.Size(118, 17);
            this.checkBoxPws1.TabIndex = 5;
            this.checkBoxPws1.Text = "Mostrar Contraseña";
            this.checkBoxPws1.UseVisualStyleBackColor = true;
            this.checkBoxPws1.CheckedChanged += new System.EventHandler(this.checkBoxPws1_CheckedChanged);
            // 
            // checkBoxPws2
            // 
            this.checkBoxPws2.AutoSize = true;
            this.checkBoxPws2.Location = new System.Drawing.Point(90, 293);
            this.checkBoxPws2.Name = "checkBoxPws2";
            this.checkBoxPws2.Size = new System.Drawing.Size(118, 17);
            this.checkBoxPws2.TabIndex = 6;
            this.checkBoxPws2.Text = "Mostrar Contraseña";
            this.checkBoxPws2.UseVisualStyleBackColor = true;
            this.checkBoxPws2.CheckedChanged += new System.EventHandler(this.checkBoxPws2_CheckedChanged);
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 442);
            this.Controls.Add(this.checkBoxPws2);
            this.Controls.Add(this.checkBoxPws1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtPws2);
            this.Controls.Add(this.txtPws1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPws1;
        private System.Windows.Forms.TextBox txtPws2;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.CheckBox checkBoxPws1;
        private System.Windows.Forms.CheckBox checkBoxPws2;
    }
}

