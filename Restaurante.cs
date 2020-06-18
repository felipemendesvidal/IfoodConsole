namespace ifoodconsole
{
    public class Restaurante
    {
        public string nomeFantasia {get; set;}
        public string endereco {get; set;}

        //construtor
        public Restaurante(string nomeEstabeleciomento){
            this.nomeFantasia = nomeEstabeleciomento;
        }

        //mostra os dados de endereço na tela
        public string mostrarDados(){
            return $"O endereço do restaurante é: {endereco}\nO nome fantasia é: {nomeFantasia}";
        }
    }
}