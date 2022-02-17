using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESH_network
{
    internal class Circle : Figure
    {
        static public int local_id;
        public float radius;
        public float radius_squared;
        public float diametr;
        public string local_name;
        public string local_description;
        public string local_location;
        public float diametr_trunsmitter;
        public string buttonmouse;

        public Circle()
        {
            local_id++;
            id = local_id.ToString();
            name = local_name;
            description = local_description;
            location = local_location;
            setRadius(50.0f);
        }

        override public bool test(float x, float y)
        {
            float dx = x - pos_x;
            float dy = y - pos_y;

            if (dx * dx + dy * dy <= radius_squared) return true;
            return false;
        }

        public override void draw(Graphics g)
        {
            float x0 = pos_x - radius;
            float y0 = pos_y - radius;
            Pen p = Pens.Blue;

            switch (buttonmouse)
            {
                case "left":
                    if (selected == true)
                        p = Pens.Green;
                    break;
                case "right":
                    if (selected == true)
                        p = Pens.Pink;
                    break;
            }               
            
            g.DrawEllipse(p, x0, y0, diametr, diametr);
        }

        /*public override void drawTrans(Graphics circle)
        {
            float x0 = pos_x - radius;
            float y0 = pos_y - radius;
            Pen t = Pens.Black;
            if (selected == true)
                circle.DrawEllipse(t = Pens.Black, x0, y0, diametr_trunsmitter, diametr_trunsmitter);
        }*/

        public void setRadius(float new_radius)
        {
            radius = new_radius;
            radius_squared = radius * radius;
            diametr = radius * 2.0f;
            diametr_trunsmitter = diametr * 2.0f;
        }
    }
}
