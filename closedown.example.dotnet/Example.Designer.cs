namespace Closedown.Example.Csharp
{
    partial class Example
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckCorpNums = new System.Windows.Forms.Button();
            this.btnCheckCorpNum = new System.Windows.Forms.Button();
            this.txtCorpNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetBalance = new System.Windows.Forms.Button();
            this.btnUnitCost = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnCheckCorpNums);
            this.groupBox1.Controls.Add(this.btnCheckCorpNum);
            this.groupBox1.Controls.Add(this.txtCorpNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(37, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "휴폐업조회 API";
            // 
            // btnCheckCorpNums
            // 
            this.btnCheckCorpNums.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckCorpNums.Location = new System.Drawing.Point(363, 18);
            this.btnCheckCorpNums.Name = "btnCheckCorpNums";
            this.btnCheckCorpNums.Size = new System.Drawing.Size(77, 28);
            this.btnCheckCorpNums.TabIndex = 3;
            this.btnCheckCorpNums.Text = "대량조회";
            this.btnCheckCorpNums.UseVisualStyleBackColor = true;
            this.btnCheckCorpNums.Click += new System.EventHandler(this.btnCheckCorpNums_Click);
            // 
            // btnCheckCorpNum
            // 
            this.btnCheckCorpNum.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckCorpNum.Location = new System.Drawing.Point(272, 18);
            this.btnCheckCorpNum.Name = "btnCheckCorpNum";
            this.btnCheckCorpNum.Size = new System.Drawing.Size(77, 28);
            this.btnCheckCorpNum.TabIndex = 2;
            this.btnCheckCorpNum.Text = "조회";
            this.btnCheckCorpNum.UseVisualStyleBackColor = true;
            this.btnCheckCorpNum.Click += new System.EventHandler(this.btnCheckCorpNum_Click);
            // 
            // txtCorpNum
            // 
            this.txtCorpNum.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCorpNum.Location = new System.Drawing.Point(92, 22);
            this.txtCorpNum.Name = "txtCorpNum";
            this.txtCorpNum.Size = new System.Drawing.Size(168, 21);
            this.txtCorpNum.TabIndex = 1;
            this.txtCorpNum.Text = "4108600477";
            this.txtCorpNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCorpNum_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사업자번호 : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetBalance);
            this.groupBox2.Controls.Add(this.btnUnitCost);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(39, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "과금 API";
            // 
            // btnGetBalance
            // 
            this.btnGetBalance.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGetBalance.Location = new System.Drawing.Point(136, 19);
            this.btnGetBalance.Name = "btnGetBalance";
            this.btnGetBalance.Size = new System.Drawing.Size(103, 29);
            this.btnGetBalance.TabIndex = 1;
            this.btnGetBalance.Text = "잔여포인트 확인";
            this.btnGetBalance.UseVisualStyleBackColor = true;
            this.btnGetBalance.Click += new System.EventHandler(this.btnGetBalance_Click);
            // 
            // btnUnitCost
            // 
            this.btnUnitCost.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUnitCost.Location = new System.Drawing.Point(18, 19);
            this.btnUnitCost.Name = "btnUnitCost";
            this.btnUnitCost.Size = new System.Drawing.Size(103, 29);
            this.btnUnitCost.TabIndex = 0;
            this.btnUnitCost.Text = "조회단가 확인";
            this.btnUnitCost.UseVisualStyleBackColor = true;
            this.btnUnitCost.Click += new System.EventHandler(this.btnUnitCost_Click);
            // 
            // Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 200);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Example";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "휴폐업조회 API SDK Example for dotnet(V3.5)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCorpNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckCorpNums;
        private System.Windows.Forms.Button btnCheckCorpNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetBalance;
        private System.Windows.Forms.Button btnUnitCost;
    }
}

