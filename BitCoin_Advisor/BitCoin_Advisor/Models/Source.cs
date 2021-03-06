﻿using BitCoin_Advisor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoin_Advisor
{
    public class Source : BaseDataObject
    {
        string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        string tickerurl = string.Empty;
        public string TickerUrl
        {
            get { return tickerurl; }
            set { SetProperty(ref tickerurl, value); }
        }

        Ticker price = null;
        public Ticker Price
        {
            get { return price; }
            set { SetProperty(ref price, value); }
        }

        string image = string.Empty;
        public string Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        decimal fee = 0;
        public decimal Fee
        {
            get { return fee; }
            set { SetProperty(ref fee, value); }
        }
    }
}
