﻿namespace MiniERP.View
{
    partial class ToDoList
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
            this.lbl_Ordcode = new System.Windows.Forms.Label();
            this.btn_Layer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Ordcode
            // 
            this.lbl_Ordcode.AutoSize = true;
            this.lbl_Ordcode.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Ordcode.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Ordcode.Location = new System.Drawing.Point(3, 13);
            this.lbl_Ordcode.Name = "lbl_Ordcode";
            this.lbl_Ordcode.Size = new System.Drawing.Size(94, 21);
            this.lbl_Ordcode.TabIndex = 0;
            this.lbl_Ordcode.Text = "주문번호";
            // 
            // btn_Layer
            // 
            this.btn_Layer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Layer.Location = new System.Drawing.Point(125, 6);
            this.btn_Layer.Name = "btn_Layer";
            this.btn_Layer.Size = new System.Drawing.Size(194, 33);
            this.btn_Layer.TabIndex = 1;
            this.btn_Layer.Text = "창고이동단계";
            this.btn_Layer.UseVisualStyleBackColor = false;
            this.btn_Layer.Click += new System.EventHandler(this.btn_Layer_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Layer);
            this.Controls.Add(this.lbl_Ordcode);
            this.Name = "ToDoList";
            this.Size = new System.Drawing.Size(332, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ordcode;
        private System.Windows.Forms.Button btn_Layer;
    }
}
