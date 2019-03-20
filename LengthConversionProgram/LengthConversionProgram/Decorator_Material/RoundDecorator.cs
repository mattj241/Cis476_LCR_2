///////////////////////////////////////////////////////////
//  RoundDecorator.cs
//  Implementation of the Class RoundDecorator
//  Generated by Enterprise Architect
//  Created on:      20-Mar-2019 9:59:44 AM
///////////////////////////////////////////////////////////

using System;

namespace LengthConversionProgram
{ 
    public class RoundDecorator : HandlerDecorator
    {

        public RoundDecorator(ConversionHandler conversionHandler)
        {
            this.DecoratedOutput = conversionHandler.DecoratedOutput;
        }

        public override void HandleConversion(string unitRequested, ConversionRequest currentRequest)
        {
            this.DecoratedOutput = Math.Round(Double.Parse(this.DecoratedOutput), 2).ToString();
        }

    }
}