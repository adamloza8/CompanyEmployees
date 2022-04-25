﻿using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyEmployees
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges);
        Task<Company> GetCompanyAsync (Guid companyId, bool trackChanges);
        void CreateCompany(Company company);
        Task <IEnumerable<Company>> GetByIdsAsync (IEnumerable<Guid> ids, bool trackChanges);
        void DeleteCompany(Company company);
    }
}