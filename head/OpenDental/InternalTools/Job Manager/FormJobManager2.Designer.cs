﻿namespace OpenDental {
	partial class FormJobManager2 {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJobManager2));
			this.textSearch = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControlNav = new System.Windows.Forms.TabControl();
			this.tabAction = new System.Windows.Forms.TabPage();
			this.checkShowUnassigned = new System.Windows.Forms.CheckBox();
			this.gridAction = new OpenDental.UI.ODGrid();
			this.tabDocumentation = new System.Windows.Forms.TabPage();
			this.gridDocumentation = new OpenDental.UI.ODGrid();
			this.tabQuery = new System.Windows.Forms.TabPage();
			this.checkShowQueryCancelled = new System.Windows.Forms.CheckBox();
			this.checkShowQueryComplete = new System.Windows.Forms.CheckBox();
			this.gridQueries = new OpenDental.UI.ODGrid();
			this.tabNotify = new System.Windows.Forms.TabPage();
			this.gridNotify = new OpenDental.UI.ODGrid();
			this.tabTree = new System.Windows.Forms.TabPage();
			this.checkCancelled = new System.Windows.Forms.CheckBox();
			this.checkResults = new System.Windows.Forms.CheckBox();
			this.treeJobs = new System.Windows.Forms.TreeView();
			this.checkCollapse = new System.Windows.Forms.CheckBox();
			this.comboCategorySearch = new System.Windows.Forms.ComboBox();
			this.labelCategory = new System.Windows.Forms.Label();
			this.labelGroupBy = new System.Windows.Forms.Label();
			this.checkComplete = new System.Windows.Forms.CheckBox();
			this.comboGroup = new System.Windows.Forms.ComboBox();
			this.tabNeedsEngineer = new System.Windows.Forms.TabPage();
			this.gridAvailableJobs = new OpenDental.UI.ODGrid();
			this.tabNeedsExpert = new System.Windows.Forms.TabPage();
			this.gridAvailableJobsExpert = new OpenDental.UI.ODGrid();
			this.tabOnHold = new System.Windows.Forms.TabPage();
			this.gridJobsOnHold = new OpenDental.UI.ODGrid();
			this.userControlJobEdit = new OpenDental.InternalTools.Job_Manager.UserControlJobEdit();
			this.userControlQueryEdit = new OpenDental.InternalTools.Job_Manager.UserControlQueryEdit();
			this.label5 = new System.Windows.Forms.Label();
			this.comboUser = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.butSearch = new OpenDental.UI.Button();
			this.butMe = new OpenDental.UI.Button();
			this.butAddJob = new OpenDental.UI.Button();
			this.butDashboard = new OpenDental.UI.Button();
			this.contextMenuQueries = new System.Windows.Forms.ContextMenu();
			this.menuGoToAccount = new System.Windows.Forms.MenuItem();
			this.butBugSubs = new OpenDental.UI.Button();
			this.butAddChildJob = new OpenDental.UI.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControlNav.SuspendLayout();
			this.tabAction.SuspendLayout();
			this.tabDocumentation.SuspendLayout();
			this.tabQuery.SuspendLayout();
			this.tabNotify.SuspendLayout();
			this.tabTree.SuspendLayout();
			this.tabNeedsEngineer.SuspendLayout();
			this.tabNeedsExpert.SuspendLayout();
			this.tabOnHold.SuspendLayout();
			this.SuspendLayout();
			// 
			// textSearch
			// 
			this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textSearch.Location = new System.Drawing.Point(462, 6);
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new System.Drawing.Size(181, 20);
			this.textSearch.TabIndex = 240;
			this.textSearch.TextChanged += new System.EventHandler(this.textSearchAction_TextChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(-1, 34);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControlNav);
			this.splitContainer1.Panel1MinSize = 250;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.userControlJobEdit);
			this.splitContainer1.Panel2.Controls.Add(this.userControlQueryEdit);
			this.splitContainer1.Panel2MinSize = 250;
			this.splitContainer1.Size = new System.Drawing.Size(1284, 678);
			this.splitContainer1.SplitterDistance = 293;
			this.splitContainer1.TabIndex = 6;
			// 
			// tabControlNav
			// 
			this.tabControlNav.Controls.Add(this.tabAction);
			this.tabControlNav.Controls.Add(this.tabDocumentation);
			this.tabControlNav.Controls.Add(this.tabQuery);
			this.tabControlNav.Controls.Add(this.tabNotify);
			this.tabControlNav.Controls.Add(this.tabTree);
			this.tabControlNav.Controls.Add(this.tabNeedsEngineer);
			this.tabControlNav.Controls.Add(this.tabNeedsExpert);
			this.tabControlNav.Controls.Add(this.tabOnHold);
			this.tabControlNav.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlNav.Location = new System.Drawing.Point(0, 0);
			this.tabControlNav.Name = "tabControlNav";
			this.tabControlNav.SelectedIndex = 0;
			this.tabControlNav.Size = new System.Drawing.Size(293, 678);
			this.tabControlNav.TabIndex = 1;
			// 
			// tabAction
			// 
			this.tabAction.Controls.Add(this.checkShowUnassigned);
			this.tabAction.Controls.Add(this.gridAction);
			this.tabAction.Location = new System.Drawing.Point(4, 22);
			this.tabAction.Name = "tabAction";
			this.tabAction.Padding = new System.Windows.Forms.Padding(3);
			this.tabAction.Size = new System.Drawing.Size(285, 652);
			this.tabAction.TabIndex = 0;
			this.tabAction.Text = "Needs Action";
			this.tabAction.UseVisualStyleBackColor = true;
			// 
			// checkShowUnassigned
			// 
			this.checkShowUnassigned.Location = new System.Drawing.Point(5, 5);
			this.checkShowUnassigned.Name = "checkShowUnassigned";
			this.checkShowUnassigned.Size = new System.Drawing.Size(184, 20);
			this.checkShowUnassigned.TabIndex = 238;
			this.checkShowUnassigned.Text = "Show OnHold/Unassigned";
			this.checkShowUnassigned.UseVisualStyleBackColor = true;
			this.checkShowUnassigned.CheckedChanged += new System.EventHandler(this.comboUser_SelectionChangeCommitted);
			// 
			// gridAction
			// 
			this.gridAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridAction.CellFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.gridAction.HasAddButton = false;
			this.gridAction.HasDropDowns = false;
			this.gridAction.HasMultilineHeaders = true;
			this.gridAction.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
			this.gridAction.HeaderHeight = 15;
			this.gridAction.HScrollVisible = false;
			this.gridAction.Location = new System.Drawing.Point(3, 31);
			this.gridAction.Name = "gridAction";
			this.gridAction.ScrollValue = 0;
			this.gridAction.Size = new System.Drawing.Size(279, 618);
			this.gridAction.TabIndex = 227;
			this.gridAction.Title = "Action Items";
			this.gridAction.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.gridAction.TitleHeight = 18;
			this.gridAction.TranslationName = "FormTaskEdit";
			this.gridAction.CellDoubleClick += new OpenDental.UI.ODGridClickEventHandler(this.gridAction_CellDoubleClick);
			this.gridAction.CellClick += new OpenDental.UI.ODGridClickEventHandler(this.gridAction_CellClick);
			this.gridAction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridAction_MouseMove);
			// 
			// tabDocumentation
			// 
			this.tabDocumentation.Controls.Add(this.gridDocumentation);
			this.tabDocumentation.Location = new System.Drawing.Point(4, 22);
			this.tabDocumentation.Name = "tabDocumentation";
			this.tabDocumentation.Padding = new System.Windows.Forms.Padding(3);
			this.tabDocumentation.Size = new System.Drawing.Size(285, 652);
			this.tabDocumentation.TabIndex = 6;
			this.tabDocumentation.Text = "Documentation";
			this.tabDocumentation.UseVisualStyleBackColor = true;
			// 
			// gridDocumentation
			// 
			this.gridDocumentation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridDocumentation.CellFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.gridDocumentation.HasAddButton = false;
			this.gridDocumentation.HasDropDowns = false;
			this.gridDocumentation.HasMultilineHeaders = true;
			this.gridDocumentation.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
			this.gridDocumentation.HeaderHeight = 15;
			this.gridDocumentation.HScrollVisible = false;
			this.gridDocumentation.Location = new System.Drawing.Point(3, 3);
			this.gridDocumentation.Name = "gridDocumentation";
			this.gridDocumentation.ScrollValue = 0;
			this.gridDocumentation.Size = new System.Drawing.Size(279, 645);
			this.gridDocumentation.TabIndex = 239;
			this.gridDocumentation.Title = "Action Items";
			this.gridDocumentation.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.gridDocumentation.TitleHeight = 18;
			this.gridDocumentation.TranslationName = "FormTaskEdit";
			this.gridDocumentation.CellClick += new OpenDental.UI.ODGridClickEventHandler(this.gridDocumention_CellClick);
			// 
			// tabQuery
			// 
			this.tabQuery.Controls.Add(this.checkShowQueryCancelled);
			this.tabQuery.Controls.Add(this.checkShowQueryComplete);
			this.tabQuery.Controls.Add(this.gridQueries);
			this.tabQuery.Location = new System.Drawing.Point(4, 22);
			this.tabQuery.Name = "tabQuery";
			this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
			this.tabQuery.Size = new System.Drawing.Size(285, 652);
			this.tabQuery.TabIndex = 5;
			this.tabQuery.Text = "Queries";
			this.tabQuery.UseVisualStyleBackColor = true;
			// 
			// checkShowQueryCancelled
			// 
			this.checkShowQueryCancelled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkShowQueryCancelled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkShowQueryCancelled.Location = new System.Drawing.Point(147, 3);
			this.checkShowQueryCancelled.Name = "checkShowQueryCancelled";
			this.checkShowQueryCancelled.Size = new System.Drawing.Size(135, 20);
			this.checkShowQueryCancelled.TabIndex = 238;
			this.checkShowQueryCancelled.Text = "Include Cancelled";
			this.checkShowQueryCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkShowQueryCancelled.UseVisualStyleBackColor = true;
			this.checkShowQueryCancelled.CheckedChanged += new System.EventHandler(this.checkShowQueryCancelled_CheckedChanged);
			// 
			// checkShowQueryComplete
			// 
			this.checkShowQueryComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkShowQueryComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkShowQueryComplete.Location = new System.Drawing.Point(2, 3);
			this.checkShowQueryComplete.Name = "checkShowQueryComplete";
			this.checkShowQueryComplete.Size = new System.Drawing.Size(135, 20);
			this.checkShowQueryComplete.TabIndex = 237;
			this.checkShowQueryComplete.Text = "Include Complete";
			this.checkShowQueryComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkShowQueryComplete.UseVisualStyleBackColor = true;
			this.checkShowQueryComplete.CheckedChanged += new System.EventHandler(this.checkShowQueryComplete_CheckedChanged);
			// 
			// gridQueries
			// 
			this.gridQueries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridQueries.CellFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.gridQueries.HasAddButton = false;
			this.gridQueries.HasDropDowns = false;
			this.gridQueries.HasMultilineHeaders = true;
			this.gridQueries.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
			this.gridQueries.HeaderHeight = 15;
			this.gridQueries.HScrollVisible = false;
			this.gridQueries.Location = new System.Drawing.Point(2, 29);
			this.gridQueries.Name = "gridQueries";
			this.gridQueries.ScrollValue = 0;
			this.gridQueries.Size = new System.Drawing.Size(280, 620);
			this.gridQueries.TabIndex = 230;
			this.gridQueries.Title = "Queries to be done";
			this.gridQueries.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.gridQueries.TitleHeight = 18;
			this.gridQueries.TranslationName = "Job Edit";
			this.gridQueries.CellClick += new OpenDental.UI.ODGridClickEventHandler(this.gridQueries_CellClick);
			// 
			// tabNotify
			// 
			this.tabNotify.Controls.Add(this.gridNotify);
			this.tabNotify.Location = new System.Drawing.Point(4, 22);
			this.tabNotify.Name = "tabNotify";
			this.tabNotify.Size = new System.Drawing.Size(285, 652);
			this.tabNotify.TabIndex = 7;
			this.tabNotify.Text = "Notify Customer";
			this.tabNotify.UseVisualStyleBackColor = true;
			// 
			// gridNotify
			// 
			this.gridNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridNotify.CellFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.gridNotify.HasAddButton = false;
			this.gridNotify.HasDropDowns = false;
			this.gridNotify.HasMultilineHeaders = true;
			this.gridNotify.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
			this.gridNotify.HeaderHeight = 15;
			this.gridNotify.HScrollVisible = false;
			this.gridNotify.Location = new System.Drawing.Point(3, 4);
			this.gridNotify.Name = "gridNotify";
			this.gridNotify.ScrollValue = 0;
			this.gridNotify.Size = new System.Drawing.Size(279, 645);
			this.gridNotify.TabIndex = 240;
			this.gridNotify.Title = "Action Items";
			this.gridNotify.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.gridNotify.TitleHeight = 18;
			this.gridNotify.TranslationName = "FormTaskEdit";
			this.gridNotify.CellClick += new OpenDental.UI.ODGridClickEventHandler(this.gridNotify_CellClick);
			// 
			// tabTree
			// 
			this.tabTree.Controls.Add(this.checkCancelled);
			this.tabTree.Controls.Add(this.checkResults);
			this.tabTree.Controls.Add(this.treeJobs);
			this.tabTree.Controls.Add(this.checkCollapse);
			this.tabTree.Controls.Add(this.comboCategorySearch);
			this.tabTree.Controls.Add(this.labelCategory);
			this.tabTree.Controls.Add(this.labelGroupBy);
			this.tabTree.Controls.Add(this.checkComplete);
			this.tabTree.Controls.Add(this.comboGroup);
			this.tabTree.Location = new System.Drawing.Point(4, 22);
			this.tabTree.Name = "tabTree";
			this.tabTree.Padding = new System.Windows.Forms.Padding(3);
			this.tabTree.Size = new System.Drawing.Size(285, 652);
			this.tabTree.TabIndex = 1;
			this.tabTree.Text = "Tree View";
			this.tabTree.UseVisualStyleBackColor = true;
			// 
			// checkCancelled
			// 
			this.checkCancelled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkCancelled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkCancelled.Location = new System.Drawing.Point(148, 76);
			this.checkCancelled.Name = "checkCancelled";
			this.checkCancelled.Size = new System.Drawing.Size(135, 20);
			this.checkCancelled.TabIndex = 236;
			this.checkCancelled.Text = "Include Cancelled";
			this.checkCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkCancelled.UseVisualStyleBackColor = true;
			this.checkCancelled.CheckedChanged += new System.EventHandler(this.checkCancelled_CheckedChanged);
			// 
			// checkResults
			// 
			this.checkResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkResults.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkResults.Location = new System.Drawing.Point(158, 97);
			this.checkResults.Name = "checkResults";
			this.checkResults.Size = new System.Drawing.Size(125, 20);
			this.checkResults.TabIndex = 235;
			this.checkResults.Text = "Search Results";
			this.checkResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkResults.UseVisualStyleBackColor = true;
			this.checkResults.Visible = false;
			this.checkResults.CheckedChanged += new System.EventHandler(this.checkResults_CheckedChanged);
			// 
			// treeJobs
			// 
			this.treeJobs.AllowDrop = true;
			this.treeJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeJobs.HideSelection = false;
			this.treeJobs.Indent = 9;
			this.treeJobs.Location = new System.Drawing.Point(3, 118);
			this.treeJobs.Name = "treeJobs";
			this.treeJobs.Size = new System.Drawing.Size(283, 531);
			this.treeJobs.TabIndex = 220;
			this.treeJobs.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeJobs_ItemDrag);
			this.treeJobs.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeJobs_NodeMouseClick);
			this.treeJobs.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeJobs_DragDrop);
			this.treeJobs.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeJobs_DragEnter);
			this.treeJobs.DragOver += new System.Windows.Forms.DragEventHandler(this.treeJobs_DragOver);
			// 
			// checkCollapse
			// 
			this.checkCollapse.Location = new System.Drawing.Point(6, 97);
			this.checkCollapse.Name = "checkCollapse";
			this.checkCollapse.Size = new System.Drawing.Size(103, 20);
			this.checkCollapse.TabIndex = 226;
			this.checkCollapse.Text = "Collapse All";
			this.checkCollapse.UseVisualStyleBackColor = true;
			this.checkCollapse.CheckedChanged += new System.EventHandler(this.checkCollapse_CheckedChanged);
			// 
			// comboCategorySearch
			// 
			this.comboCategorySearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboCategorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboCategorySearch.FormattingEnabled = true;
			this.comboCategorySearch.Location = new System.Drawing.Point(68, 6);
			this.comboCategorySearch.Name = "comboCategorySearch";
			this.comboCategorySearch.Size = new System.Drawing.Size(215, 21);
			this.comboCategorySearch.TabIndex = 234;
			this.comboCategorySearch.SelectedIndexChanged += new System.EventHandler(this.comboCategorySearch_SelectedIndexChanged);
			// 
			// labelCategory
			// 
			this.labelCategory.Location = new System.Drawing.Point(12, 7);
			this.labelCategory.Margin = new System.Windows.Forms.Padding(0);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(55, 20);
			this.labelCategory.TabIndex = 233;
			this.labelCategory.Text = "Category";
			this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelGroupBy
			// 
			this.labelGroupBy.Location = new System.Drawing.Point(12, 33);
			this.labelGroupBy.Margin = new System.Windows.Forms.Padding(0);
			this.labelGroupBy.Name = "labelGroupBy";
			this.labelGroupBy.Size = new System.Drawing.Size(55, 15);
			this.labelGroupBy.TabIndex = 222;
			this.labelGroupBy.Text = "Group By";
			this.labelGroupBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkComplete
			// 
			this.checkComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkComplete.Location = new System.Drawing.Point(148, 57);
			this.checkComplete.Name = "checkComplete";
			this.checkComplete.Size = new System.Drawing.Size(135, 20);
			this.checkComplete.TabIndex = 230;
			this.checkComplete.Text = "Include Complete";
			this.checkComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkComplete.UseVisualStyleBackColor = true;
			this.checkComplete.CheckedChanged += new System.EventHandler(this.checkComplete_CheckedChanged);
			// 
			// comboGroup
			// 
			this.comboGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGroup.FormattingEnabled = true;
			this.comboGroup.Location = new System.Drawing.Point(68, 30);
			this.comboGroup.Name = "comboGroup";
			this.comboGroup.Size = new System.Drawing.Size(215, 21);
			this.comboGroup.TabIndex = 221;
			this.comboGroup.SelectionChangeCommitted += new System.EventHandler(this.comboGroup_SelectionChangeCommitted);
			// 
			// tabNeedsEngineer
			// 
			this.tabNeedsEngineer.Controls.Add(this.gridAvailableJobs);
			this.tabNeedsEngineer.Location = new System.Drawing.Point(4, 22);
			this.tabNeedsEngineer.Name = "tabNeedsEngineer";
			this.tabNeedsEngineer.Padding = new System.Windows.Forms.Padding(3);
			this.tabNeedsEngineer.Size = new System.Drawing.Size(285, 652);
			this.tabNeedsEngineer.TabIndex = 2;
			this.tabNeedsEngineer.Text = "Needs Engineer";
			this.tabNeedsEngineer.UseVisualStyleBackColor = true;
			// 
			// gridAvailableJobs
			// 
			this.gridAvailableJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridAvailableJobs.CellFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.gridAvailableJobs.HasAddButton = false;
			this.gridAvailableJobs.HasDropDowns = false;
			this.gridAvailableJobs.HasMultilineHeaders = true;
			this.gridAvailableJobs.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
			this.gridAvailableJobs.HeaderHeight = 15;
			this.gridAvailableJobs.HScrollVisible = false;
			this.gridAvailableJobs.Location = new System.Drawing.Point(0, 0);
			this.gridAvailableJobs.Name = "gridAvailableJobs";
			this.gridAvailableJobs.ScrollValue = 0;
			this.gridAvailableJobs.Size = new System.Drawing.Size(285, 652);
			this.gridAvailableJobs.TabIndex = 228;
			this.gridAvailableJobs.Title = "Available Engineer Jobs";
			this.gridAvailableJobs.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.gridAvailableJobs.TitleHeight = 18;
			this.gridAvailableJobs.TranslationName = "Job Edit";
			this.gridAvailableJobs.CellDoubleClick += new OpenDental.UI.ODGridClickEventHandler(this.gridAvailableJobs_CellDoubleClick);
			this.gridAvailableJobs.CellClick += new OpenDental.UI.ODGridClickEventHandler(this.gridAvailableJobs_CellClick);
			// 
			// tabNeedsExpert
			// 
			this.tabNeedsExpert.Controls.Add(this.gridAvailableJobsExpert);
			this.tabNeedsExpert.Location = new System.Drawing.Point(4, 22);
			this.tabNeedsExpert.Name = "tabNeedsExpert";
			this.tabNeedsExpert.Padding = new System.Windows.Forms.Padding(3);
			this.tabNeedsExpert.Size = new System.Drawing.Size(285, 652);
			this.tabNeedsExpert.TabIndex = 3;
			this.tabNeedsExpert.Text = "Needs Expert";
			this.tabNeedsExpert.UseVisualStyleBackColor = true;
			// 
			// gridAvailableJobsExpert
			// 
			this.gridAvailableJobsExpert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridAvailableJobsExpert.CellFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.gridAvailableJobsExpert.HasAddButton = false;
			this.gridAvailableJobsExpert.HasDropDowns = false;
			this.gridAvailableJobsExpert.HasMultilineHeaders = true;
			this.gridAvailableJobsExpert.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
			this.gridAvailableJobsExpert.HeaderHeight = 15;
			this.gridAvailableJobsExpert.HScrollVisible = false;
			this.gridAvailableJobsExpert.Location = new System.Drawing.Point(0, 0);
			this.gridAvailableJobsExpert.Name = "gridAvailableJobsExpert";
			this.gridAvailableJobsExpert.ScrollValue = 0;
			this.gridAvailableJobsExpert.Size = new System.Drawing.Size(285, 652);
			this.gridAvailableJobsExpert.TabIndex = 229;
			this.gridAvailableJobsExpert.Title = "Available Expert Jobs";
			this.gridAvailableJobsExpert.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.gridAvailableJobsExpert.TitleHeight = 18;
			this.gridAvailableJobsExpert.TranslationName = "Job Edit";
			this.gridAvailableJobsExpert.CellDoubleClick += new OpenDental.UI.ODGridClickEventHandler(this.gridAvailableJobsExpert_CellDoubleClick);
			this.gridAvailableJobsExpert.CellClick += new OpenDental.UI.ODGridClickEventHandler(this.gridAvailableJobsExpert_CellClick);
			// 
			// tabOnHold
			// 
			this.tabOnHold.Controls.Add(this.gridJobsOnHold);
			this.tabOnHold.Location = new System.Drawing.Point(4, 22);
			this.tabOnHold.Name = "tabOnHold";
			this.tabOnHold.Padding = new System.Windows.Forms.Padding(3);
			this.tabOnHold.Size = new System.Drawing.Size(285, 652);
			this.tabOnHold.TabIndex = 4;
			this.tabOnHold.Text = "On Hold";
			this.tabOnHold.UseVisualStyleBackColor = true;
			// 
			// gridJobsOnHold
			// 
			this.gridJobsOnHold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridJobsOnHold.CellFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.gridJobsOnHold.HasAddButton = false;
			this.gridJobsOnHold.HasDropDowns = false;
			this.gridJobsOnHold.HasMultilineHeaders = true;
			this.gridJobsOnHold.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
			this.gridJobsOnHold.HeaderHeight = 15;
			this.gridJobsOnHold.HScrollVisible = false;
			this.gridJobsOnHold.Location = new System.Drawing.Point(0, 0);
			this.gridJobsOnHold.Name = "gridJobsOnHold";
			this.gridJobsOnHold.ScrollValue = 0;
			this.gridJobsOnHold.Size = new System.Drawing.Size(285, 652);
			this.gridJobsOnHold.TabIndex = 230;
			this.gridJobsOnHold.Title = "Jobs On Hold";
			this.gridJobsOnHold.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.gridJobsOnHold.TitleHeight = 18;
			this.gridJobsOnHold.TranslationName = "Job Edit";
			this.gridJobsOnHold.CellDoubleClick += new OpenDental.UI.ODGridClickEventHandler(this.gridJobsOnHold_CellDoubleClick);
			this.gridJobsOnHold.CellClick += new OpenDental.UI.ODGridClickEventHandler(this.gridJobsOnHold_CellClick);
			// 
			// userControlJobEdit
			// 
			this.userControlJobEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlJobEdit.Enabled = false;
			this.userControlJobEdit.IsOverride = false;
			this.userControlJobEdit.Location = new System.Drawing.Point(0, 0);
			this.userControlJobEdit.Name = "userControlJobEdit";
			this.userControlJobEdit.Size = new System.Drawing.Size(987, 678);
			this.userControlJobEdit.TabIndex = 0;
			this.userControlJobEdit.SaveClick += new System.EventHandler(this.userControlJobEdit_SaveClick);
			this.userControlJobEdit.RequestJob += new OpenDental.InternalTools.Job_Manager.UserControlJobEdit.RequestJobEvent(this.userControlJobEdit_RequestJob);
			this.userControlJobEdit.JobOverride += new OpenDental.InternalTools.Job_Manager.UserControlJobEdit.JobOverrideEvent(this.userControlJobEdit_JobOverride);
			// 
			// userControlQueryEdit
			// 
			this.userControlQueryEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlQueryEdit.IsOverride = false;
			this.userControlQueryEdit.Location = new System.Drawing.Point(0, 0);
			this.userControlQueryEdit.Name = "userControlQueryEdit";
			this.userControlQueryEdit.Size = new System.Drawing.Size(987, 678);
			this.userControlQueryEdit.TabIndex = 1;
			this.userControlQueryEdit.Visible = false;
			this.userControlQueryEdit.SaveClick += new System.EventHandler(this.userControlQueryEdit_SaveClick);
			this.userControlQueryEdit.RequestJob += new OpenDental.InternalTools.Job_Manager.UserControlQueryEdit.RequestJobEvent(this.userControlJobEdit_RequestJob);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(406, 5);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 20);
			this.label5.TabIndex = 241;
			this.label5.Text = "Search";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboUser
			// 
			this.comboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboUser.FormattingEnabled = true;
			this.comboUser.Location = new System.Drawing.Point(219, 6);
			this.comboUser.Name = "comboUser";
			this.comboUser.Size = new System.Drawing.Size(153, 21);
			this.comboUser.TabIndex = 236;
			this.comboUser.SelectionChangeCommitted += new System.EventHandler(this.comboUser_SelectionChangeCommitted);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(163, 9);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 15);
			this.label4.TabIndex = 237;
			this.label4.Text = "User";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// butSearch
			// 
			this.butSearch.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.butSearch.Autosize = true;
			this.butSearch.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butSearch.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butSearch.CornerRadius = 4F;
			this.butSearch.Location = new System.Drawing.Point(649, 4);
			this.butSearch.Name = "butSearch";
			this.butSearch.Size = new System.Drawing.Size(80, 24);
			this.butSearch.TabIndex = 231;
			this.butSearch.Text = "Power Search";
			this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
			// 
			// butMe
			// 
			this.butMe.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.butMe.Autosize = true;
			this.butMe.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butMe.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butMe.CornerRadius = 4F;
			this.butMe.Location = new System.Drawing.Point(372, 6);
			this.butMe.Name = "butMe";
			this.butMe.Size = new System.Drawing.Size(31, 21);
			this.butMe.TabIndex = 239;
			this.butMe.Text = "Me";
			this.butMe.Click += new System.EventHandler(this.butMe_Click);
			// 
			// butAddJob
			// 
			this.butAddJob.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.butAddJob.Autosize = true;
			this.butAddJob.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butAddJob.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butAddJob.CornerRadius = 4F;
			this.butAddJob.Location = new System.Drawing.Point(5, 4);
			this.butAddJob.Name = "butAddJob";
			this.butAddJob.Size = new System.Drawing.Size(75, 24);
			this.butAddJob.TabIndex = 227;
			this.butAddJob.Text = "Add Job";
			this.butAddJob.Click += new System.EventHandler(this.butAddJob_Click);
			// 
			// butDashboard
			// 
			this.butDashboard.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.butDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.butDashboard.Autosize = true;
			this.butDashboard.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butDashboard.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butDashboard.CornerRadius = 4F;
			this.butDashboard.Location = new System.Drawing.Point(1189, 3);
			this.butDashboard.Name = "butDashboard";
			this.butDashboard.Size = new System.Drawing.Size(80, 24);
			this.butDashboard.TabIndex = 243;
			this.butDashboard.Text = "Dashboard";
			this.butDashboard.Click += new System.EventHandler(this.butDashboard_Click);
			// 
			// contextMenuQueries
			// 
			this.contextMenuQueries.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuGoToAccount});
			// 
			// menuGoToAccount
			// 
			this.menuGoToAccount.Index = 0;
			this.menuGoToAccount.Text = "Go To Account";
			this.menuGoToAccount.Click += new System.EventHandler(this.menuGoToAccount_Click);
			// 
			// butBugSubs
			// 
			this.butBugSubs.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.butBugSubs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.butBugSubs.Autosize = true;
			this.butBugSubs.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butBugSubs.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butBugSubs.CornerRadius = 4F;
			this.butBugSubs.Location = new System.Drawing.Point(1090, 3);
			this.butBugSubs.Name = "butBugSubs";
			this.butBugSubs.Size = new System.Drawing.Size(97, 24);
			this.butBugSubs.TabIndex = 244;
			this.butBugSubs.Text = "Bug Submissions";
			this.butBugSubs.Click += new System.EventHandler(this.butBugSubs_Click);
			// 
			// butAddChildJob
			// 
			this.butAddChildJob.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.butAddChildJob.Autosize = true;
			this.butAddChildJob.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butAddChildJob.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butAddChildJob.CornerRadius = 4F;
			this.butAddChildJob.Location = new System.Drawing.Point(85, 4);
			this.butAddChildJob.Name = "butAddChildJob";
			this.butAddChildJob.Size = new System.Drawing.Size(80, 24);
			this.butAddChildJob.TabIndex = 245;
			this.butAddChildJob.Text = "Add Child Job";
			this.butAddChildJob.Click += new System.EventHandler(this.butAddChildJob_Click);
			// 
			// FormJobManager2
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1281, 712);
			this.Controls.Add(this.butAddChildJob);
			this.Controls.Add(this.butBugSubs);
			this.Controls.Add(this.butDashboard);
			this.Controls.Add(this.textSearch);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.butSearch);
			this.Controls.Add(this.butMe);
			this.Controls.Add(this.butAddJob);
			this.Controls.Add(this.comboUser);
			this.Controls.Add(this.label4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormJobManager2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Job Manager 2";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJobManager2_FormClosing);
			this.Load += new System.EventHandler(this.FormJobManager_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControlNav.ResumeLayout(false);
			this.tabAction.ResumeLayout(false);
			this.tabDocumentation.ResumeLayout(false);
			this.tabQuery.ResumeLayout(false);
			this.tabNotify.ResumeLayout(false);
			this.tabTree.ResumeLayout(false);
			this.tabNeedsEngineer.ResumeLayout(false);
			this.tabNeedsExpert.ResumeLayout(false);
			this.tabOnHold.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private UI.Button butAddJob;
		private System.Windows.Forms.CheckBox checkCollapse;
		private System.Windows.Forms.Label labelGroupBy;
		private System.Windows.Forms.TreeView treeJobs;
		private System.Windows.Forms.ComboBox comboGroup;
		private InternalTools.Job_Manager.UserControlJobEdit userControlJobEdit;
		private System.Windows.Forms.CheckBox checkComplete;
		private UI.Button butSearch;
		private System.Windows.Forms.ComboBox comboCategorySearch;
		private System.Windows.Forms.Label labelCategory;
		private UI.ODGrid gridAction;
		private System.Windows.Forms.TabControl tabControlNav;
		private System.Windows.Forms.TabPage tabAction;
		private System.Windows.Forms.ComboBox comboUser;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tabTree;
		private System.Windows.Forms.CheckBox checkShowUnassigned;
		private UI.Button butMe;
		private System.Windows.Forms.TextBox textSearch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkResults;
		private System.Windows.Forms.TabPage tabNeedsEngineer;
		private UI.ODGrid gridAvailableJobs;
		private UI.Button butDashboard;
		private System.Windows.Forms.TabPage tabNeedsExpert;
		private UI.ODGrid gridAvailableJobsExpert;
		private System.Windows.Forms.TabPage tabOnHold;
		private UI.ODGrid gridJobsOnHold;
		private System.Windows.Forms.CheckBox checkCancelled;
		private InternalTools.Job_Manager.UserControlQueryEdit userControlQueryEdit;
		private System.Windows.Forms.TabPage tabQuery;
		private UI.ODGrid gridQueries;
		private System.Windows.Forms.CheckBox checkShowQueryCancelled;
		private System.Windows.Forms.CheckBox checkShowQueryComplete;
		private System.Windows.Forms.TabPage tabDocumentation;
		private UI.ODGrid gridDocumentation;
		private System.Windows.Forms.TabPage tabNotify;
		private UI.ODGrid gridNotify;
		private System.Windows.Forms.ContextMenu contextMenuQueries;
		private System.Windows.Forms.MenuItem menuGoToAccount;
		private UI.Button butBugSubs;
		private UI.Button butAddChildJob;
	}
}