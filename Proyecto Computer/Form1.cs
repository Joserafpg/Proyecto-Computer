using Bunifu.UI.WinForms.Helpers.Transitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace Proyecto_Computer
{
    public partial class Form1 : Form
    {
        const int time = 300;
        public Form1()
        {
            InitializeComponent();
        }

        async Task EsperarAsync()
        {
            await Task.Delay(time);
        }

        async void dezplazaradentro()
        {
            Transition p = new Transition(new TransitionType_EaseInEaseOut(time));
            p.add(btnmenud, "Left", -29);
            p.add(pmenud, "Left", -64);
            p.run();

            await EsperarAsync();

            btnmenud.Visible = false;
            pmenud.Visible = false;
        }

        void dezplazaraafuera()
        {
            Transition p = new Transition(new TransitionType_EaseInEaseOut(time));
            btnmenud.Visible = true;
            pmenud.Visible = true;
            p.add(btnmenud, "Left", 19);
            p.add(pmenud, "Left", -16);
            p.run();
        }

        void bordesradius()
        {
            int borderRadius = 20;
            GraphicsPath objDraw = new GraphicsPath();

            objDraw.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
            objDraw.AddArc(this.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
            objDraw.AddArc(this.Width - borderRadius * 2, this.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            objDraw.AddArc(0, this.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            objDraw.CloseFigure();

            this.Region = new Region(objDraw);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bordesradius();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(time));
            t.add(menu, "Left", -300);
            t.add(tittlepage, "Left", 70);
            t.add(descriptiontext, "Left", 75);
            t.run();
            pmenud.Visible = true;
            btnmenud.Visible = true;
            
            closemenu.Visible = false;
            dezplazaraafuera();
        }

        private void btnmenud_Click(object sender, EventArgs e)
        {
            Transition l = new Transition(new TransitionType_EaseInEaseOut(time));
            l.add(menu, "Left", 23);
            l.add(tittlepage, "Left", 250);
            l.add(descriptiontext, "Left", 255);
            closemenu.Visible = true;
            l.run();

            dezplazaradentro();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void text(string tittle, string description)
        {
            tittlepage.Text = tittle;
            descriptiontext.Text = description;
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            text("Inicio", "???.");
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            text("Inventario", "???.");
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            text("Clientes", "???.");
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            text("Ventas", "???.");
        }
    }
}
