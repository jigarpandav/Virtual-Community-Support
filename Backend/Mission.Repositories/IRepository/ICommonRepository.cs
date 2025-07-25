﻿using Mission.Entities.ViewModels;

namespace Mission.Repositories.IRepository
{
    public interface ICommonRepository
    {
        List<DropDownResponseModel> CountryList();

        List<DropDownResponseModel> CityList(int countryId);

        List<DropDownResponseModel> MissionThemeList();

        List<DropDownResponseModel> MissionSkillList();

    }
}
