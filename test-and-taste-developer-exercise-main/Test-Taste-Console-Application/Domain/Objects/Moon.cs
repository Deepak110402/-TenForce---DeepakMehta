using System;
using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class Moon
    {
        public string Id { get; set; }
        public float MassValue { get; set; }
        public float MassExponent { get; set; }
        public double Gravity { get; set; }

        public Moon(MoonDto moonDto)
        {
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;
            Gravity = CalculateGravity();
        }

        private double CalculateGravity()
        {
            double mass = MassValue * Math.Pow(10, MassExponent);
            // Use a simplified formula for gravity, assuming G and radius constants.
            return mass; // Simplified gravity estimate.
        }
    }
}
