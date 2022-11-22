﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuggestionAppLibrary.DataAccess
{
    public interface ICategoryData
    {
        Task CreateCategory(CategoryModel category);
        Task<List<CategoryModel>> GetAllCategories();
    }
}