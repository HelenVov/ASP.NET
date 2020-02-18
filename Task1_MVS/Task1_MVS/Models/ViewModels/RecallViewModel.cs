using System.Collections.Generic;

namespace Task1_MVC.Models.ViewModels
{
    public class RecallViewModel
    {
        public List<RecallDataViewModel> RecallDatas { get; set; }

        public RecallDataViewModel FormData { get; set; } = new RecallDataViewModel();
    }
}