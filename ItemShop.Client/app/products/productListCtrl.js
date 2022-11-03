(function () {
    "use strict";
    angular
        .module("productManagement")
        .controller("ProductListCtrl",
                    ["productResource",
                     ProductListCtrl]);

    function ProductListCtrl(productResource) {
        var vm = this;

        vm.searchCriteria = "GDN";

        productResource.query({
            $filter: "Price le 20 and Price ge 10",
            $orderby:"Price"},
            function (data) {
            vm.products = data;
        });
    }
}());
