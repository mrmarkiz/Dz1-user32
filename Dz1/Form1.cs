using System.Diagnostics;

namespace Dz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            switch (clicked.Tag.ToString())
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                //
                //ме бхиькн
                //
                case "4":
                    break;
            }
        }
    }
}