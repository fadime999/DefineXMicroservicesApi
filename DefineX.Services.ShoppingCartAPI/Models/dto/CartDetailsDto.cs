namespace DefineX.Services.ShoppingCartAPI.Models.dto
{
    public class CartDetailsDto
    {
        public int CartDetailsId { get; set; }
        public int CartHeaderId { get; set; }
        public virtual CartHeaderDto CartHeader { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Count { get; set; }
    }
}
