namespace DevExpressPivot
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.yongheonDBDataSet2 = new DevExpressPivot.yongheonDBDataSet();
            this.fieldUserID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUserName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCreateTime1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldModifyTime1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.yongheonDBDataSet1 = new DevExpressPivot.yongheonDBDataSet();
            this.userTableAdapter1 = new DevExpressPivot.yongheonDBDataSetTableAdapters.UserTableAdapter();
            this.userTableAdapter2 = new DevExpressPivot.yongheonDBDataSetTableAdapters.UserTableAdapter();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yongheonDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yongheonDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataMember = "User";
            this.pivotGridControl1.DataSource = this.yongheonDBDataSet2;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldUserID1,
            this.fieldUserName1,
            this.fieldCreateTime1,
            this.fieldModifyTime1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGridControl1.Size = new System.Drawing.Size(800, 450);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // yongheonDBDataSet2
            // 
            this.yongheonDBDataSet2.DataSetName = "yongheonDBDataSet";
            this.yongheonDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldUserID1
            // 
            this.fieldUserID1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldUserID1.AreaIndex = 0;
            this.fieldUserID1.Caption = "User ID";
            this.fieldUserID1.FieldName = "UserID";
            this.fieldUserID1.Name = "fieldUserID1";
            // 
            // fieldUserName1
            // 
            this.fieldUserName1.AreaIndex = 0;
            this.fieldUserName1.Caption = "User Name";
            this.fieldUserName1.FieldName = "UserName";
            this.fieldUserName1.Name = "fieldUserName1";
            // 
            // fieldCreateTime1
            // 
            this.fieldCreateTime1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCreateTime1.AreaIndex = 1;
            this.fieldCreateTime1.Caption = "CreateTime";
            this.fieldCreateTime1.FieldName = "CreateTime";
            this.fieldCreateTime1.Name = "fieldCreateTime1";
            // 
            // fieldModifyTime1
            // 
            this.fieldModifyTime1.AreaIndex = 1;
            this.fieldModifyTime1.Caption = "ModifyTime";
            this.fieldModifyTime1.FieldName = "ModifyTime";
            this.fieldModifyTime1.Name = "fieldModifyTime1";
            // 
            // yongheonDBDataSet1
            // 
            this.yongheonDBDataSet1.DataSetName = "yongheonDBDataSet";
            this.yongheonDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // userTableAdapter2
            // 
            this.userTableAdapter2.ClearBeforeFill = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(491, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yongheonDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yongheonDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private yongheonDBDataSet yongheonDBDataSet1;
        private yongheonDBDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private yongheonDBDataSet yongheonDBDataSet2;
        private yongheonDBDataSetTableAdapters.UserTableAdapter userTableAdapter2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUserID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUserName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCreateTime1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldModifyTime1;
        private System.Windows.Forms.Button btnExport;
    }
}

