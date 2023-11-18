namespace APIChange.DTO
{
    public class ConversionDTO
    {
        public ConversionDTO(double euro, double dollar, double yen)
        {
            this.Euro = euro;
            this.Dollar = dollar;
            this.Yen = yen;
        }
        public double Euro { get; set; }
        public double Dollar { get; set; }
        public double Yen { get; set; }
    }
}
