using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CustomerData;


namespace CPRG200_Lab1_nick_sim
{
    /* Calculates the City kWh cost.
     * Author: Nicholas Sim
     * Date: December 5, 2018
    */
    public partial class Form1 : Form
    {
        public static Dictionary<int, Customer> CustomerInformation = new Dictionary<int,Customer>();
        //BASE RATES
        private double RESIDENTAL_BASE = 6.00;
        private double COMMERCIAL_BASE = 60.00;
        private double INDUSTRIAL_PEAK = 76.00;
        private double INDUSTRIAL_OFF_PEAK = 40.00;

        //kWh Rates
        private double RESIDENTAL_KWH = 0.052;
        private double COMMERCIAL_KWH = 0.045;
        private double INDUSTRIAL_PEAK_KWH = 0.065;
        private double INDUSTRIAL_OFF_PEAK_KWH = 0.028;

        public Form1()
        {
            InitializeComponent();
            updateStats();
            customertypebox.SelectedIndex = 0;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customertypebox_SelectedIndexChanged(object sender, EventArgs e) //Switches between the different types of customers.
        {
            if(customertypebox.SelectedIndex == 0)
            {
                NonIndustrialForm(true, "Residental");
                baseRateBox.Text = RESIDENTAL_BASE.ToString("c");
                kwhIncludedBox.Text = "None";
                kwhcostbox.Text = RESIDENTAL_KWH.ToString("c");
                IndustrialForm(false, null);
            }
            if(customertypebox.SelectedIndex == 1)
            {
                NonIndustrialForm(true, "Commercial");
                baseRateBox.Text = COMMERCIAL_BASE.ToString("c");
                kwhIncludedBox.Text = "1000kWh";
                kwhcostbox.Text = COMMERCIAL_KWH.ToString("c");
                IndustrialForm(false, null);
            }
            if(customertypebox.SelectedIndex == 2)
            {
                NonIndustrialForm(false, null);
                IndustrialForm(true, "Industrial");
                peakBaseRate.Text = INDUSTRIAL_PEAK.ToString("c");
                nonpeakBaseRate.Text = INDUSTRIAL_OFF_PEAK.ToString("c");
                peakKwhIncluded.Text = "1000kWh";
                nonpeakKwhIncluded.Text = "1000kWh";
                peakKwhRate.Text = INDUSTRIAL_PEAK_KWH.ToString("c");
                nonpeakKwhRate.Text = INDUSTRIAL_OFF_PEAK_KWH.ToString("c");
            } 
        }

        private void NonIndustrialForm(Boolean show, String name) //Toggle the non industrial box.
        {
            groupBox1.Visible = show;
            groupBox1.Text = name;
        }

        private void IndustrialForm(Boolean show, String name) //Toggle the industrial box.
        {
            groupBox2.Visible = show;
            groupBox2.Text = name;
        }

        private void button_exit_Click(object sender, EventArgs e) //Closes the program when the "Exit" button is clicked.
        {
            System.Windows.Forms.Application.Exit(); //Exits program.
        }

        private void button1_Click(object sender, EventArgs e) //Calculates the total kwh.
        {
          double charge;
          
            if (customertypebox.SelectedIndex == 0) //Checks if the combo box is selected on "Residental"
            {
                charge = RESIDENTAL_BASE;
                charge += validateParse(kwhused) * RESIDENTAL_KWH;
                totalCostBox.Text = charge.ToString("c");
            }
            if (customertypebox.SelectedIndex == 1) //Checks if the combo box is selected on "Commercial"
            {
                charge = COMMERCIAL_BASE;
                if(validateParse(kwhused) > 1000)
                {
                    charge += (validateParse(kwhused) - 1000) * COMMERCIAL_KWH; //Get the rate, if its over 1,000 kwh subtract 1,000 from it.
                }
                totalCostBox.Text = charge.ToString("c");
            }
            if (customertypebox.SelectedIndex == 2) //Checks if the combo box is selected on "Industrial"
            {
                double peak;
                double non;
                charge = INDUSTRIAL_PEAK;
                if (validateParse(peakKwhUsed) > 1000)
                {
                    charge += (validateParse(peakKwhUsed) - 1000) * INDUSTRIAL_PEAK_KWH; //Get the rate, if its over 1,000 kwh subtract 1,000 from it.
                }
                peakTotal.Text = charge.ToString("c");
                peak = charge;
                //NON PEAK
                charge = INDUSTRIAL_OFF_PEAK;
                if (validateParse(nonpeakKwhUsed) > 1000)
                {
                    charge += (validateParse(nonpeakKwhUsed) - 1000) * INDUSTRIAL_OFF_PEAK_KWH; //Get the rate, if its over 1,000 kwh subtract 1,000 from it.
                }
                nonPeakTotal.Text = charge.ToString("c");
                non = charge;
                double indTotal = peak + non; //Add both the non and peak together.
                totalCostIndustrial.Text = indTotal.ToString("c"); 
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private double validateParse(TextBox box) //Validates specific TextBox, if cannot will return 0.
        {
            double kwhUsed;
            double.TryParse(box.Text, out kwhUsed);
            return kwhUsed;
        }
        private void clearField(TextBox box) //Clears specific TextBox.
        {
            box.Text = null;
        }
        private void button_clear_Click(object sender, EventArgs e) //Clears all inputs when they click "Clear"
        {
            customertypebox.SelectedIndex = 0;
            clearField(kwhused);
            clearField(totalCostBox);
            clearField(totalCostIndustrial);
            clearField(peakTotal);
            clearField(nonPeakTotal);
            clearField(peakKwhUsed);
            clearField(nonpeakKwhUsed);


        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            String r = generator.Next(0, 999999).ToString("D6"); //Generates a random 6 digit account nunmber.
            Account_No.Text = r;
        }
        public static String path = Directory.GetCurrentDirectory() + "\\customer.txt";
        private void addCustomer_Click(object sender, EventArgs e)
        {
            char AccountType = 'R';
            if (customertypebox.SelectedIndex == 0)
            {
                AccountType = 'R';
            }
            if (customertypebox.SelectedIndex == 1)
            {
                AccountType = 'C';
            }
            if (customertypebox.SelectedIndex == 2)
            {
                AccountType = 'I';
            }
            Int32.TryParse(Account_No.Text, out int AccountNum);
            Double.TryParse(totalCostBox.Text.Replace('$', ' '), out double Cost);
            String Name = textName.Text;
            Customer customer = new Customer(AccountNum, Name, AccountType, Cost);
            CustomerInformation.Add(AccountNum, customer);
        }
        public void updateStats()
        {
            int total = CustomerInformation.Count; //Total amount of users.
            double totalCost = 0; //Calculate the total cost.
            foreach (Customer c in CustomerInformation.Values)
            {
                totalCost += c.ChargeAmount;
            }
            customerBox.DisplayMember = "Key";
            customerBox.ValueMember = "Value";
            customerBox.DataSource = new BindingSource(CustomerInformation, null);
            CustomerTotal.Text = "Customers: " + total;
            TotalCost.Text = "Total Cost: " + totalCost.ToString("c");
        }
        private void Search_Button_Click(object sender, EventArgs e)
        {
            updateStats();
            Customer c = (Customer)customerBox.SelectedValue;
                if (c.Type() == 'R')
                {
                    customertypebox.SelectedIndex = 0;
                }
                if (c.Type() == 'C')
                {
                    customertypebox.SelectedIndex = 1;
                }
                if (c.Type() == 'I')
                {
                    customertypebox.SelectedIndex = 2;
                }
                totalCostBox.Text = c.ChargeAmount.ToString("c");
            }


        
    }
}
