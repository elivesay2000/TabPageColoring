namespace TabPageColoring
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
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.cmdToggleTabPage1Color = new System.Windows.Forms.Button();
         this.cmdToggleTabPage2Color = new System.Windows.Forms.Button();
         this.cmdToggleTabPage3Color = new System.Windows.Forms.Button();
         this.colorDialog1 = new System.Windows.Forms.ColorDialog();
         this.tabControl2 = new System.Windows.Forms.TabControl();
         this.tabPage4 = new System.Windows.Forms.TabPage();
         this.tabPage5 = new System.Windows.Forms.TabPage();
         this.tabPage6 = new System.Windows.Forms.TabPage();
         this.tabControl1.SuspendLayout();
         this.tabControl2.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Controls.Add(this.tabPage3);
         this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
         this.tabControl1.Location = new System.Drawing.Point(12, 286);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(776, 152);
         this.tabControl1.TabIndex = 0;
         this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
         // 
         // tabPage1
         // 
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(768, 126);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Tab Page #1";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(768, 126);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Tab Page #2 - Long Text";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // tabPage3
         // 
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage3.Size = new System.Drawing.Size(768, 126);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "Tab Page 3 - Medium";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // cmdToggleTabPage1Color
         // 
         this.cmdToggleTabPage1Color.Location = new System.Drawing.Point(12, 245);
         this.cmdToggleTabPage1Color.Name = "cmdToggleTabPage1Color";
         this.cmdToggleTabPage1Color.Size = new System.Drawing.Size(147, 23);
         this.cmdToggleTabPage1Color.TabIndex = 1;
         this.cmdToggleTabPage1Color.Text = "Toggle Tab Page 1 Color";
         this.cmdToggleTabPage1Color.UseVisualStyleBackColor = true;
         this.cmdToggleTabPage1Color.Click += new System.EventHandler(this.cmdToggleTabPageColor_Click);
         // 
         // cmdToggleTabPage2Color
         // 
         this.cmdToggleTabPage2Color.Location = new System.Drawing.Point(200, 245);
         this.cmdToggleTabPage2Color.Name = "cmdToggleTabPage2Color";
         this.cmdToggleTabPage2Color.Size = new System.Drawing.Size(147, 23);
         this.cmdToggleTabPage2Color.TabIndex = 2;
         this.cmdToggleTabPage2Color.Text = "Tab Page 2 Color";
         this.cmdToggleTabPage2Color.UseVisualStyleBackColor = true;
         this.cmdToggleTabPage2Color.Click += new System.EventHandler(this.cmdToggleTabPageColor_Click);
         // 
         // cmdToggleTabPage3Color
         // 
         this.cmdToggleTabPage3Color.Location = new System.Drawing.Point(401, 245);
         this.cmdToggleTabPage3Color.Name = "cmdToggleTabPage3Color";
         this.cmdToggleTabPage3Color.Size = new System.Drawing.Size(147, 23);
         this.cmdToggleTabPage3Color.TabIndex = 3;
         this.cmdToggleTabPage3Color.Text = "Tab Page 3 Color";
         this.cmdToggleTabPage3Color.UseVisualStyleBackColor = true;
         this.cmdToggleTabPage3Color.Click += new System.EventHandler(this.cmdToggleTabPageColor_Click);
         // 
         // tabControl2
         // 
         this.tabControl2.Controls.Add(this.tabPage4);
         this.tabControl2.Controls.Add(this.tabPage5);
         this.tabControl2.Controls.Add(this.tabPage6);
         this.tabControl2.Location = new System.Drawing.Point(16, 12);
         this.tabControl2.Name = "tabControl2";
         this.tabControl2.SelectedIndex = 0;
         this.tabControl2.Size = new System.Drawing.Size(768, 187);
         this.tabControl2.TabIndex = 4;
         // 
         // tabPage4
         // 
         this.tabPage4.Location = new System.Drawing.Point(4, 22);
         this.tabPage4.Name = "tabPage4";
         this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage4.Size = new System.Drawing.Size(760, 161);
         this.tabPage4.TabIndex = 0;
         this.tabPage4.Text = "Tab Page #1";
         this.tabPage4.UseVisualStyleBackColor = true;
         // 
         // tabPage5
         // 
         this.tabPage5.Location = new System.Drawing.Point(4, 22);
         this.tabPage5.Name = "tabPage5";
         this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage5.Size = new System.Drawing.Size(760, 161);
         this.tabPage5.TabIndex = 1;
         this.tabPage5.Text = "Tab Page #2 - Long Text";
         this.tabPage5.UseVisualStyleBackColor = true;
         // 
         // tabPage6
         // 
         this.tabPage6.Location = new System.Drawing.Point(4, 22);
         this.tabPage6.Name = "tabPage6";
         this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage6.Size = new System.Drawing.Size(760, 161);
         this.tabPage6.TabIndex = 2;
         this.tabPage6.Text = "Tab Page 3 - Medium";
         this.tabPage6.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.tabControl2);
         this.Controls.Add(this.cmdToggleTabPage3Color);
         this.Controls.Add(this.cmdToggleTabPage2Color);
         this.Controls.Add(this.cmdToggleTabPage1Color);
         this.Controls.Add(this.tabControl1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.tabControl1.ResumeLayout(false);
         this.tabControl2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button cmdToggleTabPage1Color;
        private System.Windows.Forms.Button cmdToggleTabPage2Color;
        private System.Windows.Forms.Button cmdToggleTabPage3Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
      private System.Windows.Forms.TabControl tabControl2;
      private System.Windows.Forms.TabPage tabPage4;
      private System.Windows.Forms.TabPage tabPage5;
      private System.Windows.Forms.TabPage tabPage6;
   }
}

