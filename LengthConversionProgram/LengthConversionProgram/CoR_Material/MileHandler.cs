///////////////////////////////////////////////////////////
//  MileHandler.cs
//  Implementation of the Class MileHandler
//  Generated by Enterprise Architect
//  Created on:      19-Mar-2019 7:18:24 PM
///////////////////////////////////////////////////////////


namespace LengthConversionProgram
{
    public class MileHandler : ConversionHandler
    {

        public override void HandleConversion(ConversionRequest currentRequest)
        {
            if (currentRequest.Unit == "Mile")
            {
                currentRequest.Output = currentRequest.Input * 0.621371;
            }
            else
            {
                successor.HandleConversion(currentRequest);
            }
        }

    }
}