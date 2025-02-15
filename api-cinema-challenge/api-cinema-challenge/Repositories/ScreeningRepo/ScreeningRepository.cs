﻿using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Reposities.ScreeningRepo
{
    public class ScreeningRepository : IScreeningRepository
    {

        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Screening?> createScreening(int id, int screenNumber, int capacity, DateTime startsAt)
        {

            var movie = await _db.Movies.FindAsync(id);
            if (movie == null)
            {
                return null;
            }
            var screening = new Screening
            {
                ScreenNumber = screenNumber,
                Capacity = capacity,
                StartsAt = startsAt,
                movieId = id,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            _db.Screenings.Add(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public async Task<Screening?> getScreeningByMovieId(int id)
        {
            return await _db.Screenings.FirstOrDefaultAsync(m => m.movieId == id);
            //return await _db.Screenings.FindAsync(id);
        }

        public async Task<Screening?> getScreeningById(int id)
        {
            return await _db.Screenings.FindAsync(id);
        }
    }
}
