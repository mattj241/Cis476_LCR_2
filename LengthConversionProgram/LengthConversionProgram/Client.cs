//Client.cs
using System;
using System.Windows.Forms;

namespace LengthConversionProgram
{
    public partial class Client : Form
    {
        string[] units = { "Mile", "Yard", "Foot" };

        private ConversionHandler mileHandler;
        private ConversionHandler yardHandler;
        private ConversionHandler footHandler;
        private ConversionRequest conversionRequest;

        public Client()
        {
            InitializeComponent();
            Spinner.Items.AddRange(units);
        }

        private void ConverBtn_Click(object sender, EventArgs e)
        {
            mileHandler = new MileHandler();
            yardHandler = new YardHandler();
            footHandler = new FootHandler();
            mileHandler.SetSuccessor(yardHandler);
            yardHandler.SetSuccessor(footHandler);
            bool isGoodParse = Double.TryParse(kiloTextBox.Text, out double input);
            if (!isGoodParse)
            {
                MessageBox.Show("Not Valid Input!");
            }
            else
            {
                conversionRequest = new ConversionRequest(input);
                string selectedUnit = Spinner.Text;
                mileHandler.HandleConversion(selectedUnit, conversionRequest);
                mileHandler.DecoratedOutput = conversionRequest.Output.ToString();

                mileHandler = new RoundDecorator(mileHandler);
                mileHandler.HandleConversion(selectedUnit, conversionRequest);

                mileHandler = new ExpDecorator(mileHandler);
                mileHandler.HandleConversion(selectedUnit, conversionRequest);

                mileHandler = new UnitDecorator(mileHandler);
                mileHandler.HandleConversion(selectedUnit, conversionRequest);

                SolutionBox.Text = mileHandler.DecoratedOutput;
            }
        }
    }
}
