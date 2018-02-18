namespace NEW_Form_Button1
{
   partial class Form1_Button_1
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
         this.Change_Color = new System.Windows.Forms.Button();
         this.Change_Fonts = new System.Windows.Forms.Button();
         this.Show_Message = new System.Windows.Forms.Button();
         this.button_Exit = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // Change_Color
         // 
         this.Change_Color.Location = new System.Drawing.Point(63, 27);
         this.Change_Color.Name = "Change_Color";
         this.Change_Color.Size = new System.Drawing.Size(159, 39);
         this.Change_Color.TabIndex = 0;
         this.Change_Color.Text = "Change Color To Green";
         this.Change_Color.UseVisualStyleBackColor = true;
         this.Change_Color.Click += new System.EventHandler(this.Change_Color_Click);
         // 
         // Change_Fonts
         // 
         this.Change_Fonts.Location = new System.Drawing.Point(63, 86);
         this.Change_Fonts.Name = "Change_Fonts";
         this.Change_Fonts.Size = new System.Drawing.Size(159, 39);
         this.Change_Fonts.TabIndex = 1;
         this.Change_Fonts.Text = "Change Fonts To ..";
         this.Change_Fonts.UseVisualStyleBackColor = true;
         this.Change_Fonts.Click += new System.EventHandler(this.Change_Fonts_Click);
         // 
         // Show_Message
         // 
         this.Show_Message.Location = new System.Drawing.Point(63, 148);
         this.Show_Message.Name = "Show_Message";
         this.Show_Message.Size = new System.Drawing.Size(159, 39);
         this.Show_Message.TabIndex = 2;
         this.Show_Message.Text = "Show A Messages";
         this.Show_Message.UseVisualStyleBackColor = true;
         this.Show_Message.Click += new System.EventHandler(this.Show_Message_Click);
         // 
         // button_Exit
         // 
         this.button_Exit.Location = new System.Drawing.Point(63, 223);
         this.button_Exit.Name = "button_Exit";
         this.button_Exit.Size = new System.Drawing.Size(159, 39);
         this.button_Exit.TabIndex = 3;
         this.button_Exit.Text = "Exit";
         this.button_Exit.UseVisualStyleBackColor = true;
         this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
         // 
         // Form1_Button_1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(287, 303);
         this.Controls.Add(this.button_Exit);
         this.Controls.Add(this.Show_Message);
         this.Controls.Add(this.Change_Fonts);
         this.Controls.Add(this.Change_Color);
         this.Name = "Form1_Button_1";
         this.Text = "Button_Test1";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button Change_Color;
      private System.Windows.Forms.Button Change_Fonts;
      private System.Windows.Forms.Button Show_Message;
      private System.Windows.Forms.Button button_Exit;
   }
}

