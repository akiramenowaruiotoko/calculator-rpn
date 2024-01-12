using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_simple
{
    internal class ButtonEX : Button
    {
        // キーボード入力が入力キーとして処理されるかどうかを判定するメソッド
        protected override bool IsInputKey(Keys keyData)
        {
            // キーコードの取得
            Keys kCode = keyData & Keys.KeyCode;

            // Enterキーのアクションを無効にする
            if (kCode == Keys.Enter)
            {
                // Enterキーは入力キーとして処理しない
                return true;
            }

            // ベースクラスのIsInputKeyメソッドに処理を委譲
            return base.IsInputKey(keyData);
        }
    }

}
