﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenDentBusiness;

namespace PluginExample {
	public partial class FormFromToolbar:Form {
		public long PatNum;

		public FormFromToolbar() {
			InitializeComponent();
		}

		private void FormFromToolbar_Load(object sender,EventArgs e) {
			Patient pat=Patients.GetLim(PatNum);
			if(pat!=null) {
				Text="Grush Dashboard Results for "+pat.GetNameFL();
			}
		}

        private void GrushDentalDashboard_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
