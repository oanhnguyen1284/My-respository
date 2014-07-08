var requestParams = {
    clientId: "DO5JJHGXBODWHZUZ2W45T0S35PKJH3MCLC1SKF5U4X3VF4YA",
    clientSecret: "GF0PDCNGEKSU2GI4ANGBGBKTEUU0G3E3QYPO5YWFXRV33GY5",
    version: "20140707"
}

app.factory('placesPhotosService', function ($resource) {
    var requestUri = 'https://api.foursquare.com/v2/venues/:venueId/:action';

    return $resource(requestUri, {
        action: 'photos',
        client_id: requestParams.clientId,
        client_secret: requestParams.clientSecret,
        v: requestParams.version,
        limit: '9',
        callback:'JSON_CALLBACK'
    }, {
        get: { method: 'JSONP' }
    });
});