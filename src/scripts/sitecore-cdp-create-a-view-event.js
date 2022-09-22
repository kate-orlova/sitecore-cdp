_boxeverq.push(() => {
    // Create a "VIEW" event object
    const viewEvent = {
        browser_id: Boxever.getID(),
        channel: "{channel}",
        type: "{type}",
        language: "{language}",
        currency: "{currency}",
        page: "{page}",
        pos: "{pos}",
    };

    // Send the event data to the server
    Boxever.eventCreate(
        viewEvent,
        () => {},
        "json"
    );

    // Log the browser ID to the console
    console.log("Copy-paste the following line into Sitecore CDP, Customer Data, Guests, Search field:");
    console.log(`bid: ${Boxever.getID()}`);
});
