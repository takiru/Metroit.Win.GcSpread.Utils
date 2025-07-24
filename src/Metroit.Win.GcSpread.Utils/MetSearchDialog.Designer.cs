
namespace Metroit.Win.GcSpread.Utils
{
    partial class MetSearchDialog
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            targetTextBox = new Metroit.Windows.Forms.MetTextBox();
            directionComboBox = new Metroit.Windows.Forms.MetComboBox();
            findButton = new System.Windows.Forms.Button();
            closeButton = new System.Windows.Forms.Button();
            caseCheckBox = new System.Windows.Forms.CheckBox();
            kanaCheckBox = new System.Windows.Forms.CheckBox();
            widthCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)targetTextBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "検索する文字列";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(46, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "検索方向";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // targetTextBox
            // 
            targetTextBox.BaseBorderColor = System.Drawing.SystemColors.WindowFrame;
            targetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            targetTextBox.CustomAutoCompleteBox.TargetControl = targetTextBox;
            targetTextBox.FocusBackColor = System.Drawing.Color.LemonChiffon;
            targetTextBox.FocusBorderColor = System.Drawing.SystemColors.WindowFrame;
            targetTextBox.Location = new System.Drawing.Point(111, 7);
            targetTextBox.Name = "targetTextBox";
            targetTextBox.Size = new System.Drawing.Size(320, 23);
            targetTextBox.TabIndex = 10;
            // 
            // directionComboBox
            // 
            directionComboBox.BaseBorderColor = System.Drawing.SystemColors.WindowFrame;
            directionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            directionComboBox.FocusBackColor = System.Drawing.Color.LemonChiffon;
            directionComboBox.FocusBorderColor = System.Drawing.SystemColors.WindowFrame;
            directionComboBox.FormattingEnabled = true;
            directionComboBox.Items.AddRange(new object[] { "行", "列" });
            directionComboBox.Location = new System.Drawing.Point(111, 36);
            directionComboBox.Name = "directionComboBox";
            directionComboBox.Size = new System.Drawing.Size(63, 23);
            directionComboBox.TabIndex = 20;
            // 
            // findButton
            // 
            findButton.Location = new System.Drawing.Point(143, 145);
            findButton.Name = "findButton";
            findButton.Size = new System.Drawing.Size(75, 23);
            findButton.TabIndex = 60;
            findButton.Text = "検索(&F)";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // closeButton
            // 
            closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            closeButton.Location = new System.Drawing.Point(224, 145);
            closeButton.Name = "closeButton";
            closeButton.Size = new System.Drawing.Size(75, 23);
            closeButton.TabIndex = 70;
            closeButton.Text = "閉じる";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // caseCheckBox
            // 
            caseCheckBox.AutoSize = true;
            caseCheckBox.Location = new System.Drawing.Point(111, 65);
            caseCheckBox.Name = "caseCheckBox";
            caseCheckBox.Size = new System.Drawing.Size(169, 19);
            caseCheckBox.TabIndex = 30;
            caseCheckBox.Text = "大文字と小文字を区別する";
            caseCheckBox.UseVisualStyleBackColor = true;
            // 
            // kanaCheckBox
            // 
            kanaCheckBox.AutoSize = true;
            kanaCheckBox.Location = new System.Drawing.Point(111, 90);
            kanaCheckBox.Name = "kanaCheckBox";
            kanaCheckBox.Size = new System.Drawing.Size(170, 19);
            kanaCheckBox.TabIndex = 40;
            kanaCheckBox.Text = "ひらがなとカタカナを区別する";
            kanaCheckBox.UseVisualStyleBackColor = true;
            // 
            // widthCheckBox
            // 
            widthCheckBox.AutoSize = true;
            widthCheckBox.Location = new System.Drawing.Point(111, 115);
            widthCheckBox.Name = "widthCheckBox";
            widthCheckBox.Size = new System.Drawing.Size(143, 19);
            widthCheckBox.TabIndex = 50;
            widthCheckBox.Text = "半角と全角を区別する";
            widthCheckBox.UseVisualStyleBackColor = true;
            // 
            // MetSearchDialog
            // 
            AcceptButton = findButton;
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            CancelButton = closeButton;
            ClientSize = new System.Drawing.Size(443, 178);
            Controls.Add(widthCheckBox);
            Controls.Add(kanaCheckBox);
            Controls.Add(caseCheckBox);
            Controls.Add(closeButton);
            Controls.Add(findButton);
            Controls.Add(directionComboBox);
            Controls.Add(targetTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            KeyPreview = true;
            Name = "MetSearchDialog";
            ((System.ComponentModel.ISupportInitialize)targetTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected Windows.Forms.MetTextBox targetTextBox;
        protected Windows.Forms.MetComboBox directionComboBox;
        protected System.Windows.Forms.Button findButton;
        protected System.Windows.Forms.Button closeButton;
        protected System.Windows.Forms.CheckBox caseCheckBox;
        protected System.Windows.Forms.CheckBox kanaCheckBox;
        protected System.Windows.Forms.CheckBox widthCheckBox;
    }
}