using System.ComponentModel.DataAnnotations;

namespace IntroAPI.ViewModel
{
    public class ProdViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string additionalInformation {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string externalCode {  get; set; }
    }
}
