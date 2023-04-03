namespace AreaDeTestes
{
    public class Pokemon
    {   
        public string Nome {get ; set;}
        public string Tipo {get ; set;} 
        public int Nivel {get ; set;}  
        public int Vida {get ; set;}
        public double Experiencia {get ; set;}

        public Pokemon(){}
        public Pokemon(string nome, string tipo, int nivel, int vida, double experiencia)
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Nivel = nivel;
            this.Vida = vida;
            this.Experiencia = experiencia;
        }
    }
}