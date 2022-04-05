namespace byasovdavidproject
{
    partial class FormLoss
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.labelLoss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(69, 75);
            this.buttonNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(105, 42);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Райдайын";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLoss
            // 
            this.labelLoss.AutoSize = true;
            this.labelLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoss.Location = new System.Drawing.Point(46, 24);
            this.labelLoss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoss.Name = "labelLoss";
            this.labelLoss.Size = new System.Drawing.Size(160, 25);
            this.labelLoss.TabIndex = 1;
            this.labelLoss.Text = "Райдай ногаей";
            // 
            // FormLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 173);
            this.Controls.Add(this.labelLoss);
            this.Controls.Add(this.buttonNewGame);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLoss";
            this.Text = "FormLoss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label labelLoss;
    }
}