namespace WindowsFormsApp1
{
	partial class base_window
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
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.task11 = new WindowsFormsApp1.task1();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.task21 = new WindowsFormsApp1.task2();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.task31 = new WindowsFormsApp1.task3();
			this.ImageBox = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
			this.SuspendLayout();
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tabPage1);
			this.tabs.Controls.Add(this.tabPage2);
			this.tabs.Controls.Add(this.tabPage3);
			this.tabs.Location = new System.Drawing.Point(2, 3);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(224, 522);
			this.tabs.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.task11);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(216, 496);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Task 1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// task11
			// 
			this.task11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.task11.Location = new System.Drawing.Point(3, 3);
			this.task11.Name = "task11";
			this.task11.Size = new System.Drawing.Size(210, 490);
			this.task11.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.task21);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(216, 496);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Task2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// task21
			// 
			this.task21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.task21.Cursor = System.Windows.Forms.Cursors.No;
			this.task21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.task21.Location = new System.Drawing.Point(3, 3);
			this.task21.Name = "task21";
			this.task21.Size = new System.Drawing.Size(210, 490);
			this.task21.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.task31);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(216, 496);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Task 3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// task31
			// 
			this.task31.Dock = System.Windows.Forms.DockStyle.Fill;
			this.task31.Location = new System.Drawing.Point(3, 3);
			this.task31.Name = "task31";
			this.task31.Size = new System.Drawing.Size(210, 490);
			this.task31.TabIndex = 0;
			this.task31.Load += new System.EventHandler(this.task31_Load);
			// 
			// ImageBox
			// 
			this.ImageBox.Location = new System.Drawing.Point(253, 28);
			this.ImageBox.Name = "ImageBox";
			this.ImageBox.Size = new System.Drawing.Size(434, 493);
			this.ImageBox.TabIndex = 1;
			this.ImageBox.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(253, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Load";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// base_window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 530);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ImageBox);
			this.Controls.Add(this.tabs);
			this.Name = "base_window";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.base_window_Load);
			this.tabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private task1 task11;
		private task2 task21;
		private task3 task31;
		private System.Windows.Forms.PictureBox ImageBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

