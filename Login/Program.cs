
namespace David
{
public class Persona
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string usuario { get; set; }
    public string contra { get; set; }

    public Persona(string _usuario,string _contra) // siempre se va a usar el "_" antes del parametro para reconocerlos facilmente. Acá no se deben imprimir las variables, debe ser en la clase principal
        {
        this.usuario = _usuario;
        this.contra = _contra;
       
        }
    public bool Validar (string _name, string _pass) // se deben crear parametros similares a los del otro metodo. para que se puedan comparar al ser digitados
        {
         bool result = false;
            if (this.usuario == _name && this.contra == _pass)
            {
                result = true;
            }
            return result;
        }


}

    public class Principal
    {
     public static void Main()
        {
            Persona usuario = new Persona("David", "1234");
            Console.WriteLine("Usuario: " +usuario.usuario);
            Console.WriteLine("Contraseña: " + usuario.contra); // se repite usuario porque es el metodo nuevo que se crea en la linea 24 donde se trae los vaores que se asignan a los atributos/metodos, deifinidos al inicio.

            string name = "", pass = "";
            do
            {
                Console.WriteLine("Digite usuario");
                name = Console.ReadLine();
                Console.WriteLine("Digite contraseña");
                pass = Console.ReadLine();
            } while (usuario.Validar(name, pass) == false);

            if (usuario.Validar (name, pass) == true) // evaluar si es necesario usar este condicinal, teniendo en cuenta que ya hay un do-while
            {
                Console.WriteLine("Bienvenido");
            }
          

       



        }
    }
}

/*
string[] usuario = new string[2];
string[] contrasena = new string[2];
string user = "";
string password = "";
string res = "";

for (int i = 0; i < 2 ; i++)
{
    Console.WriteLine("Ingrese un usuario");
    user = Console.ReadLine(); 
    usuario[i] = user;
    Console.WriteLine("Ingrese una contraseña");
    password= Console.ReadLine();
    contrasena[i] = password;
    Console.WriteLine("Desea ingresar al sistema ?");
    res = Console.ReadLine();

    if (res =="si")
    {
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Ingrese un usuario");
            user = Console.ReadLine();

            Console.WriteLine("Ingrese una contraseña");
            password = Console.ReadLine();
        }

    }

    
         
} */