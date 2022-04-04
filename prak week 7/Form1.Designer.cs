
namespace prak_week_7
{
    partial class FormPandaQuiz
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
            this.labelKalimat = new System.Windows.Forms.Label();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.textBoxInputKal = new System.Windows.Forms.TextBox();
            this.textBoxInputHur = new System.Windows.Forms.TextBox();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.textBoxInputHur2 = new System.Windows.Forms.TextBox();
            this.buttonKonfirm = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKalimat
            // 
            this.labelKalimat.AutoSize = true;
            this.labelKalimat.Location = new System.Drawing.Point(29, 35);
            this.labelKalimat.Name = "labelKalimat";
            this.labelKalimat.Size = new System.Drawing.Size(155, 25);
            this.labelKalimat.TabIndex = 0;
            this.labelKalimat.Text = "Masukkan Kalimat";
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(29, 84);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(142, 25);
            this.labelHuruf.TabIndex = 1;
            this.labelHuruf.Text = "Masukkan Huruf";
            // 
            // textBoxInputKal
            // 
            this.textBoxInputKal.Location = new System.Drawing.Point(254, 32);
            this.textBoxInputKal.Name = "textBoxInputKal";
            this.textBoxInputKal.Size = new System.Drawing.Size(488, 31);
            this.textBoxInputKal.TabIndex = 2;
            // 
            // textBoxInputHur
            // 
            this.textBoxInputHur.Location = new System.Drawing.Point(254, 79);
            this.textBoxInputHur.Name = "textBoxInputHur";
            this.textBoxInputHur.Size = new System.Drawing.Size(140, 31);
            this.textBoxInputHur.TabIndex = 3;
            this.textBoxInputHur.TextChanged += new System.EventHandler(this.textBoxInputHur_TextChanged);
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(460, 82);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(75, 25);
            this.labelMenjadi.TabIndex = 4;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // textBoxInputHur2
            // 
            this.textBoxInputHur2.Location = new System.Drawing.Point(575, 79);
            this.textBoxInputHur2.Name = "textBoxInputHur2";
            this.textBoxInputHur2.Size = new System.Drawing.Size(167, 31);
            this.textBoxInputHur2.TabIndex = 5;
            this.textBoxInputHur2.TextChanged += new System.EventHandler(this.textBoxInputHur2_TextChanged);
            // 
            // buttonKonfirm
            // 
            this.buttonKonfirm.Location = new System.Drawing.Point(254, 145);
            this.buttonKonfirm.Name = "buttonKonfirm";
            this.buttonKonfirm.Size = new System.Drawing.Size(488, 34);
            this.buttonKonfirm.TabIndex = 6;
            this.buttonKonfirm.Text = "Konfirmasi";
            this.buttonKonfirm.UseVisualStyleBackColor = true;
            this.buttonKonfirm.Click += new System.EventHandler(this.buttonKonfirm_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(29, 230);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(50, 25);
            this.labelHasil.TabIndex = 7;
            this.labelHasil.Text = "Hasil";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(254, 230);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(24, 25);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Text = "...";
            // 
            // FormPandaQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 301);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonKonfirm);
            this.Controls.Add(this.textBoxInputHur2);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.textBoxInputHur);
            this.Controls.Add(this.textBoxInputKal);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.labelKalimat);
            this.Name = "FormPandaQuiz";
            this.Text = "Form Panda Quiz";
            this.Load += new System.EventHandler(this.FormPandaQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKalimat;
        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.TextBox textBoxInputKal;
        private System.Windows.Forms.TextBox textBoxInputHur;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.TextBox textBoxInputHur2;
        private System.Windows.Forms.Button buttonKonfirm;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelOutput;
    }
}

