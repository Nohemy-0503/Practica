namespace Practica
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
            this.components = new System.ComponentModel.Container();
            this.btGuardar = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.btAFP = new System.Windows.Forms.Button();
            this.btISSS = new System.Windows.Forms.Button();
            this.btneto = new System.Windows.Forms.Button();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.txtneto = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.labelSalario = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(98, 353);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 0;
            this.btGuardar.Text = "Guardar ";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(81, 50);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.Location = new System.Drawing.Point(84, 145);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(26, 13);
            this.labelDUI.TabIndex = 3;
            this.labelDUI.Text = "DUI";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(190, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(190, 145);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 6;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(84, 100);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre";
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(211, 271);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelRegistro.TabIndex = 8;
            // 
            // btAFP
            // 
            this.btAFP.Location = new System.Drawing.Point(351, 46);
            this.btAFP.Name = "btAFP";
            this.btAFP.Size = new System.Drawing.Size(75, 23);
            this.btAFP.TabIndex = 9;
            this.btAFP.Text = "AFP";
            this.btAFP.UseVisualStyleBackColor = true;
            this.btAFP.Click += new System.EventHandler(this.btAFP_Click);
            // 
            // btISSS
            // 
            this.btISSS.Location = new System.Drawing.Point(351, 100);
            this.btISSS.Name = "btISSS";
            this.btISSS.Size = new System.Drawing.Size(75, 23);
            this.btISSS.TabIndex = 10;
            this.btISSS.Text = "ISSS";
            this.btISSS.UseVisualStyleBackColor = true;
            this.btISSS.Click += new System.EventHandler(this.btISSS_Click);
            // 
            // btneto
            // 
            this.btneto.Location = new System.Drawing.Point(351, 145);
            this.btneto.Name = "btneto";
            this.btneto.Size = new System.Drawing.Size(75, 23);
            this.btneto.TabIndex = 11;
            this.btneto.Text = "neto";
            this.btneto.UseVisualStyleBackColor = true;
            this.btneto.Click += new System.EventHandler(this.btneto_Click);
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(477, 50);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 12;
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(477, 102);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(100, 20);
            this.txtISSS.TabIndex = 13;
            // 
            // txtneto
            // 
            this.txtneto.Location = new System.Drawing.Point(477, 147);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(100, 20);
            this.txtneto.TabIndex = 14;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(190, 197);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 15;
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(84, 203);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 16;
            this.labelSalario.Text = "Salario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtneto);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.btneto);
            this.Controls.Add(this.btISSS);
            this.Controls.Add(this.btAFP);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.Button btAFP;
        private System.Windows.Forms.Button btISSS;
        private System.Windows.Forms.Button btneto;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.TextBox txtneto;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

