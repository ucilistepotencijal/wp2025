(function ($) {
    function toNumber(value) {
        if (value === null || value === undefined) return value;
        if (typeof value !== "string") return value;
        // ukloni razmake i pretvori decimalni zarez u točku
        return value.replace(/\s/g, "").replace(",", ".");
    }

    // broj s , ili .
    $.validator.methods.number = function (value, element) {
        value = toNumber(value);
        return this.optional(element) || /^-?\d+(\.\d+)?$/.test(value);
    };

    // range koristi parsiranje -> prilagodi
    $.validator.methods.range = function (value, element, param) {
        value = parseFloat(toNumber(value));
        return this.optional(element) || (value >= param[0] && value <= param[1]);
    };

    $.validator.methods.min = function (value, element, param) {
        value = parseFloat(toNumber(value));
        return this.optional(element) || value >= param;
    };

    $.validator.methods.max = function (value, element, param) {
        value = parseFloat(toNumber(value));
        return this.optional(element) || value <= param;
    };
})(jQuery);
