<#-- Construct the API request body using Freemarker -->
<#-- For your Experience to run your API tab must have, at a minimum, open and closing brackets -->
{
<#if (guest.guestType == 'customer')>
    "guestEmail": "${guest.email}",
    "guestName": "${guest.firstName} ${guest.lastName}"
</#if>
<#if (decisionModelResults.decisionModelResultNodes)??>
    <#list decisionModelResults.decisionModelResultNodes as resultNode>
        <#list resultNode.outputs as output>
            <#if (output.ContentItemID)??>
                <#if (guest.guestType == 'customer')>,</#if>
                "contentItemId":"${output.ContentItemID}"
            </#if>
        </#list>
    </#list>
</#if>
}