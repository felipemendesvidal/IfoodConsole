namespace ifoodconsole
{
    public class pedido
    {
        public string item;
        public string cliente;
        public string restaurante;
        public string formaDePagamento;
        public bool pedidoPago;

        public bool pagar(string valor){
            if(valor == "sim"){
                pedidoPago = true;
            }else{
                pedidoPago = false;    
            }
            return pedidoPago;
        }
    }
}