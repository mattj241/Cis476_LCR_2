///////////////////////////////////////////////////////////
//  UnitDecorator.cs
//  Implementation of the Class UnitDecorator
//  Generated by Enterprise Architect
//  Created on:      20-Mar-2019 9:59:47 AM
///////////////////////////////////////////////////////////


namespace LengthConversionProgram
{
    public class UnitDecorator : HandlerDecorator
    {
        public UnitDecorator(string convertedOutput)
        {
            this.DecoratedOutput = convertedOutput;
        }

        public override void HandleConversion(string unitRequested, ConversionRequest currentRequest)
        {
            this.DecoratedOutput = this.DecoratedOutput + $" {unitRequested}";
        }
    }
}