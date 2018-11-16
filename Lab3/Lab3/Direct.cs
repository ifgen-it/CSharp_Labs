using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Direct
    {
        private float speed;
        private float dx;
        private float dy;

        public Direct(float Speed, float dX, float dY)
        {
            speed = Speed;
            dx = dX;
            dy = dY;
        }

        public float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public float DX
        {
            get
            {
                return dx;
            }
            set
            {
                dx = value;
            }
        }

        public float DY
        {
            get
            {
                return dy;
            }
            set
            {
                dy = value;
            }
        }
    }
}
