namespace AppNavegador
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnMenor = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnMayor = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "https://www.google.com/webhp?hl=es-419&sa=X&ved=0ahUKEwiXx6fL0O36AhXvL0QIHd1fAgkQ" +
                "PAgI",
            "https://www.youtube.com/",
            "https://outlook.live.com/owa/",
            "https://es-la.facebook.com/"});
            this.comboBox1.Location = new System.Drawing.Point(379, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(562, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // BtnMenor
            // 
            this.BtnMenor.Location = new System.Drawing.Point(12, 11);
            this.BtnMenor.Name = "BtnMenor";
            this.BtnMenor.Size = new System.Drawing.Size(41, 23);
            this.BtnMenor.TabIndex = 1;
            this.BtnMenor.Text = "<";
            this.BtnMenor.UseVisualStyleBackColor = true;
            this.BtnMenor.Click += new System.EventHandler(this.BtnMenor_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(987, 399);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(287, 15);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 3;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnMayor
            // 
            this.BtnMayor.Location = new System.Drawing.Point(59, 12);
            this.BtnMayor.Name = "BtnMayor";
            this.BtnMayor.Size = new System.Drawing.Size(42, 23);
            this.BtnMayor.TabIndex = 4;
            this.BtnMayor.Text = ">";
            this.BtnMayor.UseVisualStyleBackColor = true;
            this.BtnMayor.Click += new System.EventHandler(this.BtnMayor_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(107, 14);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(84, 23);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(197, 13);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(84, 24);
            this.BtnStop.TabIndex = 6;
            this.BtnStop.Text = "🛑";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(958, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(41, 32);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "GO!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnMayor);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BtnMenor);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnMenor;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnMayor;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button btnGo;
    }
}

