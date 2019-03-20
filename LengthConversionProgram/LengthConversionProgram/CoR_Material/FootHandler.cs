///////////////////////////////////////////////////////////
//  FootHandler.cs
//  Implementation of the Class FootHandler
//  Generated by Enterprise Architect
//  Created on:      19-Mar-2019 7:18:27 PM
///////////////////////////////////////////////////////////


namespace LengthConversionProgram
{

    public class FootHandler : ConversionHandler
    {

        public override void HandleConversion(string unitRequested, ConversionRequest currentRequest)
        {
            if (unitRequested == "Foot")
            {
                currentRequest.Output = currentRequest.Input * 3280.84;
            }
            else
            {
                successor.HandleConversion(unitRequested, currentRequest);
            }
        }

    }
}