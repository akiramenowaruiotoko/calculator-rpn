using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_simple
{
    internal class ButtonEX : Button
    {
        protected override bool IsInputKey(Keys keyData)
        {
            Keys kCode = keyData & Keys.KeyCode;
            // Disable enter key action for focused button
            if (kCode == Keys.Enter)
            {
                return true;
            }
            return base.IsInputKey(keyData);
        }
    }
}
