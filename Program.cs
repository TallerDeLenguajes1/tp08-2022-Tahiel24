List<string>archivos=new List<string>();
List<string>nombres=new List<string>();
Console.WriteLine("Ingrese un directorio:");
string path=Console.ReadLine();


if(Directory.Exists(path)){
    archivos=Directory.GetFiles(path).ToList();
    foreach(string arc in archivos){
        Console.WriteLine(arc);
    }
}else{
    Console.WriteLine("El directorio ingresado no existe");
}

foreach(string directorios in archivos){
    nombres.Add(Path.GetFileName(directorios));
}


List<string>cadena=new List<string>();
for (int i = 0; i < nombres.Count; i++)
{
    int numero=i+1;
    cadena.Add(numero.ToString()+','+Path.GetFileNameWithoutExtension(nombres[i])+','+Path.GetExtension(nombres[i]));
}
File.WriteAllLines(path + @"/index.csv",cadena);

