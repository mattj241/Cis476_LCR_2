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
                string selectedUnit = Spinner.Text;
                conversionRequest = new ConversionRequest(input);
                conversionRequest.Unit = selectedUnit;
                mileHandler.HandleConversion(conversionRequest);
                mileHandler.DecoratedOutput = conversionRequest.Output.ToString();

                HandlerDecorator handlerDecorator = new HandlerDecorator();
                handlerDecorator.conversionHandler = 

                mileHandler = new RoundDecorator(mileHandler);

                mileHandler = new ExpDecorator(mileHandler);

                mileHandler = new UnitDecorator(mileHandler);

                SolutionBox.Text = mileHandler.DecoratedOutput;
            }
        }
    }
}
