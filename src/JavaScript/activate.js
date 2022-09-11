<script type="text/javascript">
    // define a queue 
    var _boxeverq = _boxeverq || [];

    // define settings 
    var _boxever_settings = {
        client_key: '{{yourClientKey}}', // Replace with your client key
        target: '{{apiTargetEndpoint}}', // Replace with your API target endpoint specific to your data center region
        cookie_domain: '{{cookieDomain}}', // Replace with the top level cookie domain of the website that is being integrated e.g ".example.com" and not "www.example.com"
        javascriptLibraryVersion: '{{javascriptLibraryVersion}}', // Replace with the latest Boxever JavaScript library version
        pointOfSale: '{{pointOfSale}}', // Replace with the same point of sale configured in system settings
        web_flow_target: '{{web_flow_target}}', // Replace with path for the Amazon CloudFront CDN for Sitecore Personalize
        web_flow_config: { async: false, defer: false } // Customize the async and defer script loading attributes
};
    // import the Boxever library asynchronously 
    (function() {
         var s = document.createElement('script'); s.type = 'text/javascript'; s.async = true;  
         s.src = 'https://d1mj578wat5n4o.cloudfront.net/boxever-{{clientVersion}}.min.js';
         var x = document.getElementsByTagName('script')[0]; x.parentNode.insertBefore(s, x);
    })();
</script>