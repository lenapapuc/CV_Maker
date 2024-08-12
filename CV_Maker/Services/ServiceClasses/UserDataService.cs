using CV_Maker.Data;
using CV_Maker.Services.Interfaces;
using DtoLibrary;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Domain;
namespace CV_Maker.Services.ServiceClasses
{
    public class UserDataService : IUserDataService
    {
        private readonly ApplicationDbContext _context;

        public UserDataService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(UserCreationDto user)
        {
            var databaseAddress = new Address
            {
                AddressLine = user.Address.AddressLine,
                AddressCity = user.Address.AddressCity,
                AddressCountry = user.Address.AddressCountry
            };

            var databaseUser = new UserInfo
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                MiddleName = user.MiddleName,
                PhoneNumber = user.PhoneNumber,
                Address = databaseAddress,
                BirthDate = user.BirthDate

            };

            try
            {
                _context.UsersInfo.Add(databaseUser);
                await _context.SaveChangesAsync();
                
            }
            catch(Exception ex)
            {
                throw new ApplicationException($"Internal service error: {ex.Message}");
            }
                   
        }
    }
}
