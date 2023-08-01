// Send a VIEW event 
var event = { 
    channel: "<channel_PLACEHOLDER>", 
    language: "<language_PLACEHOLDER>", 
    currency: "<currency_PLACEHOLDER>", 
    page: "<page_PLACEHOLDER>" 
}; 
await engage.pageView(event); 

// Log the browser ID to the console
console.log("Copy-paste the following line into Sitecore CDP, Customer Data, Guests, Search field:");
console.log("bid:", engage.getBrowserId());
console.log(engage.getGuestId());

