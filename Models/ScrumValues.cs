namespace ScumvaluesMini.Models
{
    public class ScrumValues
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool IsCheck { get; set; }
        public int score { get; set; }
        public class ValuesList
        {
            public List<ScrumValues> values { get; set; }
            //public int[] Score { get; set; }
            public int[] Score { get; set; }

        }

    }
}
