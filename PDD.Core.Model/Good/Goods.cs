using System;

namespace PDD.Core.Model
{
    public class Goods
    {
        public int SId { get; set; }
        public string SName { get; set; }
        public int Sprice { get; set; }
        public int Ssell { get; set; }
        public int repertory { get; set; }
        public int sort { get; set; }
        public bool State { get; set; }
        public DateTime SDate { get; set; }

        public int PhotoId { get; set; }
        public string DefPhoto { get; set; }
        public int SpId { get; set; }
        public int Paid { get; set; }
        public int Bus_BId { get; set; }
        public int EId { get; set; }
        public int FmId { get; set; }
        public int Uid { get; set; }
        //新加的字段
        public int KId { get; set; }
        public int STeid { get; set; }
        public int Mcid { get; set; }
        public int ShopID { get; set; }
        public int Tid { get; set; }
    }
}
