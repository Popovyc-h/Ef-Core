using homeworkFromTg.Base;

namespace homeworkFromTg.Entities;

internal class Character : BasePersonEntity
{
    public int Age { get; set; }
    public DateTime Birthday { get; set; }
    public decimal HeigthCm { get; set; }
    public decimal WeightKg { get; set; }
}