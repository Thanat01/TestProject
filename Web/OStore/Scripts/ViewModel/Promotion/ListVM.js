var urlPath = "http://localhost:29128/ProductCategory";// window.location.hostname;

$(function () {
    ko.applyBindings(indexVM);
    indexVM.loadPromotions();
});

var indexVM = {
    Promotions: ko.observableArray([]),

    loadPromotions: function () {
        var self = this;
        $.ajax({
            type: "GET",
            url: urlPath + '/GetAllPromotions',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.Promotions(data); //Put the response in ObservableArray
            },
            error: function (err) {
                al(urlp);
                alert(err.status + " : " + err.statusText);
            }
        });

    }
};

function Promotions(promotion) {
    this.Id =ko.observable(promo.Id );
    this.ShopId =ko.observable(promo.ShopId);
    this.Code =ko.observable(promo.Code);
    this.Name = ko.observable(promotion.Name);
    this.Description = ko.observable(promotion.Description);
    this.UsedQuantity = ko.observable(promotion.UsedQuantity);
    this.DiscountTypeId = ko.observable(promotion.DiscountTypeId);
    this.Amount = ko.observable(promotion.Amount);
    this.Percentage = ko.observable(promotion.Percentage);
    this.LimitTotal = ko.observable(promotion.LimitTotal);
    this.LimitPerCustomer = ko.observable(promotion.LimitPerCustomer);
    this.MinimumPurchase = ko.observable(promotion.MinimumPurchase);
    this.MaximumDiscount = ko.observable(promotion.MaximumDiscount);
    this.EffectiveDate = ko.observable(promotion.EffectiveDate);
    this.ExpiryDate = ko.observable(promotion.ExpiryDate);
    this.IsActive = ko.observable(promotion.IsActive);
}