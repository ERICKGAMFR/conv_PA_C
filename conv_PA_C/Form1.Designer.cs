
namespace conv_PA_C
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
            this.lbt = new System.Windows.Forms.Label();
            this.lbcel = new System.Windows.Forms.Label();
            this.lbfar = new System.Windows.Forms.Label();
            this.tbcel = new System.Windows.Forms.TextBox();
            this.tbfar = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncel = new System.Windows.Forms.Button();
            this.btnfar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbt
            // 
            this.lbt.AutoSize = true;
            this.lbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbt.Location = new System.Drawing.Point(213, 44);
            this.lbt.Name = "lbt";
            this.lbt.Size = new System.Drawing.Size(373, 25);
            this.lbt.TabIndex = 0;
            this.lbt.Text = "\"CONVERSOR DE TEMPERATURA \"";
            // 
            // lbcel
            // 
            this.lbcel.AutoSize = true;
            this.lbcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcel.Location = new System.Drawing.Point(97, 114);
            this.lbcel.Name = "lbcel";
            this.lbcel.Size = new System.Drawing.Size(172, 20);
            this.lbcel.TabIndex = 1;
            this.lbcel.Text = "GRADOS CELSIUS";
            // 
            // lbfar
            // 
            this.lbfar.AutoSize = true;
            this.lbfar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfar.Location = new System.Drawing.Point(491, 114);
            this.lbfar.Name = "lbfar";
            this.lbfar.Size = new System.Drawing.Size(210, 20);
            this.lbfar.TabIndex = 2;
            this.lbfar.Text = "GRADOS FARENHEINT";
            // 
            // tbcel
            // 
            this.tbcel.Location = new System.Drawing.Point(101, 137);
            this.tbcel.Name = "tbcel";
            this.tbcel.Size = new System.Drawing.Size(168, 22);
            this.tbcel.TabIndex = 3;
            // 
            // tbfar
            // 
            this.tbfar.Location = new System.Drawing.Point(518, 137);
            this.tbfar.Name = "tbfar";
            this.tbfar.Size = new System.Drawing.Size(168, 22);
            this.tbfar.TabIndex = 4;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(311, 129);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(157, 38);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "LIMPIAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btncel
            // 
            this.btncel.Location = new System.Drawing.Point(109, 178);
            this.btncel.Name = "btncel";
            this.btncel.Size = new System.Drawing.Size(109, 49);
            this.btncel.TabIndex = 6;
            this.btncel.Text = "CONVERTIR A CELSIUS";
            this.btncel.UseVisualStyleBackColor = true;
            this.btncel.Click += new System.EventHandler(this.btncel_Click);
            // 
            // btnfar
            // 
            this.btnfar.Location = new System.Drawing.Point(518, 178);
            this.btnfar.Name = "btnfar";
            this.btnfar.Size = new System.Drawing.Size(168, 49);
            this.btnfar.TabIndex = 7;
            this.btnfar.Text = "CONVERTIR A FARENHEINT";
            this.btnfar.UseVisualStyleBackColor = true;
            this.btnfar.Click += new System.EventHandler(this.btnfar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfar);
            this.Controls.Add(this.btncel);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.tbfar);
            this.Controls.Add(this.tbcel);
            this.Controls.Add(this.lbfar);
            this.Controls.Add(this.lbcel);
            this.Controls.Add(this.lbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbt;
        private System.Windows.Forms.Label lbcel;
        private System.Windows.Forms.Label lbfar;
        private System.Windows.Forms.TextBox tbcel;
        private System.Windows.Forms.TextBox tbfar;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncel;
        private System.Windows.Forms.Button btnfar;
    }
}

