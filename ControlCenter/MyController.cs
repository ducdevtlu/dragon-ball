using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class MyController
{
    private static bool isChatting = false;

    public static void update()
    {
        if (GameCanvas.gameTick % 20 == 0)
        {
            if (!isChatting)
            {
                isChatting = true;
                GameScr.info1.addInfo(Constants.APP_NAME, 0);
                new Thread(() =>
                {
                    Thread.Sleep(5000);
                    isChatting = false;
                }).Start();
            }
        }
    }
}
