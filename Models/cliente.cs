namespace LHPet.models;

public class Cliente 
{
    public int Id {get;set;}
    public string? Nome { get; set;}
   public string? Cpf { get; set;}
   public string? Email { get; set;}
   public string? Paciente { get; set;}
    
    public Cliente( int id, string Nome,string Cpf, string Paciente)
    {
      this.Id = id;
      this.Nome = Nome;
      this.Cpf = Cpf;
      this.Email= Email;
      this.Paciente = Paciente;
      
    }
      
    }
