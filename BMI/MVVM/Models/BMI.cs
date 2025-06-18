using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.Models
{
    public class BMI
    {
        private float result;

        public float Height { get; set; }
        public float Weight { get; set; }
        public float Result 
        
        {   get
            {
                return ((Weight / Height) / Height) * 10000;
            }
        }
    }
}
