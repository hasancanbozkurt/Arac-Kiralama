﻿namespace CarBook1.Application.ViewModels
{
    public class CarPricingViewModel
    {
        public CarPricingViewModel()
        {
            Amounts = new List<decimal>();
        }
        public string Model { get; set; }
        public List<Decimal> Amounts { get; set; }
        public string CoverImageUrl { get; set; }
        public string Brand { get; set; }
    }
}
