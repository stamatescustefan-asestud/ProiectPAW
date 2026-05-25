using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComertApp.Custom_Exceptions
{
    public class InvalidSaleDateException : Exception
    {
        public DateOnly DataVanzarii { get; set; }

        public InvalidSaleDateException(DateOnly dataVanzarii)
        {
            DataVanzarii = dataVanzarii;
        }

        public override string Message
        {
            get
            {
                return "The date of sale " + DataVanzarii + " is invalid";
            }
        }
    }
}
