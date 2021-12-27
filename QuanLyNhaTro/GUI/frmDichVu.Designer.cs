namespace QuanLyNhaTro.GUI
{
    partial class frmDichVu
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gcDichVu = new DevExpress.XtraGrid.GridControl();
            this.gvDichVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.gcDichVu);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 97.20004F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(821, 479);
            this.tablePanel1.TabIndex = 0;
            // 
            // gcDichVu
            // 
            this.tablePanel1.SetColumn(this.gcDichVu, 0);
            this.gcDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDichVu.Location = new System.Drawing.Point(3, 100);
            this.gcDichVu.MainView = this.gvDichVu;
            this.gcDichVu.Name = "gcDichVu";
            this.tablePanel1.SetRow(this.gcDichVu, 1);
            this.gcDichVu.Size = new System.Drawing.Size(815, 376);
            this.gcDichVu.TabIndex = 0;
            this.gcDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDichVu});
            // 
            // gvDichVu
            // 
            this.gvDichVu.GridControl = this.gcDichVu;
            this.gvDichVu.Name = "gvDichVu";
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 479);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gcDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDichVu;
    }
}