namespace WinFormsApp1
{
    partial class Form1
    {
        private Button roomButton1;
        private Button roomButton2;
        private Button roomButton3;
        private Button roomButton4;

        private TextBox nameTextBox;
        private MaskedTextBox durationMaskedTextBox;

        private Label labelName;
        private Label labelDuration;

        private Label timerLabel1;
        private Label timerLabel2;
        private Label timerLabel3;
        private Label timerLabel4;

        private Button resetButton;

        private System.Windows.Forms.Timer roomTimer1;
        private System.Windows.Forms.Timer roomTimer2;
        private System.Windows.Forms.Timer roomTimer3;
        private System.Windows.Forms.Timer roomTimer4;

        private void InitializeComponent()
        {
            // ==========================================
            // COMPONENTS
            // ==========================================

            roomButton1 = new Button();
            roomButton2 = new Button();
            roomButton3 = new Button();
            roomButton4 = new Button();

            nameTextBox = new TextBox();
            durationMaskedTextBox = new MaskedTextBox();

            labelName = new Label();
            labelDuration = new Label();

            timerLabel1 = new Label();
            timerLabel2 = new Label();
            timerLabel3 = new Label();
            timerLabel4 = new Label();

            resetButton = new Button();

            roomTimer1 = new System.Windows.Forms.Timer();
            roomTimer2 = new System.Windows.Forms.Timer();
            roomTimer3 = new System.Windows.Forms.Timer();
            roomTimer4 = new System.Windows.Forms.Timer();

            SuspendLayout();

            // ==========================================
            // LABEL - AD SOYAD
            // ==========================================

            labelName.AutoSize = true;
            labelName.Location = new Point(120, 40);
            labelName.Name = "labelName";
            labelName.Size = new Size(56, 15);
            labelName.Text = "Ad soyad";

            // ==========================================
            // TEXTBOX - AD SOYAD
            // ==========================================

            nameTextBox.Location = new Point(120, 60);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(168, 23);

            // ==========================================
            // LABEL - MUDDET
            // ==========================================

            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(120, 100);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(49, 15);
            labelDuration.Text = "Müddət";

            // ==========================================
            // MASKED TEXTBOX - MUDDET
            // ==========================================

            durationMaskedTextBox.Location = new Point(120, 120);
            durationMaskedTextBox.Name = "durationMaskedTextBox";
            durationMaskedTextBox.Size = new Size(168, 23);
            durationMaskedTextBox.Mask = "00";
            durationMaskedTextBox.ValidatingType = typeof(int);

            // ==========================================
            // TIMER LABEL 1
            // ==========================================

            timerLabel1.AutoSize = false;
            timerLabel1.Location = new Point(120, 157);
            timerLabel1.Name = "timerLabel1";
            timerLabel1.Size = new Size(63, 20);
            timerLabel1.Text = "0";
            timerLabel1.TextAlign = ContentAlignment.MiddleCenter;

            // ==========================================
            // TIMER LABEL 2
            // ==========================================

            timerLabel2.AutoSize = false;
            timerLabel2.Location = new Point(225, 157);
            timerLabel2.Name = "timerLabel2";
            timerLabel2.Size = new Size(63, 20);
            timerLabel2.Text = "0";
            timerLabel2.TextAlign = ContentAlignment.MiddleCenter;

            // ==========================================
            // TIMER LABEL 3
            // ==========================================

            timerLabel3.AutoSize = false;
            timerLabel3.Location = new Point(120, 249);
            timerLabel3.Name = "timerLabel3";
            timerLabel3.Size = new Size(63, 20);
            timerLabel3.Text = "0";
            timerLabel3.TextAlign = ContentAlignment.MiddleCenter;

            // ==========================================
            // TIMER LABEL 4
            // ==========================================

            timerLabel4.AutoSize = false;
            timerLabel4.Location = new Point(225, 249);
            timerLabel4.Name = "timerLabel4";
            timerLabel4.Size = new Size(63, 20);
            timerLabel4.Text = "0";
            timerLabel4.TextAlign = ContentAlignment.MiddleCenter;

            // ==========================================
            // OTAQ 1
            // ==========================================

            roomButton1.Location = new Point(120, 181);
            roomButton1.Name = "roomButton1";
            roomButton1.Size = new Size(63, 52);
            roomButton1.Text = "Otaq 1";
            roomButton1.UseVisualStyleBackColor = true;

            // ==========================================
            // OTAQ 2
            // ==========================================

            roomButton2.Location = new Point(225, 181);
            roomButton2.Name = "roomButton2";
            roomButton2.Size = new Size(63, 52);
            roomButton2.Text = "Otaq 2";
            roomButton2.UseVisualStyleBackColor = true;

            // ==========================================
            // OTAQ 3
            // ==========================================

            roomButton3.Location = new Point(120, 273);
            roomButton3.Name = "roomButton3";
            roomButton3.Size = new Size(63, 52);
            roomButton3.Text = "Otaq 3";
            roomButton3.UseVisualStyleBackColor = true;

            // ==========================================
            // OTAQ 4
            // ==========================================

            roomButton4.Location = new Point(225, 273);
            roomButton4.Name = "roomButton4";
            roomButton4.Size = new Size(63, 52);
            roomButton4.Text = "Otaq 4";
            roomButton4.UseVisualStyleBackColor = true;

            // ==========================================
            // RESET BUTTON
            // ==========================================

            resetButton.Location = new Point(160, 350);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(90, 30);
            resetButton.Text = "Sıfırla";
            resetButton.UseVisualStyleBackColor = true;

            // ==========================================
            // TIMER INTERVAL
            // ==========================================

            roomTimer1.Interval = 1000;
            roomTimer2.Interval = 1000;
            roomTimer3.Interval = 1000;
            roomTimer4.Interval = 1000;

            // ==========================================
            // FORM
            // ==========================================

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(800, 450);

            Controls.Add(labelName);
            Controls.Add(nameTextBox);

            Controls.Add(labelDuration);
            Controls.Add(durationMaskedTextBox);

            Controls.Add(timerLabel1);
            Controls.Add(timerLabel2);
            Controls.Add(timerLabel3);
            Controls.Add(timerLabel4);

            Controls.Add(roomButton1);
            Controls.Add(roomButton2);
            Controls.Add(roomButton3);
            Controls.Add(roomButton4);

            Controls.Add(resetButton);

            Name = "Form1";
            Text = "Otel Rezervasiya";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
