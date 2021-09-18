#CodeChallengeGN

Code Challenge submission by Glenn Nicoll.

##Instructions:

1. Open The Solution in Visual Studio
2. Start Debugging (F5)

##Notes

I found that image URLS from the endpoint would not load. To work around this I have manually setup images in the project and named them to match the DrawResult.ProductId.

##Thoughts for next steps

###ReactJS
If I was to continue with this project I would like to include a ReactJS front end. This would involve exposing the LatestResultsModel I have created via my own api endpoint then letting React present a 'loading' screen before the data comes in. This would allow the page to 'load' sooner.

###IoC
I have separated out the API call to it's own Service to show the structure needed to be able to share it via IoC. Currently there is one API call and no other Controllers or Models sharing the service so IoC is not required at this time.

###Caching
Server side caching could be setup on the API call to help reduce load times.