using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_simple
{
    internal class ButtonEx : Button
    {
        protected override bool IsInputKey(Keys keyData)
        {
            // フォーカスが当たっているボタンのエンターキー動作を無視
            Keys kcode = keyData & Keys.KeyCode;
            if(kcode == Keys.Enter)
            {
                return true;
            }
            return base.IsInputKey(keyData);
        }
    }
}
