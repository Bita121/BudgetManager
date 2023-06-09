﻿namespace BudgetManager
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.AddExpense = this.Factory.CreateRibbonButton();
            this.AddIncome = this.Factory.CreateRibbonButton();
            this.GenerateReport = this.Factory.CreateRibbonButton();
            this.GoalsSetting = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.AddExpense);
            this.group1.Items.Add(this.AddIncome);
            this.group1.Items.Add(this.GenerateReport);
            this.group1.Items.Add(this.GoalsSetting);
            this.group1.Label = "BudgetManager";
            this.group1.Name = "group1";
            // 
            // AddExpense
            // 
            this.AddExpense.Label = "Add Expense";
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddExpense_Click);
            // 
            // AddIncome
            // 
            this.AddIncome.Label = "Add Income";
            this.AddIncome.Name = "AddIncome";
            this.AddIncome.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddIncome_Click);
            // 
            // GenerateReport
            // 
            this.GenerateReport.Label = "Generate Report";
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GenerateReport_Click);
            // 
            // GoalsSetting
            // 
            this.GoalsSetting.Label = "Goals Setting";
            this.GoalsSetting.Name = "GoalsSetting";
            this.GoalsSetting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AddExpense;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AddIncome;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton GenerateReport;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton GoalsSetting;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
