﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceMentor.Shared
{
     public class Earning
    {
        public Earning()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Subject { get; set; }

        public EarningCategory Category { get; set; }

        public decimal Amount { get; set; }
    }
}
