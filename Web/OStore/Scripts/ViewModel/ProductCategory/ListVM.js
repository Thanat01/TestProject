var urlPath = "http://localhost:29128/ProductCategory";// window.location.hostname;

$(function () {
    ko.applyBindings(indexVM);
    indexVM.loadProductCategories();
});

var indexVM = {
    ProductCategories: ko.observableArray([]),

    loadProductCategories: function () {
        var self = this;
        $.ajax({
            type: "GET",
            url: urlPath + '/GetAllCategories',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.ProductCategories(data); //Put the response in ObservableArray
            },
            error: function (err) {
                al(urlp);
                alert(err.status + " : " + err.statusText);
            }
        });

    }
};

function ProductCategories(category) {
    this.Id = ko.observable(category.Id);
    this.ShopId = ko.observable(category.ShopId);
    this.ParentId = ko.observable(category.ParentId);
    this.Name = ko.observable(category.Name);
    this.Description = ko.observable(category.Description);
    this.PrimaryImageURL = ko.observable(category.PrimaryImageURL);
    this.SecondaryImageURL = ko.observable(category.SecondaryImageURL);
    this.PrimaryBoxSeq = ko.observable(category.PrimaryBoxSeq);
    this.SecondaryBoxSeq = ko.observable(category.SecondaryBoxSeq);
    this.Seq = ko.observable(category.Seq);
    this.Published = ko.observable(category.Published);
    this.IsActive = ko.observable(category.IsActive);
}