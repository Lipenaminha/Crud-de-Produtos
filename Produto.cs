





public class Produto {

    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public override string ToString() {
        return $"ID: {Id}, Nome: {Nome}, Preço: {Preco:C}, Quantidade: {Quantidade}";
    }


}