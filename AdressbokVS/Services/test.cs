using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressbokVS.Services
{
    internal class test
    {

        public void PopulatePersonList()
        {
            var content = FileService.Read();
            if (!string.IsNullOrEmpty(content))
                list = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(content)!;
        }


    }
}
