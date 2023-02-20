using Refit;
using SimpleUi.Models;

namespace SimpleUi.DataAccess
{
    public interface IGuestData
    {
        [Get("/Guest")]
        Task<List<GuestModel>> GetGuests();
        [Get("/Guest/{id}")]
        Task<GuestModel> GetGuest(int id );
        [Post("/Guest")]
        Task CreateGuests([Body] GuestModel guest );
        [Put("/Guest/{id}")]
        Task UpdateGuests(int id,[Body] GuestModel guest);
        [Delete("/Guest/{id}")]
        Task DeleteGuests(int id);
    }
}
