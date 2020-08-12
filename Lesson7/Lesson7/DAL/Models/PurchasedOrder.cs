using System.ComponentModel.DataAnnotations;

namespace Lesson7.DAL.Models
{
    class PurchasedOrder
    {
        [Key]
        public int Id { get; set; }

        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public int Count { get; set; }

        public string DeliveryAddress { get; set; }
    }
}
