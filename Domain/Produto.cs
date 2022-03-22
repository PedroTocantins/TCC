public class Produto{

    //Entidade de produtos
    public Produto(){

    }
    public string Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public bool IsActive {get; set;}
    public string Category { get; set; }
    public int MyProperty { get; set; }
}