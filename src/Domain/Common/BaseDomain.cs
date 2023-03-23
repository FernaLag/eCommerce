namespace Domain.Common
{
    public class BaseDomainEntity
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public string ModificadoPor { get; set; }

        public BaseDomainEntity()
        {
            Id = 0;
            CriadoEm = DateTime.Now;
            AtualizadoEm = DateTime.Now;
            ModificadoPor = string.Empty;
        }
    }
}