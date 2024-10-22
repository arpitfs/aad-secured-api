# aad-secured-api
This is a secured api which requires a token to get the data. The azure active directory is identity server for the api. The clients needs to be registered to azure too where it will provide the secret or the certificate thumbprint to azure to get the token which is the passed to headers in the api call. The token needs to be passed as a bearer token in the authorization header. The following sets needs to done to register the api to azure.

### Register app
1) Register the application in azure active directory

2) Expose the api
3) Update the manifest

![alt text](https://github.com/arpitfs/aad-secured-api/blob/main/Screenshots/ExposeAPI.png)


After registering the api you will get the resourceId and tenantId which will be used to tell the audience and authority for the api.
