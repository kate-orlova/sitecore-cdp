[![GitHub license](https://img.shields.io/github/license/kate-orlova/sitecore-cdp.svg)](https://github.com/kate-orlova/sitecore-cdp/blob/master/LICENSE)
![GitHub language count](https://img.shields.io/github/languages/count/kate-orlova/sitecore-cdp.svg?style=flat)
![GitHub repo size](https://img.shields.io/github/repo-size/kate-orlova/sitecore-cdp.svg?style=flat)
![GitHub contributors](https://img.shields.io/github/contributors/kate-orlova/sitecore-cdp)
![GitHub commit activity](https://img.shields.io/github/commit-activity/y/kate-orlova/sitecore-cdp)

# Sitecore CDP & Personalize
Sitecore CDP & Personalize module aims to support your marketing strategy and accelerate integration with the Sitecore Customer Data Platform (CDP). The module ships a bunch of handy CMS-agnostic scripts that can be easily incorporated into your Sitecore website regardless of its version or even a non-Sitecore project. 

# Pre-requisites
At first you need to provision your Sitecore CDP & Personalize instance and create at least one Point of Sale (see [here](https://doc.sitecore.com/cdp/en/developers/api/index-en.html#UUID-dfb6f11e-0ca2-e23a-0f1d-0dfb42ab2968)). Once all preps are done you can start integrating your website with Sitecore CDP. 

# Integration with Sitecore CDP
The below technique will work with any version of Sitecore XM or XP implementation that follows the MVC development approach.

## How to load the Boxever JavaScript Library on a Sitecore website and track events in Sitecore CDP?
### Load Sitecore CDP library
Assume that your Sitecore CDP & Personalize instance has been successfully provisioned and at least one Point of Sale has been created. If so then the next step is to load the Boxever JavaScript Library on your Sitecore website. The **sitecore-cdp-library** _View Rendering_ (the file path is `..\src\Sitecore\SitecoreCDP\Foundation\SitecoreCDP\Views\CDP\sitecore-cdp-library.cshtml`) defines the core Boxever settings and imports the Boxever JavaScript Library. Ideally, you want to activate the Boxever JavaScript Library on all your webpages, therefore, you can incorporate this _View_ into the concerned _Layouts_ by adding the following code line as the first _<script>_ element before the closing _<&sol;body>_ tag to not slow down the overall website user experience:

```
@Html.Partial("~/Views/CDP/sitecore-cdp-library.cshtml")
```

For ease, the Boxever initialisation parameters along with some Sitecore CDP event attributes are defined as configuration settings in `..\src\Sitecore\SitecoreCDP\Foundation\SitecoreCDP\App_Config\Include\SitecoreCDP.config`. Please replace the placeholder values with the required details from your Sitecore CDP & Personalize instance, [this guidance](https://doc.sitecore.com/cdp/en/developers/sitecore-customer-data-platform--data-model-2-1/walkthrough--preparing-to-integrate-with-sitecore-cdp.html#UUID-a3dfedd9-f5ae-2ea4-71b5-ad8a2c716599_UUID-7e431314-9371-8d40-8d0e-38b2e6ae25cd) explains where to collect the necessary information about your Sitecore CDP & Personalize setup.

### Track events in Sitecore CDP
After you have successfully activated the Boxever JavaScript Library, you can start sending data to Sitecore CDP. The **create-view-event** _View Rendering_ (the file path is `..\src\Sitecore\SitecoreCDP\Foundation\SitecoreCDP\Views\CDP\create-view-event.cshtml`) creates a **VIEW event** object and sends the event data to Sitecore CDP dynamically pulling the _language_ and _page URL_ from the `Sitecore.Context.Item`. Following the common event-triggering nature, the VIEW event triggers every time your webpage loads, so it makes sence to place this view at a _Layout_ level too, for example, add the below code line to your _Layouts_ before the closing _<&sol;body>_ tag right after the Boxever JavaScript Library initialisation and import:

 ```
 @Html.Partial("~/Views/CDP/create-view-event.cshtml")
 ```
By default the browser ID is the main Event ID and `Boxever.getID()` function is being used to set the current browser ID to the _VIEW event_ object, so you should use the browser ID to find your VIEW events in the Sitecore CDP & Personalize application.

#### IDENTITY event
For authenticated users you can trigger an **IDENTITY event** to pass some profile properties and identify anonymous guests in the Sitecore CDP, for example,
 
```
@if(user.IsAuthenticated){
   @Html.Partial("~/Views/CDP/create-identity-event.cshtml");
}
```

## How to load the Engage JavaScript Library on a non-Sitecore website and track events in Sitecore CDP?
Follow the simple steps below to integrate your non-Sitecore website with Sitecore CDP & Personalise to support your marketing strategy.
1. Create a new JavaScript file based on the code example provided in `..\src\scripts\sitecore-engage-library.js` and replace the placeholder values with the required details from your Sitecore CDP & Personalize instance, [this guidance](https://doc.sitecore.com/cdp/en/developers/api/index-en.html#UUID-d5fdb6b2-5ee6-a577-600b-c4250c69e3e8) explains where to collect the necessary information about your Sitecore CDP setup; 

 2. Import the created `sitecore-engage-library.js` JavaScript file as the first `<script>` element before the closing _<&sol;body>_ tag as follows in your page template:
```
 <script src="scripts/sitecore-engage-library.js"></script>
 ```
3. Create a new JavaScript file based on the code example provided in `..\src\scripts\sitecore-engage-create-a-view-event.js` and replace the placeholder values with specific data you would like to track on the View event in Sitecore CDP;

 4. Import the created `sitecore-engage-create-a-view-event.js` JavaScript file in your website page template right after the Engage JavaScript Library initialisation script:
```
 <script src="scripts/sitecore-engage-create-a-view-event.js"></script>
 ```
 5. All is ready now and you can start browsing the captured events in Sitecore CDP. Note, that you should use the Browser ID or Guest ID to find your VIEW events in the Sitecore CDP & Personalize application.
    

# Full Stack Experience in the Sitecore Personalize
## How to connect the Sitecore-managed content to the Sitecore Personalize? 
1. Create the personalised content variants in the Sitecore CMS as standard Sitecore Items; 
2. Create a Decision Model to recommend the most relevant content variant; 
3. Configure the API response using FreeMarker language; 
4. Build the API integration in C# language. 

 Watch this video to see how the above steps work in practice:
 
 <a href="http://www.youtube.com/watch?feature=player_embedded&v=vhB9aMvRvFA" target="_blank"><img src="http://img.youtube.com/vi/vhB9aMvRvFA/mqdefault.jpg" alt="Watch the video" width="350" border="10" /></a>

 
## Sitecore Packages
Sitecore packages folder contain:

1. Base Layout
Project -> Base Layout
1. Renderings
1. Templates
1. Test items
 
 
## Personalize Packages
Personalize packages folder contain the configuration scripts in FreeMarker and server-side JavaScript languages:
 - `API-Response-ContentItemId.ftl` - an example of Personalize API response with a Sitecore Item Id
 - `API-Response-Offer.ftl` - an example of Personalize API response with Offers
 - `Custom-Condition-Number-of-Events.js` - an example of a custom condition for a number of View events
 - `getNumberOfEvents.js` - an example of how to calculate number of all VIEW events across all sessions

 
 # Sitecore CDP Tips
To find users of your application by the browser ID in the Sitecore CDP application always use the ```bid:``` prefix plus the `browser ID` value, for example: ```bid: 335c8d8a-bcba-4d14-afad-fae252e5dd80```

# Contribution
Hope you found this module useful, your contributions and suggestions will be very much appreciated. Please submit a pull request.

# License
The Sitecore CDP & Personalize module is released under the MIT license implying that you can modify and use it how you want even for commercial projects. Please give it a star if you like it and your experience was positive.
