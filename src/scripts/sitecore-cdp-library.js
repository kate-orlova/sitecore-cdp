// Define the Boxever queue 
var _boxeverq = _boxeverq || [];

// Define the Boxever settings 
var _boxever_settings = {
    client_key: "{client_key}",
    target: "{stream_api_target_endpoint}",
    cookie_domain: "{cookie_domain}",
    pointOfSale: "{name_of_point_of_sale}",
    web_flow_target: "{web_flow_target}",
    web_flow_config: { async: false, defer: false },
    javascriptLibraryVersion: "1.4.9"
};

// Load the Boxever JavaScript Library asynchronously 
(function() {
     var s = document.createElement("script");
     s.type = "text/javascript";
     s.async = true;  
     s.src = "https://d1mj578wat5n4o.cloudfront.net/boxever-" + window._boxever_settings.javascriptLibraryVersion + ".min.js";
     var x = document.getElementsByTagName("script")[0]; x.parentNode.insertBefore(s, x);
})();