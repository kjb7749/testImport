namespace PluginExample {
	partial class FormFromToolbar {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.GrushDentalDashboard = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // GrushDentalDashboard
            // 
            this.GrushDentalDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrushDentalDashboard.Location = new System.Drawing.Point(0, 0);
            this.GrushDentalDashboard.MinimumSize = new System.Drawing.Size(20, 20);
            this.GrushDentalDashboard.Name = "GrushDentalDashboard";
            this.GrushDentalDashboard.ScriptErrorsSuppressed = true;
            this.GrushDentalDashboard.Size = new System.Drawing.Size(1194, 531);
            this.GrushDentalDashboard.TabIndex = 0;
            this.GrushDentalDashboard.Url = new System.Uri("http://grush.me:10000/GrushAdmini/", System.UriKind.Absolute);
            this.GrushDentalDashboard.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.GrushDentalDashboard_DocumentCompleted);
            // 
            // FormFromToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 531);
            this.Controls.Add(this.GrushDentalDashboard);
            this.Name = "FormFromToolbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Form";
            this.Load += new System.EventHandler(this.FormFromToolbar_Load);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.WebBrowser GrushDentalDashboard;
    }
}