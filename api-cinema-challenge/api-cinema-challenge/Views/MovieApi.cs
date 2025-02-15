﻿using api_cinema_challenge.Reposities.MovieRepo;
using api_cinema_challenge.Reposities.ScreeningRepo;
using api_cinema_challenge.Reposities.UserRepo;
using api_cinema_challenge.DTO;
using static api_cinema_challenge.Models.Payloads.MoviePayloads;
using static api_cinema_challenge.Models.Payloads.ScreeningPayloads;

namespace api_cinema_challenge.Views
{
    public static class MovieApi
    {

        public static void ConfigureMovieApi(this WebApplication app)
        {
            var movieGroup = app.MapGroup("/movies");
            movieGroup.MapGet("/", GetAllMovies);
            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);



            movieGroup.MapPost("/{movie_id}/screenings", CreateScreening);
            movieGroup.MapGet("/{movie_id}/screenings", GetScreeningByMovieId);
        }



        private static async Task<IResult> GetAllMovies(IMovieRepository movieRepository)
        {
            var result = await movieRepository.getAllMovies();
            if (result == null)
            {
                return TypedResults.NotFound("No movies could be found ");
            }
            var resultMovieAllDetailsDTO = new List<MovieAllDetailsDTO>();
            foreach (var movie in result) 
            {
                resultMovieAllDetailsDTO.Add(new MovieAllDetailsDTO(movie));
            }
            var movieDTO = new MovieListDataDTO(resultMovieAllDetailsDTO, "success");
            return TypedResults.Ok(movieDTO);
        }
        private static async Task<IResult> CreateMovie(MoviePostPayload payload, IMovieRepository movieRepository)
        {
            if (payload.title == null || payload.title == "")
            {
                return TypedResults.BadRequest($"Title must be a non-empty value! You entered: {payload.title}");
            }
            if (payload.rating == null || payload.rating== "")
            {
                return TypedResults.BadRequest($"Rating must be a non-empty value: You entered: {payload.rating}");
            }
            if (payload.description == null || payload.description== "")
            {
                return TypedResults.BadRequest($"Description must be a non-empty value! You entered: {payload.description}");
            }
            if (payload.runtime <= 0)
            {
                return TypedResults.BadRequest($"A movies runtime can not be less or equal to 0, you entered: {payload.runtime}");
            }

            var result = await movieRepository.createMovie(payload.title, payload.rating, payload.description, payload.runtime);
            if (result == null)
            {
                return TypedResults.BadRequest();
            }
            return TypedResults.Created("/movies", new MovieDataDTO(result, "success"));

        }
        private static async Task<IResult> UpdateMovie(int id, MoviePutPayload payload, IMovieRepository movieRepository)
        {
            if (payload.title == "")
            {
                return TypedResults.BadRequest("Updated title can not be of type empty");
            }
            if (payload.rating == "")
            {
                return TypedResults.BadRequest("Updated rating can not be of type empty");
            }
            if (payload.description == "")
            {
                return TypedResults.BadRequest("Updated description can not be of type empty");
            }
            if (payload.runtime <= 0)
            {
                return TypedResults.BadRequest("Updated runtime can not be 0 or less");
            }
            var result = await movieRepository.updateMovie(id, payload.title, payload.rating, payload.description, payload.runtime);
            if (result == null)
            {
                return TypedResults.BadRequest($"Internal error");
            }
            return TypedResults.Created($"/movies/{id}", new MovieDataDTO(result, "success"));


            throw new NotImplementedException();
        }
        private static async Task<IResult> DeleteMovie(int id, IMovieRepository movieRepository)
        {
            var result = await movieRepository.deleteMovie(id);
            if (result == null)
            {
                return TypedResults.NotFound($"Movie with given id {id} was not found");
            }
            return TypedResults.Ok(new MovieDataDTO(result, "success"));

        }


        private static async Task<IResult> CreateScreening(int movie_id, ScreeningPostPayload payload, IScreeningRepository screeningRepository)
        {
            var result = await screeningRepository.createScreening(movie_id, payload.screenNumber, payload.capacity, payload.startsAt);
            if ( result == null )
            {
                return TypedResults.NotFound($"Could not find movie with {movie_id}");
            }
            return TypedResults.Created($"/movies/{movie_id}/screenings" ,new ScreeningDataDTO(result, "success"));

        }

        private static async Task<IResult> GetScreeningByMovieId(int movie_id, IScreeningRepository screeningRepository)
        {
            var result = await screeningRepository.getScreeningByMovieId(movie_id);
            if (result == null)
            {
                return TypedResults.NotFound($"Movie with id {movie_id} has no screening");
            }
            return TypedResults.Ok(new ScreeningDataDTO(result, "success"));
        }
    }
}
