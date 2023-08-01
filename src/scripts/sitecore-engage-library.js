// Initialize the engage variable
var engage = undefined;

// Create and inject the <script> tag into the HTML
var s = document.createElement("script");
s.type = "text/javascript";
s.async = true;
s.src = "https://d1mj578wat5n4o.cloudfront.net/sitecore-engage-v.1.3.0.min.js";
var x = document.querySelector("script");
x.parentNode.insertBefore(s, x);    

// Initialize the Engage SDK
s.addEventListener("load", async () => {
    const settings = {
        clientKey: "<client_key_PLACEHOLDER>",
        targetURL: "<stream_api_target_endpoint_PLACEHOLDER>",
        pointOfSale: "<point_of_sale_PLACEHOLDER>",
        cookieDomain: "<cookie_domain_PLACEHOLDER>",
        cookieExpiryDays: 365,
        forceServerCookieMode: false,
        includeUTMParameters: true,
        webPersonalization: "<boolean_or_object>"
    };
    engage = await window.Engage.init(settings);
});