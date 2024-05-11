using System;
 
namespace MauiApp1
{
    class WhiteKey : Key
    {
        public WhiteKey()
        {
            UpColor = new Color(0.9f);
            DownColor = new Color(1.0f);
            Color = UpColor;
        }
    }
}
