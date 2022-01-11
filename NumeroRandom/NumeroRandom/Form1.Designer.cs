
namespace NumeroRandom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listGenerados = new System.Windows.Forms.ListView();
            this.listBloqueados = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrandom = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbloquear = new System.Windows.Forms.Button();
            this.txtMeta = new System.Windows.Forms.TextBox();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtFaltante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(795, 707);
            this.dataGridView1.TabIndex = 0;
            // 
            // listGenerados
            // 
            this.listGenerados.HideSelection = false;
            this.listGenerados.Location = new System.Drawing.Point(828, 145);
            this.listGenerados.Name = "listGenerados";
            this.listGenerados.Size = new System.Drawing.Size(121, 574);
            this.listGenerados.TabIndex = 1;
            this.listGenerados.UseCompatibleStateImageBehavior = false;
            // 
            // listBloqueados
            // 
            this.listBloqueados.HideSelection = false;
            this.listBloqueados.Location = new System.Drawing.Point(981, 163);
            this.listBloqueados.Name = "listBloqueados";
            this.listBloqueados.Size = new System.Drawing.Size(121, 556);
            this.listBloqueados.TabIndex = 2;
            this.listBloqueados.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numeros generados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(981, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numeros bloqueados";
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(828, 87);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(121, 23);
            this.btnrandom.TabIndex = 5;
            this.btnrandom.Text = "Generar nuevo";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(981, 116);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(65, 23);
            this.txtNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(981, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bloquear numero";
            // 
            // btnbloquear
            // 
            this.btnbloquear.Location = new System.Drawing.Point(1062, 116);
            this.btnbloquear.Name = "btnbloquear";
            this.btnbloquear.Size = new System.Drawing.Size(40, 23);
            this.btnbloquear.TabIndex = 8;
            this.btnbloquear.Text = "+";
            this.btnbloquear.UseVisualStyleBackColor = true;
            this.btnbloquear.Click += new System.EventHandler(this.btnbloquear_Click);
            // 
            // txtMeta
            // 
            this.txtMeta.Location = new System.Drawing.Point(828, 47);
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.Size = new System.Drawing.Size(85, 23);
            this.txtMeta.TabIndex = 9;
            this.txtMeta.Text = "0";
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(926, 47);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(85, 23);
            this.txtActual.TabIndex = 10;
            this.txtActual.Text = "0";
            // 
            // txtFaltante
            // 
            this.txtFaltante.Location = new System.Drawing.Point(1017, 47);
            this.txtFaltante.Name = "txtFaltante";
            this.txtFaltante.Size = new System.Drawing.Size(85, 23);
            this.txtFaltante.TabIndex = 11;
            this.txtFaltante.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(828, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Meta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(926, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Actual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1017, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Faltante";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 731);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFaltante);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.txtMeta);
            this.Controls.Add(this.btnbloquear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnrandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBloqueados);
            this.Controls.Add(this.listGenerados);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listGenerados;
        private System.Windows.Forms.ListView listBloqueados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbloquear;
        private System.Windows.Forms.TextBox txtMeta;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtFaltante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

