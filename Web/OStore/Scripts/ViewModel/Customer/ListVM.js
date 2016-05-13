var urlPath = "http://localhost:29128/ProductCategory";// window.location.hostname;

$(function () {
    ko.applyBindings(indexVM);
    indexVM.loadCustomers();
});

var indexVM = {
    Customers: ko.observableArray([]),

    loadCustomers: function () {
        var self = this;
        $.ajax({
            type: "GET",
            url: urlPath + '/GetAllCustomers',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.Customers(data); //Put the response in ObservableArray
            },
            error: function (err) {
                al(urlp);
                alert(err.status + " : " + err.statusText);
            }
        });

    }
};

function Customers(customer) {
    this.Id = ko.observable(custom.Id);
    this.Firstname = ko.observable(customer.Firstname);
    this.Lastname = ko.observable(customer.Lastname);
    this.Mobile = ko.observable(customer.Mobile);
    this.Email = ko.observable(customer.Email);
    this.Address = ko.observable(customer.Address);
    this.ProvinceId = ko.observable(customer.ProvinceId);
    this.DistrictId = ko.observable(customer.DistrictId);
    this.SubDistrictId = ko.observable(customer.SubDistrictId);
    this.PostalCodeId = ko.observable(customer.PostalCodeId);
}