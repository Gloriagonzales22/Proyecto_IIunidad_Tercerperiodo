namespace Vista
{
    partial class Entrada
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuariotextBox1 = new System.Windows.Forms.TextBox();
            this.contraseñatextBox2 = new System.Windows.Forms.TextBox();
            this.aceptarbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // usuariotextBox1
            // 
            this.usuariotextBox1.Location = new System.Drawing.Point(184, 49);
            this.usuariotextBox1.Name = "usuariotextBox1";
            this.usuariotextBox1.Size = new System.Drawing.Size(176, 23);
            this.usuariotextBox1.TabIndex = 2;
            // 
            // contraseñatextBox2
            // 
            this.contraseñatextBox2.Location = new System.Drawing.Point(184, 96);
            this.contraseñatextBox2.Name = "contraseñatextBox2";
            this.contraseñatextBox2.Size = new System.Drawing.Size(176, 23);
            this.contraseñatextBox2.TabIndex = 3;
            // 
            // aceptarbutton
            // 
            this.aceptarbutton.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.aceptarbutton.Image = global::Vista.Properties.Resources.aceptar;
            this.aceptarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aceptarbutton.Location = new System.Drawing.Point(113, 184);
            this.aceptarbutton.Name = "aceptarbutton";
            this.aceptarbutton.Size = new System.Drawing.Size(117, 42);
            this.aceptarbutton.TabIndex = 4;
            this.aceptarbutton.Text = "Aceptar";
            this.aceptarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aceptarbutton.UseVisualStyleBackColor = true;
            this.aceptarbutton.Click += new System.EventHandler(this.aceptarbutton_Click);
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cancelarbutton.Image = global::Vista.Properties.Resources.cancelar;
            this.cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelarbutton.Location = new System.Drawing.Point(294, 184);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(131, 42);
            this.cancelarbutton.TabIndex = 5;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(410, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Entrada
            // 
            this.AcceptButton = this.aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.CancelButton = this.cancelarbutton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.aceptarbutton);
            this.Controls.Add(this.contraseñatextBox2);
            this.Controls.Add(this.usuariotextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Entrada";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usuariotextBox1;
        private TextBox contraseñatextBox2;
        private Button aceptarbutton;
        private Button cancelarbutton;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
    }
}