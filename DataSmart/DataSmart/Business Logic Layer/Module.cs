using DataSmart.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataSmart.Business_Logic_Layer
{
    class Module
    {
        DH_Module module = new DH_Module();
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


        public bool InsertMod(string code, string name, string description, string onlineres)
        {
            bool Success = module.InsertModule(code, name, description, onlineres);
            if (Success == true)
            {
                return true;
            }
            return false;
        }

        public bool UpdateModule(string modID, string modName, string modDesc)
        {
            bool Success = module.UpdateModuleInformation(modID, modName, modDesc);
            if (Success == true)
            {
                return true;
            }
            return false;
        }

        public bool ModDelete(string modulecode)
        {
            bool Success = module.DeleteModule(modulecode);
            if (Success == true)
            {
                return true;
            }
            return false;
        }

        public List<Module> DisplayAll()
        {
            Modules.AddRange(module.ReadAll());
            return Modules;
        }

        public List<Module> DisplaySearchedModule(string ModuleCode)
        {
            string FoundModule = module.ReadModule(ModuleCode);
            if (FoundModule != null)
            {
                string[] ModuleContent = FoundModule.Split('#');
                Modules.Add(new Module(ModuleContent[0], ModuleContent[1], ModuleContent[2], ModuleContent[3]));
                return Modules;
            }
            return null;
        }

        public int ValidationModule(string ModuleCode, string ModuleName, string ModuleDescription, string OnlineResources)
        {
            Regex codevalidation = new Regex("^[a-zA-Z0-9]*$");
            Regex stringvalidation = new Regex("^[A-Z][a-zA-Z]*$");

            bool isValidCode = codevalidation.IsMatch(ModuleCode);
            bool isValidName = stringvalidation.IsMatch(ModuleName);
            bool isValidDescription = stringvalidation.IsMatch(ModuleDescription);

            if (ModuleCode.Equals(null) || ModuleName.Equals(null) || ModuleDescription.Equals(null))
            {
                return 0;
            }
            if (ModuleCode.Length > 6 || ModuleCode.Length < 6 || ModuleName.Length > 30 || ModuleDescription.Length > 150 || OnlineResources.Length > 100)
            {
                return 1;
            }
            if (isValidCode && isValidName && isValidDescription)
            {
                return -1;
            }
            return 2;
        }

        public int DeleteValidation(string ModuleCode)
        {
            Regex codevalidation = new Regex("^[a-zA-Z0-9]*$");
            bool isValidCode = codevalidation.IsMatch(ModuleCode);
            if (ModuleCode.Equals(null))
            {
                return 0;
            }
            if (ModuleCode.Length > 6 || ModuleCode.Length < 6)
            {
                return 1;
            }
            if (isValidCode)
            {
                return -1;
            }
            return 2;
        }
    }
}
