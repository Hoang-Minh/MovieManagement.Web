$(document).ready(function () {

    function autocompletewrapper(obj, filter) {

        var autos = new Bloodhound({
            datumTokenizer: function (datum) {
                return Bloodhound.tokenizers.whitespace(datum.value);
            },
            queryTokenizer: Bloodhound.tokenizers.whitespace,
            remote: {
                wildcard: "%QUERY",
                url: $(obj).data("autocomplete-url") + "?query=%QUERY",
                filter: function(autos) {
                    return $.map(autos, filter);
                }
            },
            limit: 1000
        });

        autos.initialize();

        $(obj).typeahead({ highlight: true, minLength: 0, hint: true }, {
            name: 'autos', displayKey: 'value', source: autos.ttAdapter()
        }).on('typeahead:selected', function (obj, datum) {
            onselected(obj, datum);
        });

        if ($(obj).hasClass("focus")) {
            $(obj).focus();
        }

    };

    function onselected(obj, datum) {
        if (!obj || !obj.target || !datum) return;
        $('#' + jQuery(obj.target).data("autocomplete-id-field")).val(datum.id.toString());
    }

    function filterCustomers(auto) {
        return {
            value: auto.Name,
            id: auto.Id,
            birthDate: new Date(parseInt(auto.BirthDate.substr(6))).toLocaleDateString("en-US")
        };
    }

    function filterMovies(auto) {
        return {
            value: auto.Name,
            id: auto.Id
        };
    }

    autocompletewrapper($('input[data-autocomplete-url="/Rentals/GetCustomers"]'), filterCustomers);
    autocompletewrapper($('input[data-autocomplete-url="/Rentals/GetMovies"]'), filterMovies);
})