using System;



class persona {
	public string nombre;
	public string telefono;
	public string email;
	public string domicilio;
	
	
	
	public static  void Main(string[]args){
		persona informacion= new persona();
		Console.WriteLine ("dame el nombre");
		informacion.nombre = Console.ReadLine ();
		Console.WriteLine ("dame el telefono");
		informacion.telefono= Console.ReadLine ();
		Console.WriteLine ("dame el email");
		informacion.email= Console.ReadLine ();
		Console.WriteLine ("dame el domicilio");
		informacion.domicilio= Console.ReadLine ();
		
		
		
		
		
		
		
		Console.WriteLine ("nombre"+ informacion.nombre);
		Console.WriteLine ("telefono"+informacion.telefono);
		Console.WriteLine ("email"+informacion.email);
		Console.WriteLine ("domicilio"+informacion.domicilio);
		
	}
}















