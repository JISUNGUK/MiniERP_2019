namespace MiniERP.View.StockManagement
{
    partial class Frm_WarehouseMovement
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
            this.lv_beforeStock = new System.Windows.Forms.ListView();
            this.before_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.before_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.before_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmb_before = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_after = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_afterStock = new System.Windows.Forms.ListView();
            this.after_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.after_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.after_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_moving = new System.Windows.Forms.Button();
            this.dt_moveDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_beforeStock
            // 
            this.lv_beforeStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lv_beforeStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.before_code,
            this.before_name,
            this.before_count});
            this.lv_beforeStock.Location = new System.Drawing.Point(54, 71);
            this.lv_beforeStock.MultiSelect = false;
            this.lv_beforeStock.Name = "lv_beforeStock";
            this.lv_beforeStock.Size = new System.Drawing.Size(289, 302);
            this.lv_beforeStock.TabIndex = 0;
            this.lv_beforeStock.UseCompatibleStateImageBehavior = false;
            this.lv_beforeStock.View = System.Windows.Forms.View.Details;
            // 
            // before_code
            // 
            this.before_code.Text = "품목번호";
            this.before_code.Width = 87;
            // 
            // before_name
            // 
            this.before_name.Text = "품목이름";
            this.before_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.before_name.Width = 121;
            // 
            // before_count
            // 
            this.before_count.Text = "갯수";
            this.before_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.before_count.Width = 77;
            // 
            // cmb_before
            // 
            this.cmb_before.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_before.FormattingEnabled = true;
            this.cmb_before.Location = new System.Drawing.Point(117, 22);
            this.cmb_before.Name = "cmb_before";
            this.cmb_before.Size = new System.Drawing.Size(226, 20);
            this.cmb_before.TabIndex = 4;
            this.cmb_before.SelectedIndexChanged += new System.EventHandler(this.cmb_before_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "현재 창고";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "현재 창고 품목";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "목표 창고";
            // 
            // cmb_after
            // 
            this.cmb_after.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_after.FormattingEnabled = true;
            this.cmb_after.Location = new System.Drawing.Point(532, 22);
            this.cmb_after.Name = "cmb_after";
            this.cmb_after.Size = new System.Drawing.Size(228, 20);
            this.cmb_after.TabIndex = 7;
            this.cmb_after.DropDown += new System.EventHandler(this.cmb_after_DropDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "이동 품목";
            // 
            // lv_afterStock
            // 
            this.lv_afterStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lv_afterStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.after_code,
            this.after_name,
            this.after_count});
            this.lv_afterStock.Location = new System.Drawing.Point(471, 71);
            this.lv_afterStock.Name = "lv_afterStock";
            this.lv_afterStock.Size = new System.Drawing.Size(289, 302);
            this.lv_afterStock.TabIndex = 11;
            this.lv_afterStock.UseCompatibleStateImageBehavior = false;
            this.lv_afterStock.View = System.Windows.Forms.View.Details;
            // 
            // after_code
            // 
            this.after_code.Text = "품목번호";
            this.after_code.Width = 87;
            // 
            // after_name
            // 
            this.after_name.Text = "품목이름";
            this.after_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.after_name.Width = 121;
            // 
            // after_count
            // 
            this.after_count.Text = "갯수";
            this.after_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.after_count.Width = 77;
            // 
            // btn_move
            // 
            this.btn_move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_move.Location = new System.Drawing.Point(377, 157);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(51, 35);
            this.btn_move.TabIndex = 12;
            this.btn_move.Text = ">>";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(377, 254);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(51, 35);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "<<";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_clear.Location = new System.Drawing.Point(471, 379);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(289, 23);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "비우기";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_moving
            // 
            this.btn_moving.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_moving.Location = new System.Drawing.Point(695, 408);
            this.btn_moving.Name = "btn_moving";
            this.btn_moving.Size = new System.Drawing.Size(65, 23);
            this.btn_moving.TabIndex = 15;
            this.btn_moving.Text = "이동";
            this.btn_moving.UseVisualStyleBackColor = true;
            this.btn_moving.Click += new System.EventHandler(this.btn_moving_Click);
            // 
            // dt_moveDate
            // 
            this.dt_moveDate.Location = new System.Drawing.Point(532, 408);
            this.dt_moveDate.MinDate = new System.DateTime(2019, 3, 3, 0, 0, 0, 0);
            this.dt_moveDate.Name = "dt_moveDate";
            this.dt_moveDate.Size = new System.Drawing.Size(157, 21);
            this.dt_moveDate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "이동날짜: ";
            // 
            // Frm_WarehouseMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_moveDate);
            this.Controls.Add(this.btn_moving);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.lv_afterStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_after);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_before);
            this.Controls.Add(this.lv_beforeStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_WarehouseMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "창고 이동";
            this.Load += new System.EventHandler(this.Frm_WarehouseMovement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_beforeStock;
        private System.Windows.Forms.ComboBox cmb_before;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_after;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_afterStock;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_moving;
        private System.Windows.Forms.ColumnHeader before_code;
        private System.Windows.Forms.ColumnHeader before_name;
        private System.Windows.Forms.ColumnHeader before_count;
        private System.Windows.Forms.ColumnHeader after_code;
        private System.Windows.Forms.ColumnHeader after_name;
        private System.Windows.Forms.ColumnHeader after_count;
        private System.Windows.Forms.DateTimePicker dt_moveDate;
        private System.Windows.Forms.Label label5;
    }
}