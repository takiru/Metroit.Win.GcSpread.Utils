﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.targetTextBox = new Metroit.Windows.Forms.MetTextBox();
            this.directionComboBox = new Metroit.Windows.Forms.MetComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.caseCheckBox = new System.Windows.Forms.CheckBox();
            this.kanaCheckBox = new System.Windows.Forms.CheckBox();
            this.widthCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.targetTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "検索する文字列";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "検索方向";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // targetTextBox
            // 
            this.targetTextBox.BaseBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.targetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.targetTextBox.CustomAutoCompleteBox.TargetControl = this.targetTextBox;
            this.targetTextBox.FocusBackColor = System.Drawing.Color.LemonChiffon;
            this.targetTextBox.FocusBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.targetTextBox.Location = new System.Drawing.Point(111, 7);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(320, 23);
            this.targetTextBox.TabIndex = 10;
            // 
            // directionComboBox
            // 
            this.directionComboBox.BaseBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.directionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directionComboBox.FocusBackColor = System.Drawing.Color.LemonChiffon;
            this.directionComboBox.FocusBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.directionComboBox.FormattingEnabled = true;
            this.directionComboBox.Items.AddRange(new object[] {
            "行",
            "列"});
            this.directionComboBox.Location = new System.Drawing.Point(111, 36);
            this.directionComboBox.Name = "directionComboBox";
            this.directionComboBox.Size = new System.Drawing.Size(63, 24);
            this.directionComboBox.TabIndex = 20;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(143, 140);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 60;
            this.findButton.Text = "検索(&F)";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(224, 140);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 70;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // caseCheckBox
            // 
            this.caseCheckBox.AutoSize = true;
            this.caseCheckBox.Location = new System.Drawing.Point(109, 65);
            this.caseCheckBox.Name = "caseCheckBox";
            this.caseCheckBox.Size = new System.Drawing.Size(169, 20);
            this.caseCheckBox.TabIndex = 30;
            this.caseCheckBox.Text = "大文字と小文字を区別する";
            this.caseCheckBox.UseVisualStyleBackColor = true;
            // 
            // kanaCheckBox
            // 
            this.kanaCheckBox.AutoSize = true;
            this.kanaCheckBox.Location = new System.Drawing.Point(109, 90);
            this.kanaCheckBox.Name = "kanaCheckBox";
            this.kanaCheckBox.Size = new System.Drawing.Size(170, 20);
            this.kanaCheckBox.TabIndex = 40;
            this.kanaCheckBox.Text = "ひらがなとカタカナを区別する";
            this.kanaCheckBox.UseVisualStyleBackColor = true;
            // 
            // widthCheckBox
            // 
            this.widthCheckBox.AutoSize = true;
            this.widthCheckBox.Location = new System.Drawing.Point(109, 115);
            this.widthCheckBox.Name = "widthCheckBox";
            this.widthCheckBox.Size = new System.Drawing.Size(143, 20);
            this.widthCheckBox.TabIndex = 50;
            this.widthCheckBox.Text = "半角と全角を区別する";
            this.widthCheckBox.UseVisualStyleBackColor = true;
            // 
            // MetSearchDialog
            // 
            this.AcceptButton = this.findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(443, 171);
            this.Controls.Add(this.widthCheckBox);
            this.Controls.Add(this.kanaCheckBox);
            this.Controls.Add(this.caseCheckBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.directionComboBox);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "MetSearchDialog";
            ((System.ComponentModel.ISupportInitialize)(this.targetTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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