using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using MyWebApi.Data;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Repository
{
    public class YamRepository: IYamRepository
    {
        private readonly MyWebApiContext _context;
        private readonly IMapper _mapper;

        public YamRepository(MyWebApiContext context, IMapper mapper)
        {
           _context = context;
            _mapper = mapper;
        }

        public async Task<List<ConferencesModel>> GetAllConferencesAsync()
        {
            //var records =await  _context.Conferences.Select(x=> new ConferencesModel 
            //{ 
            //    ConferenceId=x.ConferenceId,
            //    Name=x.Name,
            //    StartDate=x.StartDate,
            //    EndDate=x.EndDate,
            //    Location=x.Location

            //}).ToListAsync();

            var records = await _context.Conferences.ToListAsync();
            return _mapper.Map<List<ConferencesModel>>(records);


            //return records;
        }

        public async Task<ConferencesModel> GetConferenceByIdAsync(int id)
        {
            //var records = await _context.Conferences.Where(x => x.ConferenceId == id).Select(x => new ConferencesModel
            //{
            //    ConferenceId = x.ConferenceId,
            //    Name = x.Name,
            //    StartDate = x.StartDate,
            //    EndDate = x.EndDate,
            //    Location = x.Location

            //}).FirstOrDefaultAsync();
            //return records;

            var conference = await _context.Conferences.FindAsync(id);
            return _mapper.Map<ConferencesModel>(conference);
        }

        public async Task<int> AddConferenceAsync(ConferencesModel conferencesModel)
        {
            var conference = new Conference()
            {
                Name = conferencesModel.Name,
                StartDate = conferencesModel.StartDate,
                EndDate = conferencesModel.EndDate,
                Location = conferencesModel.Location
            };
            _context.Conferences.Add(conference);
           await _context.SaveChangesAsync();

            return conference.ConferenceId;
        }


        public async Task UpdateConferenceAsync(int id, ConferencesModel conferencesModel)
        {
            //var conference=await _context.Conferences.FindAsync(id);
            //if (conference!=null)
            //{

            //    conference.Name = conferencesModel.Name;
            //    conference.StartDate = conferencesModel.StartDate;
            //    conference.EndDate = conferencesModel.EndDate;
            //    conference.Location = conferencesModel.Location;

            //}

            var conference = new Conference()
            {
                ConferenceId = id,
                Name = conferencesModel.Name,
                StartDate = conferencesModel.StartDate,
                EndDate = conferencesModel.EndDate,
                Location = conferencesModel.Location
            };
            _context.Conferences.Update(conference);


            await _context.SaveChangesAsync();

            
        }

        public async Task UpdateConferencePatchAsync(JsonPatchDocument conferencesModel, int id)
        { 
            var conference= await _context.Conferences.FindAsync(id);
            if (conference!=null)
            {
                conferencesModel.ApplyTo(conference);
                await _context.SaveChangesAsync();

            }
           
        }

        public async Task DeleteConferenceAsync(int id)
        {
            var conference = new Conference()
            {
                ConferenceId=id
            };
            _context.Conferences.Remove(conference);
            await _context.SaveChangesAsync();

            
        }

    }
}
