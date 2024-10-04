public class Moto : Veiculo{
    private bool TemBagageiro;

    public Moto(string marca, string modelo, int ano, bool TemBagageiro):base(marca, modelo, ano){
        this.TemBagageiro = TemBagageiro;
    }

    public void DarGrau(){
        Console.WriteLine("RÃNDADNDANDANDANDANDANDAN PA PA PA PA AI QUEIMEI MINHA PERNA NO ESCAPAMENTO");
    }

    public void ExibirInformacoes(){
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano: {ano}");
    }
}

