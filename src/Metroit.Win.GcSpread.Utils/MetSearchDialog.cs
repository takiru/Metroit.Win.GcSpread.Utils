﻿using FarPoint.Win.Spread;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Metroit.Win.GcSpread.Utils
{
    /// <summary>
    /// セルの値を検索する画面を提供します。
    /// </summary>
    public partial class MetSearchDialog : CustomSearchDialog
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public MetSearchDialog()
        {
            InitializeComponent();
            directionComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 検索文字列を検索する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(targetTextBox.Text))
            {
                return;
            }
            if (FpSpread.ActiveSheet.RowCount == 0 || FpSpread.ActiveSheet.ColumnCount == 0)
            {
                return;
            }

            if (directionComboBox.SelectedIndex == 0)
            {
                // 行方向へ検索
                FindTextByRowDirection(targetTextBox.Text);
            }
            else
            {
                // 列方向へ検索
                FindTextByColumnDirection(targetTextBox.Text);
            }
        }

        /// <summary>
        /// 画面を閉じる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 行方向へ検索文字列を検索する。
        /// </summary>
        /// <param name="text">検索文字列。</param>
        private void FindTextByRowDirection(string text)
        {
            var compareOptions = GetExecuteCompareOptions();

            var finded = FindTextByRowDirection(text, FpSpread.ActiveSheet.ActiveRowIndex, FpSpread.ActiveSheet.Rows.Count - 1, FpSpread.ActiveSheet.ActiveColumnIndex + 1, compareOptions);
            if (finded)
            {
                return;
            }

            finded = FindTextByRowDirection(text, 0, FpSpread.ActiveSheet.ActiveRowIndex, 0, compareOptions);
            if (finded)
            {
                return;
            }

            MessageBox.Show("検索条件に一致するデータが見つかりません。", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 行方向へ検索文字列を検索する。
        /// </summary>
        /// <param name="text">検索文字列。</param>
        /// <param name="startRow">開始行インデックス。</param>
        /// <param name="endRow">終了行インデックス。</param>
        /// <param name="initColumn">開始列インデックス。</param>
        /// <param name="compareOptions">比較区別フラグ。</param>
        /// <returns>true:見つかった, false:見つからなかった。</returns>
        private bool FindTextByRowDirection(string text, int startRow, int endRow, int initColumn, CompareOptions compareOptions)
        {
            for (var row = startRow; row <= endRow; row++)
            {
                // 非表示行は対象外
                if (!FpSpread.ActiveSheet.Rows[row].Visible)
                {
                    continue;
                }

                var startColumn = initColumn;
                if (row != startRow)
                {
                    startColumn = 0;
                }

                for (var column = startColumn; column < FpSpread.ActiveSheet.Columns.Count; column++)
                {
                    // 非表示列は対象外
                    if (!FpSpread.ActiveSheet.Columns[column].Visible)
                    {
                        continue;
                    }

                    var cell = FpSpread.ActiveSheet.Cells[row, column];
                    if (FindValue(text, cell, compareOptions))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// 列方向へ検索文字列を検索する。
        /// </summary>
        /// <param name="text">検索文字列。</param>
        private void FindTextByColumnDirection(string text)
        {
            var compareOptions = GetExecuteCompareOptions();

            var finded = FindTextByColumnDirection(text, FpSpread.ActiveSheet.ActiveColumnIndex, FpSpread.ActiveSheet.Columns.Count - 1, FpSpread.ActiveSheet.ActiveRowIndex + 1, compareOptions);
            if (finded)
            {
                return;
            }

            finded = FindTextByColumnDirection(text, 0, FpSpread.ActiveSheet.ActiveColumnIndex, 0, compareOptions);
            if (finded)
            {
                return;
            }

            MessageBox.Show("検索条件に一致するデータが見つかりません。", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 列方向へ検索文字列を検索する。
        /// </summary>
        /// <param name="text">検索文字列。</param>
        /// <param name="startColumn">開始列インデックス。</param>
        /// <param name="endColumn">終了列インデックス。</param>
        /// <param name="initRow">開始行インデックス。</param>
        /// <param name="compareOptions">比較区別フラグ。</param>
        /// <returns>true:見つかった, false:見つからなかった。</returns>
        private bool FindTextByColumnDirection(string text, int startColumn, int endColumn, int initRow, CompareOptions compareOptions)
        {
            for (var column = startColumn; column <= endColumn; column++)
            {
                // 非表示列は対象外
                if (!FpSpread.ActiveSheet.Columns[column].Visible)
                {
                    continue;
                }

                var startRow = initRow;
                if (column != startColumn)
                {
                    startRow = 0;
                }

                for (var row = startRow; row < FpSpread.ActiveSheet.Rows.Count; row++)
                {
                    // 非表示行は対象外
                    if (!FpSpread.ActiveSheet.Rows[row].Visible)
                    {
                        continue;
                    }

                    var cell = FpSpread.ActiveSheet.Cells[row, column];
                    if (FindValue(text, cell, compareOptions))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// 利用する比較区別フラグを取得する。
        /// </summary>
        /// <returns>比較区別フラグ。</returns>
        private CompareOptions GetExecuteCompareOptions()
        {
            var compareOptions = CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth;

            if (caseCheckBox.Checked)
            {
                compareOptions ^= CompareOptions.IgnoreCase;
            }
            if (kanaCheckBox.Checked)
            {
                compareOptions ^= CompareOptions.IgnoreKanaType;
            }
            if (widthCheckBox.Checked)
            {
                compareOptions ^= CompareOptions.IgnoreWidth;
            }

            return compareOptions;
        }

        /// <summary>
        /// セルに値が含まれるかどうかを検索する。
        /// </summary>
        /// <param name="text">検索文字列。</param>
        /// <param name="cell">セルオブジェクト。</param>
        /// <param name="compareOptions">比較区別フラグ。</param>
        /// <returns>true:見つかった, false:見つからなかった。</returns>
        private bool FindValue(string text, Cell cell, CompareOptions compareOptions)
        {
            if (cell.Value == null)
            {
                return false;
            }

            var ci = CultureInfo.CurrentCulture.CompareInfo;
            if (ci.IndexOf(cell.Value.ToString(), text, compareOptions) < 0)
            {
                if (ci.IndexOf(cell.Text, text, compareOptions) < 0)
                {
                    return false;
                }
            }

            FpSpread.ActiveSheet.SetActiveCell(cell.Row.Index, cell.Column.Index);
            FpSpread.ActiveSheet.FpSpread.ShowActiveCell(VerticalPosition.Nearest, HorizontalPosition.Nearest);

            return true;
        }
    }
}
