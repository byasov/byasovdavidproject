namespace byasovdavidproject
{
    partial class FormSecondlevel
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLeftsecond = new System.Windows.Forms.Button();
            this.buttonRightsecond = new System.Windows.Forms.Button();
            this.pictureBoxmedved = new System.Windows.Forms.PictureBox();
            this.labelMedved = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmedved)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLeftsecond
            // 
            this.buttonLeftsecond.Location = new System.Drawing.Point(140, 264);
            this.buttonLeftsecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLeftsecond.Name = "buttonLeftsecond";
            this.buttonLeftsecond.Size = new System.Drawing.Size(100, 40);
            this.buttonLeftsecond.TabIndex = 0;
            this.buttonLeftsecond.Text = "Арс";
            this.buttonLeftsecond.UseVisualStyleBackColor = true;
            this.buttonLeftsecond.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // buttonRightsecond
            // 
            this.buttonRightsecond.Location = new System.Drawing.Point(340, 264);
            this.buttonRightsecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRightsecond.Name = "buttonRightsecond";
            this.buttonRightsecond.Size = new System.Drawing.Size(100, 40);
            this.buttonRightsecond.TabIndex = 1;
            this.buttonRightsecond.Text = "Карк";
            this.buttonRightsecond.UseVisualStyleBackColor = true;
            this.buttonRightsecond.Click += new System.EventHandler(this.buttonRight_Clic);
            // 
            // pictureBoxmedved
            // 
            this.pictureBoxmedved.Image = global::byasovdavidproject.Properties.Resources._287cc0f4cda2b6c0e9814fb61c8d0c69;
            this.pictureBoxmedved.Location = new System.Drawing.Point(140, 19);
            this.pictureBoxmedved.Name = "pictureBoxmedved";
            this.pictureBoxmedved.Size = new System.Drawing.Size(300, 200);
            this.pictureBoxmedved.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxmedved.TabIndex = 2;
            this.pictureBoxmedved.TabStop = false;
            // 
            // labelMedved
            // 
            this.labelMedved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelMedved.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedved.ForeColor = System.Drawing.Color.Maroon;
            this.labelMedved.Location = new System.Drawing.Point(185, 222);
            this.labelMedved.Name = "labelMedved";
            this.labelMedved.Size = new System.Drawing.Size(206, 41);
            this.labelMedved.TabIndex = 3;
            this.labelMedved.Text = "ай та чи у?";
            this.labelMedved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSecondlevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labelMedved);
            this.Controls.Add(this.pictureBoxmedved);
            this.Controls.Add(this.buttonRightsecond);
            this.Controls.Add(this.buttonLeftsecond);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSecondlevel";
            this.Text = "FormSecondlevel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmedved)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLeftsecond;
        private System.Windows.Forms.Button buttonRightsecond;
        private System.Windows.Forms.PictureBox pictureBoxmedved;
        private System.Windows.Forms.Label labelMedved;
    }
}