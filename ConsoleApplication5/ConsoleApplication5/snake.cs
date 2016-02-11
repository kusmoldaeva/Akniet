using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class snake : Drawer
    {
        public snake()
        {
            color = ConsoleColor.Cyan;
            sign = "*";
        }

        public void Move(int dx, int dy)
        {
            for(int i = body.Count - 1; i>=1; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;    
        }
    }
}
