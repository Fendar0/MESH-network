using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESH_network
{
    internal class Circle
    {
        static public int local_id;
        public float radius;
        public float radius_squared;
        public float diametr;
        public string local_name;
        public string local_description;
        public string local_location;
        public float diametr_trunsmitter;
        public float pos_x, pos_y;
        public bool selected;
        public float x0new, y0new, diametrnew;
        public float[][] Arr;

        public Circle()
        {
            local_id++;            
            setRadius(25.0f);
        }

        public void Sizearray(int count)
        {
            Arr = new float[count][];
        }

        public bool test(float x, float y)
        {
            float dx = x - pos_x;
            float dy = y - pos_y;

            if (dx * dx + dy * dy <= radius_squared) return true;
            return false;
        }

        public void draw(Graphics g, string buttonmouse)
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

        public void drawTrans(Graphics circle, string buttonmouse, int value)
        {
            changedlocation(pos_x, pos_y, value, diametr_trunsmitter);
            Pen t = Pens.Black;
            switch (buttonmouse)
            {
                case "left":                    
                    if (selected == true)
                        circle.DrawEllipse(t = Pens.Black, x0new, y0new, diametrnew, diametrnew);
                    break;
                case "right":                    
                    break;
                case "wheelup":                    
                    if (selected == true)
                        circle.DrawEllipse(t = Pens.Black, x0new, y0new, diametrnew, diametrnew);
                    break;
                case "wheeldown":
                    if (selected == true)
                        circle.DrawEllipse(t = Pens.Black, x0new, y0new, diametrnew, diametrnew);
                    break;
            }            
        }

        private void changedlocation(float pos_x,  float pos_y, int value,float diametr_trusmitter)
        {
            x0new = pos_x - diametr - value;
            y0new = pos_y - diametr - value;
            diametrnew = diametr_trunsmitter + value * 2;
        }

        public void setRadius(float new_radius)
        {
            radius = new_radius;
            radius_squared = radius * radius;
            diametr = radius * 2.0f;
            diametr_trunsmitter = radius * 4.0f;
        }
    }
}
