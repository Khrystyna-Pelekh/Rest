using Lab3.DataAccess;
using Lab3.Services.Extensions;
using Lab3.Services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using MachineConfigDto = Lab3.Services.Models.MachineConfig;
using MachineConfigEntity = Lab3.Entities.MachineConfig;


namespace Lab3.Services
{
    public class MachineConfigService : ServiceBase<MachineConfigDto, MachineConfigEntity>, IService<MachineConfigDto>
    {
        public MachineConfigService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        public IEnumerable<MachineConfigDto> Get()
        {
            return Repository.Get()
                .Include("Ingredient").Select(u => u.ToDto());
        }

        public MachineConfigDto Get(int id)
        {
            return Repository.Get(m=>m.Id==id)
                .Include("Ingredient").SingleOrDefault().ToDto();
        }

        public MachineConfigDto Create(MachineConfigDto machineConfigDto)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, PatchModel patchModel)
        {
            if (patchModel.Operation == "replace")
            {
                if (patchModel.Path == "/currentCapacity")
                {
                    var conf = Repository.Get(c => c.Id == id).Include("Ingredient").SingleOrDefault();
                    if (conf != null)
                    {
                        Int32.TryParse(patchModel.Value.ToString(), out int j);
                        if (conf.CurrentCapacity + j <= conf.MaxCapacity)
                        {
                            conf.CurrentCapacity += j;
                            UnitOfWork.SaveChanges();
                            return;
                        }
                        throw new Exception("Input value isn't correct");
                    }
                    throw new Exception("Id not found");
                }
            }
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public MachineConfigDto Copy(int id, MachineConfigDto orderDto)
        {
            throw new NotImplementedException();
        }
    }
}
