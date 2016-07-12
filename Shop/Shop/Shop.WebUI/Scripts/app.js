function AppViewModel() {
    var self = this;

    self.products = ko.observableArray();

    self.categories = ko.observableArray();

    $.ajax({
        url: 'api/Category/GetCategories',
        type: 'GET',
        success: function(result) {
            self.categories(result);
        }
    });

    self.selectCategory = function (item) {
        self.products();
        $.ajax({
            url: 'api/Product/GetProductsByCategory/?categoryid=' + item.Id,
            type: 'GET',
            success: function (result) {
                self.products(result);
            }
        });
    }
}

ko.applyBindings(new AppViewModel());