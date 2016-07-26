﻿using System.Collections.Generic;
using System.Web.Mvc;
using Grand.Web.Framework;
using Grand.Web.Framework.Mvc;

namespace Grand.Plugin.Payments.AuthorizeNet.Models
{
    public class PaymentInfoModel : BaseNopModel
    {
        public PaymentInfoModel()
        {
            ExpireMonths = new List<SelectListItem>();
            ExpireYears = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Payment.CardholderName")]
        [AllowHtml]
        public string CardholderName { get; set; }

        [NopResourceDisplayName("Payment.CardNumber")]
        [AllowHtml]
        public string CardNumber { get; set; }

        [NopResourceDisplayName("Payment.ExpirationDate")]
        [AllowHtml]
        public string ExpireMonth { get; set; }
        [NopResourceDisplayName("Payment.ExpirationDate")]
        [AllowHtml]
        public string ExpireYear { get; set; }
        public IList<SelectListItem> ExpireMonths { get; set; }
        public IList<SelectListItem> ExpireYears { get; set; }

        [NopResourceDisplayName("Payment.CardCode")]
        [AllowHtml]
        public string CardCode { get; set; }
    }
}