namespace ifoodconsole
{
    public class cliente
    {
        public string nome{get; set;}
        public string enderecoAtual{get; set;}

        //construtor
        public cliente (string nomeA){
            this.nome = nomeA;
        }

        //mostra dados na tela
        public string mostrarDados(){
            return$"Nome do cliente: {nome}\nEndereço atual:{enderecoAtual}.";
        }
    }
}