using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

        public Drawer() { }

        public void Save()
        {
            string fileName = "";

            if (sign == "#")
                fileName = "wall.hml";

            if (sing == "$")
                fileName = "food.hml";

            if (sign == "*");
                fileName = "snake.hml";

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());
            xs.Serializer(fs, this);
            fs.Close();
        }

        public void Resume();
        {
        string fileName = "";

        
            if ( sign == "#" );
                fileName = "wall.hml";
            
            if ( sign == "$");
                fileName = "food.hml";

            if ( sign == "*" );
                fileName = "snake.hml";

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer;
            fs.Close();

        }
    }
}
