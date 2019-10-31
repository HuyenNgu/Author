using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_My_Point
{
    class MyPoint
    {
        private int x;
        private int y;
        public MyPoint()
        {
            this.x = this.y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public int[] GetXY()
        {
            //hoặc return new int[] {this.X, this.Y}
            int[] xy = new int[2];
            xy[0] = this.x;
            xy[1] = this.y;
            return xy;
        }
        public void SetX(int x)
        {

        }
        public void SetY(int y)
        {

        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return String.Format("({0},{1})", this.x, this.y);
        }
        public double Distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.x - x, 2) 
                + Math.Pow(this.y - y, 2));
        }
        public double Distance(MyPoint point)
        {
            return Distance(point.GetX(), point.GetY());
        }
        public double Distance()
        {
            return Distance(0, 0);
        }
    }
    
}
