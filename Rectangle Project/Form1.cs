using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen green = new Pen(Color.Green);

        System.Drawing.SolidBrush fillGreen = new System.Drawing.SolidBrush(Color.Green);

        Rectangle rectangle = new Rectangle(140, 60, 220, 90);

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(green, rectangle);
            g.FillRectangle(fillGreen, rectangle);



        }


        private void butFindArea_Click(object sender, EventArgs e)
        {
            txtBxAreaInches.Text = (int.Parse(txtBxWidth.Text) * int.Parse(txtBxLength.Text)).ToString();
            txtBxAreaFeet.Text = AreaConverter.ConvertToFeet(int.Parse(txtBxWidth.Text) * int.Parse(txtBxLength.Text)).ToString();
            txtBxAreaMeters.Text = AreaConverter.ConvertToMeters(int.Parse(txtBxWidth.Text) * int.Parse(txtBxLength.Text)).ToString();
            txtBxAreaCentimeters.Text = AreaConverter.ConvertToCentimeters(int.Parse(txtBxWidth.Text) * int.Parse(txtBxLength.Text)).ToString();
        }
        class AreaConverter
        {
            
            public static double ConvertToFeet(int oldUnits)
            {
               
                double feet = 12;
                
                    return feet * oldUnits;
                    
                
                
            }

            public static double ConvertToMeters(int oldUnits)
            {
                double meters = .0254;

                return meters * oldUnits;
                
            }

            public static double ConvertToCentimeters(int oldUnits)
            {
                double centimeters = 2.54;

                return centimeters * oldUnits;
                 
            }

         
        }

        private void txtBxWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only positive whole numbers!");
            }

            
        }

        private void txtBxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
                MessageBox.Show("Enter only positive whole numbers!");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
    



