
namespace MySQLWin
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
            this.lblHost = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHost.ForeColor = System.Drawing.Color.White;
            this.lblHost.Location = new System.Drawing.Point(81, 27);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(45, 21);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host:";
            // 
            // lblPort
            // 
            this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(16, 203);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(110, 21);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Base de Datos:";
            // 
            // lblPW
            // 
            this.lblPW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPW.ForeColor = System.Drawing.Color.White;
            this.lblPW.Location = new System.Drawing.Point(34, 283);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(92, 21);
            this.lblPW.TabIndex = 3;
            this.lblPW.Text = "Contraseña:";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(59, 243);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(67, 21);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuario:";
            // 
            // tbHost
            // 
            this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbHost.Location = new System.Drawing.Point(132, 24);
            this.tbHost.Multiline = true;
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(352, 170);
            this.tbHost.TabIndex = 4;
            // 
            // tbPort
            // 
            this.tbDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDB.Location = new System.Drawing.Point(132, 200);
            this.tbDB.Name = "tbPort";
            this.tbDB.Size = new System.Drawing.Size(352, 29);
            this.tbDB.TabIndex = 5;
            // 
            // tbUser
            // 
            this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbUser.Location = new System.Drawing.Point(132, 240);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(352, 29);
            this.tbUser.TabIndex = 6;
            // 
            // tbPw
            // 
            this.tbPw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPw.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPw.Location = new System.Drawing.Point(132, 280);
            this.tbPw.Name = "tbPw";
            this.tbPw.Size = new System.Drawing.Size(352, 29);
            this.tbPw.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.AutoSize = true;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.Location = new System.Drawing.Point(160, 315);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(164, 35);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Probar Conexión";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbData.Controls.Add(this.lblHost);
            this.gbData.Controls.Add(this.btnConnect);
            this.gbData.Controls.Add(this.lblPort);
            this.gbData.Controls.Add(this.tbPw);
            this.gbData.Controls.Add(this.lblUser);
            this.gbData.Controls.Add(this.tbUser);
            this.gbData.Controls.Add(this.lblPW);
            this.gbData.Controls.Add(this.tbDB);
            this.gbData.Controls.Add(this.tbHost);
            this.gbData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbData.ForeColor = System.Drawing.Color.White;
            this.gbData.Location = new System.Drawing.Point(12, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(490, 356);
            this.gbData.TabIndex = 9;
            this.gbData.TabStop = false;
            this.gbData.Text = "Datos de Conexión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(515, 380);
            this.Controls.Add(this.gbData);
            this.Name = "Form1";
            this.Text = "Formulario de Pruebas de Conexión a MySQL";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPw;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbData;
    }
}

