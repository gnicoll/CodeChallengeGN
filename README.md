# CodeChallengeGN

Code Challenge submission by Glenn Nicoll.

## Instructions:

1. Open The Solution in Visual Studio
2. Build the Solution
3. Then Start Debugging (F5) to view in browser

## Notes

I found that image URLs from the endpoint would not load. To work around this I have manually setup images in the project and named them to match the DrawResult.ProductId.

Rather than use DrawResult.DrawDisplayName which combines the Brand Name and Draw Number I have opted to use both ProductId and Draw Number. This allowed me to better present the Draw Number, however in the case of SetForLife the brand name is slightly incorrect. 

To demonstrate my skills in C#/HTML I have not used any CSS frameworks and the frontend is entirely HTML/CSS (no JS).



## Thoughts for next steps

### ReactJS
If I was to continue with this project I would like to include a ReactJS front end. This would involve exposing the LatestResultsModel I have created via my own api endpoint then letting React present a 'loading' screen before the data comes in. This would allow the page to 'load' sooner.

### IoC
I have separated out the API call to it's own Service to show the structure needed to be able to share an instance of it via IoC. Currently there is one API call and no other Controllers or Models sharing the service so IoC is not required at this time.

### Caching
Server side caching could be setup on the API call to help reduce load times.