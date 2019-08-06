using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventsScreenProject.Models;
using EventsScreenProject.ViewModels;

namespace EventsScreenProject
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
           // CreateMap<Car, CarViewModel>().ReverseMap();

           CreateMap<EventField, EventFieldViewModel>()
               .ForMember(e => e.Name,
                   map => map.MapFrom(c => c.MyTemplateField.Name))
               .ForMember(e => e.FontColor,
                   map => map.MapFrom(c => c.MyTemplateField.FontColor))
               .ForMember(e => e.FontFamily,
                   map => map.MapFrom(c => c.MyTemplateField.FontFamily))
               .ForMember(e => e.FontSize,
                   map => map.MapFrom(c => c.MyTemplateField.FontSize))
               .ForMember(e => e.FontStyle,
                   map => map.MapFrom(c => c.MyTemplateField.FontStyle))
               .ForMember(e => e.FontWeight,
                   map => map.MapFrom(c => c.MyTemplateField.FontWeight))
               .ForMember(e => e.TopPosition,
                   map => map.MapFrom(c => c.MyTemplateField.TopPosition))
               .ForMember(e => e.LeftPosition,
                   map => map.MapFrom(c => c.MyTemplateField.LeftPosition));

           CreateMap<Event, EventViewModel>()
               .ForMember(e => e.Background,
                   map => map.MapFrom(c => c.MyTemplate.BackgroundImg))
               .ForMember(e => e.EventFieldViewModels,
                   map => map.MapFrom(c => c.EventFields));

        }
    }
}
