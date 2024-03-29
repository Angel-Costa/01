﻿using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private SistemaContext context;
        
        public HotelRepository(SistemaContext context)
        {
            this.context = context;
        }

        public bool Alterar(Hotel hotel)
        {
            hotel.RegistroAtivo = true;
            context.Hoteis.Update(hotel);
            return context.SaveChanges() == 1;
        }

        public bool Apagar(int id)
        {
            var hotel = context.Hoteis.FirstOrDefault(y => y.Id == id);
            if (hotel == null)
                return false;

            hotel.RegistroAtivo = false;
            return context.SaveChanges() == 1;
        }

        public int Inserir(Hotel hotel)
        {
            hotel.RegistroAtivo = true;
            context.Hoteis.Add(hotel);
            context.SaveChanges();
            return hotel.Id;
        }

        public Hotel ObterPeloId(int id)
        {
            return context.Hoteis.FirstOrDefault(x => x.Id == id && x.RegistroAtivo);
        }

        public List<Hotel> ObterTodos()
        {
            return context.Hoteis
                .Where(x => x.RegistroAtivo).ToList().ToList();
        }
    }
}
