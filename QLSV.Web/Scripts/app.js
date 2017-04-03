var nationalities = [
    "Việt Nam",
    "Lào",
    "Campuchia",
    "Trung Quốc",
    "Thái Lan"
];

var ngayHoc = [
    {
        "Text": "Thứ hai",
        "Value": 2
    },
    {
        "Text": "Thứ ba",
        "Value": 3
    },
    {
        "Text": "Thứ tư",
        "Value": 4
    },
    {
        "Text": "Thứ năm",
        "Value": 5
    },
    {
        "Text": "Thứ sáu",
        "Value": 6
    },
    {
        "Text": "Thứ bảy",
        "Value": 7
    },
    {
        "Text": "Chủ nhật",
        "Value": 8
    }
];

getNgayHoc = function() {
    return ngayHoc;
}

var getUrlParameter = function getUrlParameter(sParam) {
    var sPageUrl = decodeURIComponent(window.location.search.substring(1)),
        sUrlVariables = sPageUrl.split('&'),
        sParameterName,
        i;

    for (i = 0; i < sUrlVariables.length; i++) {
        sParameterName = sUrlVariables[i].split('=');

        if (sParameterName[0] === sParam) {
            return sParameterName[1] === undefined ? true : sParameterName[1];
        }
    }
};