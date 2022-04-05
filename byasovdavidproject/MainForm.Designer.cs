namespace byasovdavidproject
{
    partial class MainForm
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
            this.buttonLeftFirst = new System.Windows.Forms.Button();
            this.buttonRightFirst = new System.Windows.Forms.Button();
            this.labelFirstlevel = new System.Windows.Forms.Label();
            this.pictureBoxWolf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWolf)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLeftFirst
            // 
            this.buttonLeftFirst.Location = new System.Drawing.Point(140, 264);
            this.buttonLeftFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLeftFirst.Name = "buttonLeftFirst";
            this.buttonLeftFirst.Size = new System.Drawing.Size(100, 40);
            this.buttonLeftFirst.TabIndex = 0;
            this.buttonLeftFirst.Text = "Бираег";
            this.buttonLeftFirst.UseVisualStyleBackColor = true;
            this.buttonLeftFirst.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRightFirst
            // 
            this.buttonRightFirst.Location = new System.Drawing.Point(346, 264);
            this.buttonRightFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRightFirst.Name = "buttonRightFirst";
            this.buttonRightFirst.Size = new System.Drawing.Size(100, 40);
            this.buttonRightFirst.TabIndex = 1;
            this.buttonRightFirst.Text = "Рувас";
            this.buttonRightFirst.UseVisualStyleBackColor = true;
            this.buttonRightFirst.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // labelFirstlevel
            // 
            this.labelFirstlevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelFirstlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstlevel.ForeColor = System.Drawing.Color.Maroon;
            this.labelFirstlevel.Location = new System.Drawing.Point(190, 220);
            this.labelFirstlevel.Name = "labelFirstlevel";
            this.labelFirstlevel.Size = new System.Drawing.Size(206, 41);
            this.labelFirstlevel.TabIndex = 4;
            this.labelFirstlevel.Text = "чи у ай?(кто это?)";
            this.labelFirstlevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWolf
            // 
            this.pictureBoxWolf.Image = global::byasovdavidproject.Properties.Resources.волк;
            this.pictureBoxWolf.Location = new System.Drawing.Point(140, 19);
            this.pictureBoxWolf.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxWolf.Name = "pictureBoxWolf";
            this.pictureBoxWolf.Size = new System.Drawing.Size(300, 200);
            this.pictureBoxWolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWolf.TabIndex = 2;
            this.pictureBoxWolf.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labelFirstlevel);
            this.Controls.Add(this.pictureBoxWolf);
            this.Controls.Add(this.buttonRightFirst);
            this.Controls.Add(this.buttonLeftFirst);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWolf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLeftFirst;
        private System.Windows.Forms.Button buttonRightFirst;
        private System.Windows.Forms.PictureBox pictureBoxWolf;
        private System.Windows.Forms.Label labelFirstlevel;
    }
}