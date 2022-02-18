function isDevice() {
    return /android|webos|iphone|ipad|ipod|blackberry|iemobile|opera mini|mobile/i.test(navigator.userAgent);
}

function isSmallFormFactor() {
    return document.body.clientWidth < 960;
}

var dotNetHelper = null;
function registerDotNetHelper(helper) {
    dotNetHelper = helper;
}
function pollScreenChange(event) {
    if (dotNetHelper != null) {
        dotNetHelper.invokeMethodAsync('performScreenChange', isSmallFormFactor());
    }
}
window.addEventListener("resize", pollScreenChange);