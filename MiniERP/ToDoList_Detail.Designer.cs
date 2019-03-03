namespace MiniERP
{
    partial class ToDoList_Detail
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_WareHouse = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_Master = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.lbl_TradeCode = new System.Windows.Forms.Label();
            this.dv_OrderList = new System.Windows.Forms.DataGridView();
            this.lbl_Client = new System.Windows.Forms.Label();
            this.lbl_TotalFee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Client);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_WareHouse);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_EndDate);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Master);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_State);
            this.splitContainer1.Panel1.Controls.Add(this.txt_State);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_TradeCode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_TotalFee);
            this.splitContainer1.Panel2.Controls.Add(this.dv_OrderList);
            this.splitContainer1.Size = new System.Drawing.Size(541, 480);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbl_WareHouse
            // 
            this.lbl_WareHouse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_WareHouse.AutoSize = true;
            this.lbl_WareHouse.Location = new System.Drawing.Point(268, 103);
            this.lbl_WareHouse.Name = "lbl_WareHouse";
            this.lbl_WareHouse.Size = new System.Drawing.Size(65, 12);
            this.lbl_WareHouse.TabIndex = 18;
            this.lbl_WareHouse.Text = "출고창고 : ";
            this.lbl_WareHouse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(268, 65);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(53, 12);
            this.lbl_EndDate.TabIndex = 14;
            this.lbl_EndDate.Text = "납기일 : ";
            this.lbl_EndDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Master
            // 
            this.lbl_Master.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Master.AutoSize = true;
            this.lbl_Master.Location = new System.Drawing.Point(13, 65);
            this.lbl_Master.Name = "lbl_Master";
            this.lbl_Master.Size = new System.Drawing.Size(53, 12);
            this.lbl_Master.TabIndex = 12;
            this.lbl_Master.Text = "담당자 : ";
            this.lbl_Master.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_State
            // 
            this.lbl_State.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(268, 32);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(57, 12);
            this.lbl_State.TabIndex = 5;
            this.lbl_State.Text = "진행 단계";
            this.lbl_State.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_State
            // 
            this.txt_State.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_State.Location = new System.Drawing.Point(331, 29);
            this.txt_State.Name = "txt_State";
            this.txt_State.ReadOnly = true;
            this.txt_State.Size = new System.Drawing.Size(178, 21);
            this.txt_State.TabIndex = 4;
            this.txt_State.Text = "승인전";
            this.txt_State.Click += new System.EventHandler(this.txt_State_Click);
            // 
            // lbl_TradeCode
            // 
            this.lbl_TradeCode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_TradeCode.AutoSize = true;
            this.lbl_TradeCode.Location = new System.Drawing.Point(13, 32);
            this.lbl_TradeCode.Name = "lbl_TradeCode";
            this.lbl_TradeCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_TradeCode.TabIndex = 3;
            this.lbl_TradeCode.Text = "주문번호 : ";
            this.lbl_TradeCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dv_OrderList
            // 
            this.dv_OrderList.AllowUserToAddRows = false;
            this.dv_OrderList.AllowUserToDeleteRows = false;
            this.dv_OrderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dv_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_OrderList.Location = new System.Drawing.Point(3, 1);
            this.dv_OrderList.Name = "dv_OrderList";
            this.dv_OrderList.ReadOnly = true;
            this.dv_OrderList.RowTemplate.Height = 23;
            this.dv_OrderList.Size = new System.Drawing.Size(531, 310);
            this.dv_OrderList.TabIndex = 0;
            // 
            // lbl_Client
            // 
            this.lbl_Client.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.Location = new System.Drawing.Point(13, 103);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(53, 12);
            this.lbl_Client.TabIndex = 135;
            this.lbl_Client.Text = "거래처 : ";
            this.lbl_Client.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_TotalFee
            // 
            this.lbl_TotalFee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_TotalFee.AutoSize = true;
            this.lbl_TotalFee.Location = new System.Drawing.Point(101, 314);
            this.lbl_TotalFee.Name = "lbl_TotalFee";
            this.lbl_TotalFee.Size = new System.Drawing.Size(29, 12);
            this.lbl_TotalFee.TabIndex = 136;
            this.lbl_TotalFee.Text = "총액";
            this.lbl_TotalFee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ToDoList_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ToDoList_Detail";
            this.Size = new System.Drawing.Size(541, 480);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_OrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.TextBox txt_State;
        private System.Windows.Forms.Label lbl_TradeCode;
        private System.Windows.Forms.DataGridView dv_OrderList;
        private System.Windows.Forms.Label lbl_WareHouse;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_Master;
        private System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.Label lbl_TotalFee;
    }
}
