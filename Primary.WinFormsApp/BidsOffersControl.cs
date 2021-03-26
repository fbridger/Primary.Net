using Primary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    public partial class BidsOffersControl : UserControl
    {
        public BidsOffersControl()
        {
            InitializeComponent();
        }

        public void Refresh(Entries entries)
        {
            SetText(lnkBidSize1, lnkBidPrice1, entries.Bids, 0);
            SetText(lnkBidSize2, lnkBidPrice2, entries.Bids, 1);
            SetText(lnkBidSize3, lnkBidPrice3, entries.Bids, 2);
            SetText(lnkBidSize4, lnkBidPrice4, entries.Bids, 3);
            SetText(lnkBidSize5, lnkBidPrice5, entries.Bids, 4);

            SetText(lnkOfferSize1, lnkOfferPrice1, entries.Offers, 0);
            SetText(lnkOfferSize2, lnkOfferPrice2, entries.Offers, 1);
            SetText(lnkOfferSize3, lnkOfferPrice3, entries.Offers, 2);
            SetText(lnkOfferSize4, lnkOfferPrice4, entries.Offers, 3);
            SetText(lnkOfferSize5, lnkOfferPrice5, entries.Offers, 4);
        }

        private void SetText(LinkLabel size, LinkLabel price, Trade[] trades, int index) 
        {
            if (trades.Length > index)
            {
                size.Text = $"{trades[index].Size:#,###}";
                price.Text = $"{trades[index].Price:C}";
            }
            else
            {
                size.Text = string.Empty;
                price.Text = string.Empty;
            }
        }


        private void lnkBidSize1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkBidSize2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkBidSize3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkBidSize4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkBidSize5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkBidPrice1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkBidPrice2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkBidPrice3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkBidPrice4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkBidPrice5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferPrice1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferPrice2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferPrice3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferPrice4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferPrice5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferSize1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferSize2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferSize3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferSize4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkOfferSize5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
