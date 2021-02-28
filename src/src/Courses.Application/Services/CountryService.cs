﻿using AutoMapper;
using Courses.Application.Services.Interfaces;
using Courses.Application.ViewModels;
using Courses.Domain.Interfaces.Notifications;
using Courses.Domain.Interfaces.Repositories;
using Courses.Domain.Models.Country;
using Courses.Domain.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Application.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;
        private readonly IDomainNotification _domainNotification;

        public CountryService(ICountryRepository countryRepository, IMapper mapper, IDomainNotification domainNotification)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
            _domainNotification = domainNotification;
        }

        public async Task<IEnumerable<CountryViewModel>> GetAllCountries()
        {
            var countries = await _countryRepository.FilterByAsync(c => true);

            return _mapper.Map<IEnumerable<CountryViewModel>>(countries.ToList());
        }

        public async Task<CountryViewModel> InsertOrUpdateCountry(CountryViewModel countryViewModel)
        {
            var model = _mapper.Map<Country>(countryViewModel);

            var validation = new CountryValidation().Validate(model);

            if (!validation.IsValid)
            {
                _domainNotification.AddNotifications(validation);
                return countryViewModel;
            }

            var country = await _countryRepository.FindOneAsync(c => c.CountryId == model.CountryId);

            if (country == null)
            {
                await _countryRepository.InsertOneAsync(model);
            }
            else
            {
                model.Id = country.Id;
                await _countryRepository.ReplaceOneAsync(model);
            }

            return countryViewModel;
        }
    }
}
