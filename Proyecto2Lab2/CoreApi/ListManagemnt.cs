using DataAccess.Crud;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi
{
    public class ListManagemnt: BaseManagement
    {

        private Dictionary<string, List<OptionList>> dictionaryListOptions;


        public ListManagemnt()
        {
            LoadDictionary();
            
        }

        private void LoadDictionary()
        {
            

            //First we will get existing options from data base
            var crudList = new ListCrudFactory();
            var existingOptions = crudList.RetrieveAll<OptionList>();

            // We will crete a
            //now we will add the existing options to the dictionary



            //how to create a dictionary from a list
            //https://stackoverflow.com/questions/7614758/convert-listmyobject-to-dictionary-obj-string-listobj-id
            var dic = existingOptions
                .GroupBy(x => x.ID, x => x)
                .ToDictionary(x => x.Key, x => x.ToList());

            dictionaryListOptions = dic;
       
         

        }

        public List<OptionList> RetrieveById(OptionList option)
        {

            try
            {
                if (dictionaryListOptions.ContainsKey(option.ID))
                {
                    return dictionaryListOptions[option.ID];
                }

            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }

            return new List<OptionList>(); ;
        }


    }
}
