
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
            WordTitleLabel = new System.Windows.Forms.Label();
            DirectionTitleLabel = new System.Windows.Forms.Label();
            WordTextBox = new Metroit.Windows.Forms.MetTextBox();
            DirectionComboBox = new Metroit.Windows.Forms.MetComboBox();
            FindButton = new System.Windows.Forms.Button();
            CloseButton = new System.Windows.Forms.Button();
            CaseCheckBox = new System.Windows.Forms.CheckBox();
            KanaCheckBox = new System.Windows.Forms.CheckBox();
            WidthCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)WordTextBox).BeginInit();
            SuspendLayout();
            // 
            // WordTitleLabel
            // 
            WordTitleLabel.AutoSize = true;
            WordTitleLabel.Location = new System.Drawing.Point(12, 9);
            WordTitleLabel.Name = "WordTitleLabel";
            WordTitleLabel.Size = new System.Drawing.Size(93, 15);
            WordTitleLabel.TabIndex = 0;
            WordTitleLabel.Text = "検索する文字列";
            WordTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DirectionTitleLabel
            // 
            DirectionTitleLabel.AutoSize = true;
            DirectionTitleLabel.Location = new System.Drawing.Point(46, 39);
            DirectionTitleLabel.Name = "DirectionTitleLabel";
            DirectionTitleLabel.Size = new System.Drawing.Size(59, 15);
            DirectionTitleLabel.TabIndex = 1;
            DirectionTitleLabel.Text = "検索方向";
            DirectionTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WordTextBox
            // 
            WordTextBox.BaseBorderColor = System.Drawing.SystemColors.WindowFrame;
            WordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            WordTextBox.CustomAutoCompleteBox.TargetControl = WordTextBox;
            WordTextBox.FocusBackColor = System.Drawing.Color.LemonChiffon;
            WordTextBox.FocusBorderColor = System.Drawing.SystemColors.WindowFrame;
            WordTextBox.Location = new System.Drawing.Point(111, 7);
            WordTextBox.Name = "WordTextBox";
            WordTextBox.Size = new System.Drawing.Size(320, 23);
            WordTextBox.TabIndex = 10;
            // 
            // DirectionComboBox
            // 
            DirectionComboBox.BaseBorderColor = System.Drawing.SystemColors.WindowFrame;
            DirectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DirectionComboBox.FocusBackColor = System.Drawing.Color.LemonChiffon;
            DirectionComboBox.FocusBorderColor = System.Drawing.SystemColors.WindowFrame;
            DirectionComboBox.FormattingEnabled = true;
            DirectionComboBox.Items.AddRange(new object[] { "行", "列" });
            DirectionComboBox.Location = new System.Drawing.Point(111, 36);
            DirectionComboBox.Name = "DirectionComboBox";
            DirectionComboBox.Size = new System.Drawing.Size(63, 23);
            DirectionComboBox.TabIndex = 20;
            // 
            // FindButton
            // 
            FindButton.Location = new System.Drawing.Point(143, 145);
            FindButton.Name = "FindButton";
            FindButton.Size = new System.Drawing.Size(75, 23);
            FindButton.TabIndex = 60;
            FindButton.Text = "検索(&F)";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            CloseButton.Location = new System.Drawing.Point(224, 145);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new System.Drawing.Size(75, 23);
            CloseButton.TabIndex = 70;
            CloseButton.Text = "閉じる";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // CaseCheckBox
            // 
            CaseCheckBox.AutoSize = true;
            CaseCheckBox.Location = new System.Drawing.Point(111, 65);
            CaseCheckBox.Name = "CaseCheckBox";
            CaseCheckBox.Size = new System.Drawing.Size(169, 19);
            CaseCheckBox.TabIndex = 30;
            CaseCheckBox.Text = "大文字と小文字を区別する";
            CaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // KanaCheckBox
            // 
            KanaCheckBox.AutoSize = true;
            KanaCheckBox.Location = new System.Drawing.Point(111, 90);
            KanaCheckBox.Name = "KanaCheckBox";
            KanaCheckBox.Size = new System.Drawing.Size(170, 19);
            KanaCheckBox.TabIndex = 40;
            KanaCheckBox.Text = "ひらがなとカタカナを区別する";
            KanaCheckBox.UseVisualStyleBackColor = true;
            // 
            // WidthCheckBox
            // 
            WidthCheckBox.AutoSize = true;
            WidthCheckBox.Location = new System.Drawing.Point(111, 115);
            WidthCheckBox.Name = "WidthCheckBox";
            WidthCheckBox.Size = new System.Drawing.Size(143, 19);
            WidthCheckBox.TabIndex = 50;
            WidthCheckBox.Text = "半角と全角を区別する";
            WidthCheckBox.UseVisualStyleBackColor = true;
            // 
            // MetSearchDialog
            // 
            AcceptButton = FindButton;
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            CancelButton = CloseButton;
            ClientSize = new System.Drawing.Size(443, 178);
            Controls.Add(WidthCheckBox);
            Controls.Add(KanaCheckBox);
            Controls.Add(CaseCheckBox);
            Controls.Add(CloseButton);
            Controls.Add(FindButton);
            Controls.Add(DirectionComboBox);
            Controls.Add(WordTextBox);
            Controls.Add(DirectionTitleLabel);
            Controls.Add(WordTitleLabel);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            KeyPreview = true;
            Name = "MetSearchDialog";
            ((System.ComponentModel.ISupportInitialize)WordTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        /// <summary>
        /// 検索する文字列タイトルラベルを取得または設定します。
        /// </summary>
        protected System.Windows.Forms.Label WordTitleLabel;
        /// <summary>
        /// 検索方向タイトルラベルを取得または設定します。
        /// </summary>
        protected System.Windows.Forms.Label DirectionTitleLabel;
        /// <summary>
        /// 検索文字列テキストエリアを取得または設定します。
        /// </summary>
        protected Windows.Forms.MetTextBox WordTextBox;
        /// <summary>
        /// 検索方向プルダウンエリアを取得または設定します。
        /// </summary>
        protected Windows.Forms.MetComboBox DirectionComboBox;
        /// <summary>
        /// 検索ボタンを取得または設定します。
        /// </summary>
        protected System.Windows.Forms.Button FindButton;
        /// <summary>
        /// 閉じるボタンを取得または設定します。
        /// </summary>
        protected System.Windows.Forms.Button CloseButton;
        /// <summary>
        /// 大文字と小文字を区別するチェックエリアを取得または設定します。
        /// </summary>
        protected System.Windows.Forms.CheckBox CaseCheckBox;
        /// <summary>
        /// ひらがなとカタカナを区別するチェックエリアを取得または設定します。
        /// </summary>
        protected System.Windows.Forms.CheckBox KanaCheckBox;
        /// <summary>
        /// 半角と全角を区別するチェックエリアを取得または設定します。
        /// </summary>
        protected System.Windows.Forms.CheckBox WidthCheckBox;
    }
}