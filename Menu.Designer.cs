namespace CadMotorista
{
    partial class Menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.btmenupesq = new System.Windows.Forms.Button();
            this.btmenucad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao sistema Martins";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(162, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "logistica e transporte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btmenupesq
            // 
            this.btmenupesq.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btmenupesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmenupesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenupesq.Image = global::CadMotorista.Properties.Resources.iconepesquisar;
            this.btmenupesq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmenupesq.Location = new System.Drawing.Point(214, 191);
            this.btmenupesq.Name = "btmenupesq";
            this.btmenupesq.Size = new System.Drawing.Size(137, 39);
            this.btmenupesq.TabIndex = 3;
            this.btmenupesq.Text = "PESQUISAR";
            this.btmenupesq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmenupesq.UseVisualStyleBackColor = false;
            this.btmenupesq.Click += new System.EventHandler(this.btmenupesq_Click);
            // 
            // btmenucad
            // 
            this.btmenucad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btmenucad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmenucad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenucad.Image = global::CadMotorista.Properties.Resources.iconecadastrar;
            this.btmenucad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmenucad.Location = new System.Drawing.Point(214, 128);
            this.btmenucad.Name = "btmenucad";
            this.btmenucad.Size = new System.Drawing.Size(137, 39);
            this.btmenucad.TabIndex = 2;
            this.btmenucad.Text = "CADASTRAR";
            this.btmenucad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmenucad.UseVisualStyleBackColor = false;
            this.btmenucad.Click += new System.EventHandler(this.btmenucad_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 324);
            this.Controls.Add(this.btmenupesq);
            this.Controls.Add(this.btmenucad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu de acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmenucad;
        private System.Windows.Forms.Button btmenupesq;
    }
}