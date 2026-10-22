namespace CITC2311_PC1_Lab08
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            PositionLbl = new Label();
            RobotPnl = new Panel();
            ArrowLbl = new Label();
            NBtn = new Button();
            WBtn = new Button();
            EBtn = new Button();
            SBtn = new Button();
            Go1Btn = new Button();
            Go10Btn = new Button();
            ExitBtn = new Button();
            RobotPnl.SuspendLayout();
            SuspendLayout();
            // 
            // PositionLbl
            // 
            PositionLbl.AutoSize = true;
            PositionLbl.Location = new Point(20, 15);
            PositionLbl.Name = "PositionLbl";
            PositionLbl.Size = new Size(60, 15);
            PositionLbl.TabIndex = 0;
            PositionLbl.Text = "{X=0,Y=0}";
            // 
            // RobotPnl
            // 
            RobotPnl.BorderStyle = BorderStyle.FixedSingle;
            RobotPnl.Controls.Add(ArrowLbl);
            RobotPnl.Location = new Point(20, 45);
            RobotPnl.Name = "RobotPnl";
            RobotPnl.Size = new Size(300, 300);
            RobotPnl.TabIndex = 1;
            // 
            // ArrowLbl
            // 
            ArrowLbl.Font = new Font("Wingdings", 20F);
            ArrowLbl.Location = new Point(135, 135);
            ArrowLbl.Name = "ArrowLbl";
            ArrowLbl.Size = new Size(30, 30);
            ArrowLbl.TabIndex = 0;
            ArrowLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NBtn
            // 
            NBtn.Location = new Point(152, 355);
            NBtn.Name = "NBtn";
            NBtn.Size = new Size(36, 23);
            NBtn.TabIndex = 2;
            NBtn.Text = "N";
            NBtn.UseVisualStyleBackColor = true;
            NBtn.Click += NBtn_Click;
            // 
            // WBtn
            // 
            WBtn.Location = new Point(116, 379);
            WBtn.Name = "WBtn";
            WBtn.Size = new Size(36, 23);
            WBtn.TabIndex = 3;
            WBtn.Text = "W";
            WBtn.UseVisualStyleBackColor = true;
            WBtn.Click += WBtn_Click;
            // 
            // EBtn
            // 
            EBtn.Location = new Point(188, 379);
            EBtn.Name = "EBtn";
            EBtn.Size = new Size(36, 23);
            EBtn.TabIndex = 4;
            EBtn.Text = "E";
            EBtn.UseVisualStyleBackColor = true;
            EBtn.Click += EBtn_Click;
            // 
            // SBtn
            // 
            SBtn.Location = new Point(152, 403);
            SBtn.Name = "SBtn";
            SBtn.Size = new Size(36, 23);
            SBtn.TabIndex = 5;
            SBtn.Text = "S";
            SBtn.UseVisualStyleBackColor = true;
            SBtn.Click += SBtn_Click;
            // 
            // Go1Btn
            // 
            Go1Btn.Location = new Point(20, 379);
            Go1Btn.Name = "Go1Btn";
            Go1Btn.Size = new Size(75, 23);
            Go1Btn.TabIndex = 6;
            Go1Btn.Text = "Go 1";
            Go1Btn.UseVisualStyleBackColor = true;
            Go1Btn.Click += Go1Btn_Click;
            // 
            // Go10Btn
            // 
            Go10Btn.Location = new Point(245, 379);
            Go10Btn.Name = "Go10Btn";
            Go10Btn.Size = new Size(75, 23);
            Go10Btn.TabIndex = 7;
            Go10Btn.Text = "Go 10";
            Go10Btn.UseVisualStyleBackColor = true;
            Go10Btn.Click += Go10Btn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(245, 432);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 27);
            ExitBtn.TabIndex = 8;
            ExitBtn.Text = "E&xit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 480);
            Controls.Add(ExitBtn);
            Controls.Add(Go10Btn);
            Controls.Add(Go1Btn);
            Controls.Add(SBtn);
            Controls.Add(EBtn);
            Controls.Add(WBtn);
            Controls.Add(NBtn);
            Controls.Add(RobotPnl);
            Controls.Add(PositionLbl);
            Name = "Form1";
            Text = "Robot";
            Load += Form1_Load;
            RobotPnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PositionLbl;
        private Panel RobotPnl;
        private Label ArrowLbl;
        private Button NBtn;
        private Button WBtn;
        private Button EBtn;
        private Button SBtn;
        private Button Go1Btn;
        private Button Go10Btn;
        private Button ExitBtn;
    }
}
