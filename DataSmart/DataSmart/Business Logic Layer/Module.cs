using DataSmart.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSmart.Business_Logic_Layer
{
    class Module
    {
        DH_WriteModifyModule writemod = new DH_WriteModifyModule();
        DH_ReadModule readmod = new DH_ReadModule();
        List<Module> Modules = new List<Module>();

        string ModuleCode;
        string ModuleName;
        string ModuleDescription;
        string OnlineResources;

        public Module() { }

        public Module(string moduleCode, string moduleName, string moduleDescription, string onlineResources)
        {
            ModuleCode1 = moduleCode;
            ModuleName1 = moduleName;
            ModuleDescription1 = moduleDescription;
            OnlineResources1 = onlineResources;
        }

        public string ModuleCode1 { get => ModuleCode; set => ModuleCode = value; }
        public string ModuleName1 { get => ModuleName; set => ModuleName = value; }
        public string ModuleDescription1 { get => ModuleDescription; set => ModuleDescription = value; }
        public string OnlineResources1 { get => OnlineResources; set => OnlineResources = value; }


        public string InsertMod(string code, string name, string description, string onlineres)
        {
            bool Success = writemod.InsertModule(code, name, description, onlineres);
            if (Success == true)
            {
                return "Module added successfully!";
            }
            return "Oops! Something went wrong";
        }

        public string UpdateDescription(string codeM, string Desc)
        {
            bool Success = writemod.UpdateModuleDescription(codeM, Desc);
            if (Success == true)
            {
                return "Module description has updated successfully!";
            }
            return "Oops! Something went wrong";
        }

        public string UpdateResources(string modC, string onR)
        {
            bool Success = writemod.UpdateModuleOnlineResources(modC, onR);
            if (Success == true)
            {
                return "Online Resources has updated successfully!";
            }
            return "Oops! Something went wrong";
        }

        public string ModDelete(string modulecode)
        {
            bool Success = writemod.DeleteModule(modulecode);
            if (Success == true)
            {
                return "Module has been deleted successfully!";
            }
            return "Oops! Something went wrong";
        }

        public List<Module> DisplayAll()
        {
            Modules = readmod.ReadAll();


        }
    }
}
