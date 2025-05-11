using System.ComponentModel.DataAnnotations;

namespace IntroAPI.ViewModel
{
    public class ProductViewModel
    {
        /// <summary>
        /// Maximum amount of products returned. Maximum value of 200
        /// </summary>
        [MaxLength (200)]
        [Required]
        public int limit {  get; set; }
        /// <summary>
        /// Product list page number
        /// </summary>
        [Required]
        public int page { get; set; }

    }
}
