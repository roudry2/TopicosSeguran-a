namespace Proj_Seguranca
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtChavePrivada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviarFicheiro = new System.Windows.Forms.Button();
            this.lbFicheiros = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChavePublica = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar ao servidor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtChavePrivada
            // 
            this.txtChavePrivada.Enabled = false;
            this.txtChavePrivada.Location = new System.Drawing.Point(8, 18);
            this.txtChavePrivada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChavePrivada.Multiline = true;
            this.txtChavePrivada.Name = "txtChavePrivada";
            this.txtChavePrivada.Size = new System.Drawing.Size(288, 77);
            this.txtChavePrivada.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Status);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(278, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 28);
            this.panel1.TabIndex = 5;
            // 
            // panel_Status
            // 
            this.panel_Status.BackColor = System.Drawing.Color.Red;
            this.panel_Status.Location = new System.Drawing.Point(50, 8);
            this.panel_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(13, 14);
            this.panel_Status.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(236, 6);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 20);
            this.txtNome.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID: #...";
            // 
            // btnEnviarFicheiro
            // 
            this.btnEnviarFicheiro.Location = new System.Drawing.Point(151, 220);
            this.btnEnviarFicheiro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviarFicheiro.Name = "btnEnviarFicheiro";
            this.btnEnviarFicheiro.Size = new System.Drawing.Size(85, 22);
            this.btnEnviarFicheiro.TabIndex = 8;
            this.btnEnviarFicheiro.Text = "Enviar Ficheiro";
            this.btnEnviarFicheiro.UseVisualStyleBackColor = true;
            // 
            // lbFicheiros
            // 
            this.lbFicheiros.FormattingEnabled = true;
            this.lbFicheiros.Location = new System.Drawing.Point(8, 31);
            this.lbFicheiros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFicheiros.Name = "lbFicheiros";
            this.lbFicheiros.Size = new System.Drawing.Size(229, 186);
            this.lbFicheiros.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 22);
            this.button2.TabIndex = 13;
            this.button2.Text = "Gerar Chaves (Privada /  Publica)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChavePrivada);
            this.groupBox1.Location = new System.Drawing.Point(10, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(302, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chave Privada";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChavePublica);
            this.groupBox2.Location = new System.Drawing.Point(10, 195);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(302, 108);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chave Publica";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtChavePublica
            // 
            this.txtChavePublica.Location = new System.Drawing.Point(4, 20);
            this.txtChavePublica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChavePublica.Multiline = true;
            this.txtChavePublica.Name = "txtChavePublica";
            this.txtChavePublica.Size = new System.Drawing.Size(288, 77);
            this.txtChavePublica.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 306);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 48);
            this.button3.TabIndex = 16;
            this.button3.Text = "Enviar chave publica para o servidor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lista de Ficheiros enviados:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 220);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 22);
            this.button4.TabIndex = 19;
            this.button4.Text = "Escolher Ficheiro ...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbFicheiros);
            this.groupBox3.Controls.Add(this.btnEnviarFicheiro);
            this.groupBox3.Location = new System.Drawing.Point(328, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(243, 246);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ficheiros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Client Side";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtChavePrivada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnviarFicheiro;
        private System.Windows.Forms.ListBox lbFicheiros;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChavePublica;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel_Status;
    }
}

