﻿var requestParms = {
    clientID: "DO5JJHGXBODWHZUZ2W45T0S35PKJH3MCLC1SKF5U4X3VF4YA",
    clientSecret: "GF0PDCNGEKSU2GI4ANGBGBKTEUU0G3E3QYPO5YWFXRV33GY5",
    version: "20140707"
};

app.factory('placesExplorerService', function ($resource) {
    var requestUri = 'https://api.foursquare.com/v2/venues/:action';
    return $resource(requestUri, {
        action: "",
        client_id: "",
        client_secret: "",
        v: requestParms.version,
        venuePhotos: '1',
        callback: 'JSON_CALLBACK'
    },
    {
        get: { method: 'JSONP' }
    });
});