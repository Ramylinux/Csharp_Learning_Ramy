namespace WindowsFormsApplication1
{
   partial class FormHello
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
         this.buthello = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // buthello
         // 
         this.buthello.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buthello.Location = new System.Drawing.Point(136, 326);
         this.buthello.Name = "buthello";
         this.buthello.Size = new System.Drawing.Size(168, 61);
         this.buthello.TabIndex = 0;
         this.buthello.Text = "الضغط هنا";
         this.buthello.UseVisualStyleBackColor = true;
         this.buthello.Click += new System.EventHandler(this.buthello_Click);
         // 
         // FormHello
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(484, 461);
         this.Controls.Add(this.buthello);
         this.Name = "FormHello";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ترحيب بكم";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button buthello;
   }
}

