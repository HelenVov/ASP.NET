using System.Collections.Generic;

namespace Task1_MVS.Models.ViewModels
{
    public class RecallViewModel
    {
        public List<RecallData> RecallDatas { get; set; } = StaticRecallData.DataForms;

        public RecallData FormData { get; set; } = new RecallData();
    }
}