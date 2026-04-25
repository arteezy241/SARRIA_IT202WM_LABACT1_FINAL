using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARRIA_IT202WM_LABACT1_FINAL
{
    public partial class Form1 : Form
    {
        private ParkingRecord activeRecord;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                activeRecord = new ParkingRecord(
                    txtPlateNumber.Text,
                    cmbVehicleType.SelectedItem.ToString(),
                    int.Parse(txtHoursParked.Text),
                    txtAssignedSlot.Text
                );

                lblPlateDisplay.Text = activeRecord.PlateNumber;
                lblVehicleInfo.Text = activeRecord.VehicleType;
                lblDuration.Text = activeRecord.HoursParked + " hrs";
                lblSlotDisplay.Text = activeRecord.AssignedSlot;
                lblOvertimeVal.Text = "P" + activeRecord.GetOvertimeFee().ToString("N2");

                lblStandardVal.Text = "P" + activeRecord.GetStandardFee().ToString("N2");
                lblServiceVal.Text = "P20.00";
                lblTotalVal.Text = "P" + activeRecord.GetTotalAmount(0).ToString("N2");
            }
            catch { MessageBox.Show("Please ensure all fields are filled correctly."); }
        }
    
    public class ParkingRecord
        {
            public string PlateNumber { get; set; }
            public string VehicleType { get; set; }
            public int HoursParked { get; set; }
            public string AssignedSlot { get; set; }

            private const double CarRate = 50.0;
            private const double MotorcycleRate = 30.0;
            private const double VanRate = 70.0;
            private const double ServiceCharge = 20.0;
            private const double OvertimeRate = 30.0;

            public ParkingRecord(string plate, string type, int hours, string slot)
            {
                PlateNumber = plate;
                VehicleType = type;
                HoursParked = hours;
                AssignedSlot = slot;
            }

            public double GetStandardFee()
            {
                double rate = 0;
                if (VehicleType == "Car") rate = CarRate;
                else if (VehicleType == "Motorcycle") rate = MotorcycleRate;
                else if (VehicleType == "Van") rate = VanRate;
            
            return rate * HoursParked;
            }

            public double GetOvertimeFee()
            {
                return (HoursParked > 8) ? (HoursParked - 8) * OvertimeRate : 0;
            }

            public double GetTotalAmount(double discountRate)
            {
                double subtotal = GetStandardFee() + GetOvertimeFee() + ServiceCharge;
                return subtotal * (1 - discountRate);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rtbReceipt.Clear();
            rtbReceipt.SelectionAlignment = HorizontalAlignment.Center;
            rtbReceipt.AppendText("SMART PARKING SYSTEM\n");
            rtbReceipt.AppendText("--------------------------\n");
            rtbReceipt.AppendText($"Plate: {activeRecord.PlateNumber}\n");
            rtbReceipt.AppendText($"Type: {activeRecord.VehicleType}\n");
            rtbReceipt.AppendText($"Slot: {activeRecord.AssignedSlot}\n");
            rtbReceipt.AppendText($"Total Due: {lblTotalVal.Text}\n");
            rtbReceipt.AppendText("--------------------------\n");
            rtbReceipt.AppendText("Thank you for your business!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (activeRecord == null) return;

            double discount = 0;
            if (cmbDiscount.Text == "Senior") discount = 0.20;
            else if (cmbDiscount.Text == "Employee") discount = 0.10;

            double finalTotal = activeRecord.GetTotalAmount(discount);
            double payment = double.Parse(txtPayAmount.Text);

            lblChangeVal.Text = (payment - finalTotal).ToString("N2");
            lblTotalVal.Text = "P" + finalTotal.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlParkingStatus.Controls)
            {
                if (ctrl is Button btn && btn.Text == txtAssignedSlot.Text)
                {
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.White;
                    btn.Text = txtPlateNumber.Text;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
