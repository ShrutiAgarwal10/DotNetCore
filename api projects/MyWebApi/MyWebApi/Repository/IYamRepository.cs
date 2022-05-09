using Microsoft.AspNetCore.JsonPatch;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Repository
{
    public interface IYamRepository
    {
        Task<List<ConferencesModel>> GetAllConferencesAsync();

        Task<ConferencesModel> GetConferenceByIdAsync(int id);

        Task<int> AddConferenceAsync(ConferencesModel conferencesModel);

        Task UpdateConferenceAsync(int id, ConferencesModel conferencesModel);

        Task UpdateConferencePatchAsync(JsonPatchDocument conferencesModel, int id);

        Task DeleteConferenceAsync(int id);
    }
}
