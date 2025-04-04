using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp1.Models
{
    public class Credit
    {
        // ID кредита
        [DisplayName("ID кредита")]
        public virtual int CreditId { get; set; }

        // Название
        [DisplayName("Название кредита")]
        [Required(ErrorMessage = "Выберите тип кредита")]
        public virtual string Head { get; set; }

        // Период, на который выдается кредит
        [DisplayName("Период")]
        [Required(ErrorMessage = "Поле 'Период' обязательно для заполнения")]
        public virtual int Period { get; set; }

        // Максимальная сумма кредита
        [DisplayName("Максимальная сумма кредита")]
        public virtual int Sum { get; set; }

        // Процентная ставка
        [DisplayName("процентная ставка")]
        public virtual int Procent { get; set; }

    }
}