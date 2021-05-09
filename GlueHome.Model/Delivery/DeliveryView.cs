﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GlueHome.Model.Delivery
{
    [ExcludeFromCodeCoverage]
    public class DeliveryView
    {
        public string Status { get; set; }

        [Required]
        public virtual DeliveryTime AccessWindow { get; set; }

        [Required]
        public virtual Recepient Recepient { get; set; }

        [Required]
        public virtual Order Order { get; set; }          
    }
}
