using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESH_network
{
    internal class Figure
    {
        public float pos_x, pos_y;
        public string id;
        public bool selected;
        public string name;
        public string description;
        public string location;

        virtual public bool test(float x, float y)
        {
            return false;
        }

        virtual public void draw(Graphics g, string buttonmouse)
        {

        }

        virtual public void drawTrans(Graphics circle, string buttonmouse)
        {

        }
    }
}
