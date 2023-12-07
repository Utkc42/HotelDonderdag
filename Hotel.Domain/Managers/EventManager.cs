﻿using Hotel.Domain.Interfaces;
using Hotel.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Managers
{
    public class EventManager
    {
        private readonly IEventRepository _eventRepository;

        public EventManager(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }


        public List<Event> GetEventsByOrganisorId(int id)
        {
           return _eventRepository.GetEventsByOrganisorId(id);
        }
    }
}
