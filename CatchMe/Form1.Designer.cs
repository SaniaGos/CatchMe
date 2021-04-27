
namespace CatchMe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMouse
            // 
            this.buttonMouse.BackgroundImage = global::CatchMe.Properties.Resources.jerry;
            this.buttonMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMouse.Location = new System.Drawing.Point(355, 222);
            this.buttonMouse.Name = "buttonMouse";
            this.buttonMouse.Size = new System.Drawing.Size(40, 40);
            this.buttonMouse.TabIndex = 0;
            this.buttonMouse.UseVisualStyleBackColor = true;
            this.buttonMouse.Click += new System.EventHandler(this.button1_Click);
            this.buttonMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMouse_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::CatchMe.Properties.Resources.tom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.buttonMouse);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tom and Jerry";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMouse;
    }
}

