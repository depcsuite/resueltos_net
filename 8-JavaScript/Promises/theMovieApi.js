import { TmdbClient } from 'tmdb-js-wrapper';

doStuff = async function(authentication) {

   let apiKey = authentication.apiKey;
   let username = authentication.username;
   let password = authentication.password;

   let tmdb = new TmdbClient(apiKey);

   // Get movie data example
   let oceansElevenMovie = tmdb.getMovieSection().getMovie("161");
   let oceansDetails = await oceansElevenMovie.getDetailsAsync();
   let oceansImages = await oceansElevenMovie.getImagesAsync();
   console.log("A great movie: " + json.title);
   
   // Rate movie example
   let sessionId = await tmdb.getAuthenticator().createSessionAsync("chrome"); // One way of getting a session ID
   let ratingSuccessful1 = await oceansElevenMovie.rateAsync(10, sessionId);

   // Rate TV show episode example
   let loginSessionId = await tmdb.getAuthenticator().createLoginSessionAsync(username, password); // Another way of getting a session ID
   let gameOfThronesTvShow = tmdb.getTvShowSection().getTvShow("1399");
   let ratingSuccessful2 = await gameOfThronesTvShow.getEpisode(3, 9).rateAsync(10, sessionId);

   // Rate TV show as a guest example
   let guestSessionId = await tmdb.getAuthenticator().createGuestSessionAsync();
   let ratingSuccessful3 = await gameOfThronesTvShow.rateAsync(10, undefined, guestSessionId);

   // Search TMDB examples
   let searchSection = tmdb.getSearchSection();
   let searchResult1 = await searchSection.searchMoviesAsync("Ocean's");
   let searchResult2 = await searchSection.searchMoviesAsync("Ocean's", 1, 1);
   let searchResult3 = await searchSection.multiSearchAsync("Ocean's");
   let searchResult4 = await searchSection.multiSearchAsync("Ocean's", 1, 2);
}