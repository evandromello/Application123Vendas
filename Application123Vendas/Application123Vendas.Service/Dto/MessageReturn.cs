namespace Application123Vendas.Service.Dto
{
    public class MessageReturn<T>
    {
        public string Message { get; set; }
        public T Dto { get; set; }

        public MessageReturn(string message, T dto)
        {
            Message = message;
            Dto = dto;
        }
    }
}
