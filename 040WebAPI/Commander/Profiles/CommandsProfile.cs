using AutoMapper;
using Commander.DTOs;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfiles : Profile
    {
        public CommandsProfiles()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}