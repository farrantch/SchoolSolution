function CascadingDDLViewModel() {
    this.states = ko.observableArray([]);
}

var objVM = new CascadingDDLViewModel();
ko.applyBindings(objVM);

function FetchStates() {
    var countryCode = $("#CountryIdSelected").val();
    $.getJSON("/Home/GetStates/" + countryCode, null, function (data) {
        objVM.states(data);
    });
}

