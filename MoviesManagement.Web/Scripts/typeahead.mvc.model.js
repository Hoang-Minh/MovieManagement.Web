$(document).ready($(function () {

    function autocompletewrapper(obj) {
        var autos = new Bloodhound({
            datumTokenizer: function (datum) {
                return Bloodhound.tokenizers.whitespace(datum.value);
            },
            queryTokenizer: Bloodhound.tokenizers.whitespace,
            remote: {
                wildcard: "%QUERY",            
                url: $(obj).data("autocomplete-url") + "?query=%QUERY",
                filter: function (autos) {
                    // Map the remote source JSON array to a JavaScript object array
                    return $.map(autos, function (auto) {
                        return {
                            value: auto.Name,
                            id: auto.Id
                        };
                    });
                }
            },
            limit: 1000
        });

        autos.initialize();

        $(obj).typeahead({ highlight: true, minLength: 0, hint: true }, {
            name: 'autos', displayKey: 'value', source: autos.ttAdapter()
        }).on('typeahead:selected', function (obj, datum) {
            OnSelectedFunctionName(obj, datum);
        });

        if ($(obj).hasClass("focus")) {
            $(obj).focus();
        }

    };

    function onselected(obj, datum) {
        if (!obj || !obj.target || !datum) return;
        $('#' + jQuery(obj.target).data("autocomplete-id-field")).val(datum.id.toString());
    }

    function OnSelectedFunctionName(event, datum) {
        //The default datum provided by this plugin has an id and name attribute
        //var obj$ = $(event.target);
        var test = {
            id: datum.id.toString().toString(),
            value: event.target.value
        };
        //Handle the selection value here//
        console.log(test);
    }

    $('*[data-autocomplete-url]')
            .each(function () {
                autocompletewrapper($(this));
            });
})
)