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
                // Basic validation
                if (string.IsNullOrWhiteSpace(txtPlateNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtAssignedSlot.Text) ||
                    string.IsNullOrWhiteSpace(txtHoursParked.Text) ||
                    string.IsNullOrWhiteSpace(cmbVehicleType.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!int.TryParse(txtHoursParked.Text, out int hours) || hours < 0)
                {
                    MessageBox.Show("Please enter a valid non-negative number for hours parked.");
                    return;
                }

                if (!Enum.TryParse<ParkingRecord.VehicleTypeEnum>(cmbVehicleType.Text, true, out var vType))
                {
                    MessageBox.Show("Please select a valid vehicle type.");
                    return;
                }

                activeRecord = new ParkingRecord(
                    txtPlateNumber.Text,
                    vType,  
                    hours,
                    txtAssignedSlot.Text
                );

                lblPlateDisplay.Text = activeRecord.PlateNumber;
                lblVehicleInfo.Text = activeRecord.VehicleTypeDescription;
                lblDuration.Text = activeRecord.HoursParked + " hrs";
                lblSlotDisplay.Text = activeRecord.AssignedSlot;
                lblOvertimeVal.Text = "P" + activeRecord.GetOvertimeFee().ToString("N2");

                lblStandardVal.Text = "P" + activeRecord.GetStandardFee().ToString("N2");
                lblServiceVal.Text = "P20.00";
                lblTotalVal.Text = "P" + activeRecord.GetTotalAmount(0m).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering vehicle: {ex.Message}");
            }
        }
    
    public class ParkingRecord
        {
            public enum VehicleTypeEnum { Car, Motorcycle, Van }

            public string PlateNumber { get; }
            public VehicleTypeEnum VehicleType { get; }
            public int HoursParked { get; }
            public string AssignedSlot { get; }

            private static readonly System.Collections.Generic.IReadOnlyDictionary<VehicleTypeEnum, decimal> Rates
                = new System.Collections.Generic.Dictionary<VehicleTypeEnum, decimal>
                {
                    { VehicleTypeEnum.Car, 50m },
                    { VehicleTypeEnum.Motorcycle, 30m },
                    { VehicleTypeEnum.Van, 70m }
                };

            private const decimal ServiceCharge = 20.0m;
            private const decimal OvertimeRate = 30.0m;

            public ParkingRecord(string plate, VehicleTypeEnum type, int hours, string slot)
            {
                if (string.IsNullOrWhiteSpace(plate)) throw new ArgumentException("Plate number is required.", nameof(plate));
                if (string.IsNullOrWhiteSpace(slot)) throw new ArgumentException("Assigned slot is required.", nameof(slot));
                if (hours < 0) throw new ArgumentOutOfRangeException(nameof(hours), "Hours parked cannot be negative.");

                PlateNumber = plate.Trim();
                VehicleType = type;
                HoursParked = hours;
                AssignedSlot = slot.Trim();
            }

            public decimal GetStandardFee() => Rates[VehicleType] * HoursParked;

            public decimal GetOvertimeFee() => HoursParked > 8 ? (HoursParked - 8) * OvertimeRate : 0m;

            public decimal GetTotalAmount(decimal discountRate)
            {
                if (discountRate < 0 || discountRate > 1) throw new ArgumentOutOfRangeException(nameof(discountRate));
                var subtotal = GetStandardFee() + GetOvertimeFee() + ServiceCharge;
                return subtotal * (1 - discountRate);
            }

            public string VehicleTypeDescription => VehicleType.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (activeRecord == null)
            {
                MessageBox.Show("No active transaction to generate a receipt.");
                return;
            }

            rtbReceipt.Clear();
            rtbReceipt.SelectionAlignment = HorizontalAlignment.Center;
            rtbReceipt.AppendText("SMART PARKING SYSTEM\n");
            rtbReceipt.AppendText("--------------------------\n");
            rtbReceipt.AppendText($"Plate: {activeRecord.PlateNumber}\n");
            rtbReceipt.AppendText($"Type: {activeRecord.VehicleTypeDescription}\n");
            rtbReceipt.AppendText($"Slot: {activeRecord.AssignedSlot}\n");
            rtbReceipt.AppendText($"Total Due: {lblTotalVal.Text}\n");
            rtbReceipt.AppendText("--------------------------\n");
            rtbReceipt.AppendText("Thank you for your business!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (activeRecord == null)
            {
                MessageBox.Show("No active transaction. Please register a vehicle first.");
                return;
            }

            decimal discount = 0m;
            if (cmbDiscount.Text == "Senior") discount = 0.20m;
            else if (cmbDiscount.Text == "Employee") discount = 0.10m;

            decimal finalTotal = activeRecord.GetTotalAmount(discount);

            if (!decimal.TryParse(txtPayAmount.Text, out decimal payment))
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

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

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
