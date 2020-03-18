using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TabPageColoring
{
   public partial class Form1 : Form
   {

      Dictionary<int, Color>     TabColors = new Dictionary<int, Color>();

      /// <summary>
      /// An example of setting the color of a TabPage in a WinForms TabControl.
      /// See https://stackoverflow.com/questions/5338587/set-tabpage-header-color
      /// See https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.tabcontrol.drawitem?redirectedfrom=MSDN&view=netframework-4.8
      /// </summary>
      public Form1()
      {
         InitializeComponent();

         TabColors.Add(0, Color.Red    );
         TabColors.Add(1, Color.Blue   );
         TabColors.Add(2, Color.Yellow );
      }

      private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
      {
         //e.DrawBackground();
         //using (Brush br = new SolidBrush(TabColors[tabControl1.TabPages[e.Index]]))
         using (Brush br = new SolidBrush(TabColors[e.Index]))
         {
            e.Graphics.FillRectangle(br, e.Bounds);
            SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, e.Font);
            e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

            Rectangle rect = e.Bounds;
            rect.Offset(0, 1);
            rect.Inflate(0, -1);
            e.Graphics.DrawRectangle(Pens.DarkGray, rect);
            e.DrawFocusRectangle();
         }
      }

      private void cmdToggleTabPageColor_Click(object sender, System.EventArgs e)
      {
         int myIndex = -1;
         switch(((Button)sender).Name)
         {
            case "cmdToggleTabPage1Color":   myIndex = 0;  break;
            case "cmdToggleTabPage2Color":   myIndex = 1; break;
            case "cmdToggleTabPage3Color":   myIndex = 2; break;
         }

         if (myIndex < 0) return;

         // Deal with the color
         Color newColor = Color.Transparent;
         if (TabColors[myIndex] == Color.Transparent) newColor = Color.Red;

         TabColors.Remove  (myIndex);
         TabColors.Add     (myIndex, newColor);

         // To trigger the calling of the DrawItem Event Handler
         tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
        
      }
   }
}
