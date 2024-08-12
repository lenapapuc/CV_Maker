using DtoLibrary;
using Microsoft.AspNetCore.Mvc;

namespace CV_Maker.Services.Interfaces
{
    public interface IUserDataService
    {
        public Task AddUserAsync(UserCreationDto user);


    }
}
