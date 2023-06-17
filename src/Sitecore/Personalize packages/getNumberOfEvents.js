// Use server-side JavaScript to filter your audience further
// You have full access to the guest context which can be accessed under guest, e.g. guest.email
// Any truthy return value will pass the audience filter, it is recommended to return an object
// The value returned can be accessed from the variant API response as 'filter'

 (function () {
 function getNumberOfEvents(sessions, eventType) {
 var numberOfEvents = 0;
 for (var i = 0; i < sessions.length; i++) {
 var session = sessions[i];
 for (var j = 0; j < session.events.length; j++) {
 var event = session.events[j];
 if (event.type === eventType && event.arbitraryData && event.arbitraryData.page && event.arbitraryData.page.toLowerCase().indexOf('/services/') >= 0) {
 numberOfEvents++;
 }
 }
 }
 return numberOfEvents;
 }
 
 var numberOfEvents = getNumberOfEvents(guest.sessions, 'VIEW'); // triggerSession can be obtained using the getTriggerSession function
 return numberOfEvents;
 })();