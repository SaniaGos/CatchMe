
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timerFreeze = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.buttonMouse = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(255, 26);
            this.contextMenuStrip.MouseLeave += new System.EventHandler(this.contextMenuStrip1_MouseLeave);
            // 
            // StripMenu
            // 
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(254, 22);
            this.StripMenu.Text = "Заморозити мишу на чверть сек";
            this.StripMenu.Click += new System.EventHandler(this.StripMenu_Click);
            // 
            // timerFreeze
            // 
            this.timerFreeze.Interval = 250;
            this.timerFreeze.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // buttonMouse
            // 
            this.buttonMouse.BackgroundImage = global::CatchMe.Properties.Resources.jerry;
            this.buttonMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMouse.Location = new System.Drawing.Point(363, 240);
            this.buttonMouse.Name = "buttonMouse";
            this.buttonMouse.Size = new System.Drawing.Size(40, 40);
            this.buttonMouse.TabIndex = 0;
            this.buttonMouse.UseVisualStyleBackColor = true;
            this.buttonMouse.Click += new System.EventHandler(this.buttonMouse_Click);
            this.buttonMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMouse_MouseMove);
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::CatchMe.Properties.Resources.tom;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.buttonMouse);
            this.panel.Location = new System.Drawing.Point(1, 35);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(780, 525);
            this.panel.TabIndex = 2;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // labelPoint
            // 
            this.labelPoint.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint.Location = new System.Drawing.Point(1, 3);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(125, 30);
            this.labelPoint.TabIndex = 3;
            this.labelPoint.Text = "Point:  0";
            this.labelPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(656, 3);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(125, 30);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.panel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tom and Jerry";
            this.contextMenuStrip.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StripMenu;
        private System.Windows.Forms.Timer timerFreeze;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Button buttonMouse;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelTime;
    }
}

