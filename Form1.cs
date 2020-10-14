using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automotiveServiceApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global Variables

        double oilChange, lubeJob, finalCost, radiatorFlush, transmissionFlush, inspection, muffler, tireRotation;

        double partCost, labor;


        private void nonRoutineInfo_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            // Checkbox conditional statements 

            if(oilChangeBox.CheckState == CheckState.Checked)
            {
                oilChange = 26.00;

                finalCost += oilChange;

            }
            if(lubeJobBox.CheckState == CheckState.Checked)
            {
                lubeJob = 18.00;

                finalCost += lubeJob;
     
            }

            if(radiatorFlushBox.CheckState == CheckState.Checked)
            {
                radiatorFlush = 30.00;

                finalCost += radiatorFlush;
            }

            if(TransmissionFlushBox.CheckState == CheckState.Checked)
            {
                transmissionFlush = 80.00;

                finalCost += transmissionFlush;
            }

            if(inspectionBox.CheckState == CheckState.Checked)
            {
                inspection = 15.00;

                finalCost += inspection;
            }

            if(mufflerBox.CheckState == CheckState.Checked)
            {
                muffler = 100.00;

                finalCost += muffler;
            }

            if(tireRotationBox.CheckState == CheckState.Checked)
            {
                tireRotation = 20.00;

                finalCost += tireRotation;
            }       

            partCost = double.Parse(partsCost.Text);

            finalCost += partCost;

            labor = partCost / 60;

            laborCost.Text = labor.ToString("");

            partsTotal.Text = partCost.ToString("");

            finalTotal.Text = finalCost.ToString();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
