using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExSystem.classes
{
    class FormControll
    {
        Form form;
        int eX, eY;
        bool clicked;
       
        public void controllFormButtons(Button btnClose,Button btnSize, Button btnHide, Form form)
        {
            this.form = form;
            btnClose.Click += close;
            btnSize.Click += size;
            btnHide.Click += hide;
        }

        public void dragForm(Panel panel) {
            panel.MouseDown += mDown;
            panel.MouseUp += mUp;
            panel.MouseMove += mMove;
        }

        void mDown(object sender, MouseEventArgs e)
        {
            eX = e.X;
            eY = e.Y;
            this.clicked = true;
        }

        void mUp(object sender, MouseEventArgs e)
        {
            this.clicked = false;
        }

        void mMove(object sender, MouseEventArgs e)
        {
            if (this.clicked) { 
            form.Left +=  + e.X - eX;
            form.Top +=  e.Y - eY;
            }
        }

        //Buttons
        void close(object sender, EventArgs e) {
            Application.Exit();
        }
        void size(object sender, EventArgs e)
        {
            if (form.WindowState != FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else {
                form.WindowState = FormWindowState.Normal;
            }

        }
        void hide(object sender, EventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
        }
        //Buttons end


    }
}
