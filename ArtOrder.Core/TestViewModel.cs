using ArtOrder.Core.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtOrder.Core
{
    public class TestViewModel
    {
        public DateTime FirstDate { get; set; }

        [IsBefore(nameof(FirstDate), errorMessage: "error")]
        public DateTime SecondDate { get; set; }
    }
}
