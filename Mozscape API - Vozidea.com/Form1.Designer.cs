namespace Mozscape_API___Vozidea.com
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label_access = new System.Windows.Forms.Label();
            this.label_secret = new System.Windows.Forms.Label();
            this.textBox_access = new System.Windows.Forms.TextBox();
            this.textBox_secret = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(15, 82);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(452, 20);
            this.textBox_url.TabIndex = 1;
            // 
            // label_access
            // 
            this.label_access.AutoSize = true;
            this.label_access.Location = new System.Drawing.Point(12, 15);
            this.label_access.Name = "label_access";
            this.label_access.Size = new System.Drawing.Size(54, 13);
            this.label_access.TabIndex = 2;
            this.label_access.Text = "Access Id";
            // 
            // label_secret
            // 
            this.label_secret.AutoSize = true;
            this.label_secret.Location = new System.Drawing.Point(12, 41);
            this.label_secret.Name = "label_secret";
            this.label_secret.Size = new System.Drawing.Size(59, 13);
            this.label_secret.TabIndex = 3;
            this.label_secret.Text = "Secret Key";
            // 
            // textBox_access
            // 
            this.textBox_access.Location = new System.Drawing.Point(72, 12);
            this.textBox_access.Name = "textBox_access";
            this.textBox_access.Size = new System.Drawing.Size(395, 20);
            this.textBox_access.TabIndex = 4;
            // 
            // textBox_secret
            // 
            this.textBox_secret.Location = new System.Drawing.Point(77, 38);
            this.textBox_secret.Name = "textBox_secret";
            this.textBox_secret.Size = new System.Drawing.Size(390, 20);
            this.textBox_secret.TabIndex = 5;
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(12, 66);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(32, 13);
            this.label_url.TabIndex = 7;
            this.label_url.Text = "URL:";
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(15, 133);
            this.textBox_res.Multiline = true;
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_res.Size = new System.Drawing.Size(452, 70);
            this.textBox_res.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Respuesta JSON:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_result.Location = new System.Drawing.Point(12, 216);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(49, 17);
            this.label_result.TabIndex = 10;
            this.label_result.Text = "result";
            this.label_result.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(399, 220);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vozidea.com";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 241);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.textBox_secret);
            this.Controls.Add(this.textBox_access);
            this.Controls.Add(this.label_secret);
            this.Controls.Add(this.label_access);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Mozscape API - Vozidea.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label_access;
        private System.Windows.Forms.Label label_secret;
        private System.Windows.Forms.TextBox textBox_access;
        private System.Windows.Forms.TextBox textBox_secret;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.TextBox textBox_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

