<#-- Construct the API request body using Freemarker -->
<#-- For your Experience to run your API tab must have, at a minimum, open and closing brackets -->
{
<#if (guest.guestType == 'customer')>
    "guestEmail": "${guest.email}",
    "guestName": "${guest.firstName} ${guest.lastName}"
</#if>
<#if (offers)??>
    <#if (guest.guestType == 'customer')>,</#if>
    "offer": {
        "title": "<@(offers[0].attributes.Title)?interpret />",
        "description": "<@(offers[0].attributes.Description)?interpret />",
        "imageUrl": "${offers[0].attributes.ImageUrl}"
    }
</#if>
}