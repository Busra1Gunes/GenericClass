// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
GenericClass<C> a = new GenericClass<C>();
GenericClass<S> s = new GenericClass<S>(); //burda S hata verir çünkü T tip A veya A dan türeyen sınıf olmak zorundadır
class GenericClass<T> where T : A //where şartı T tipi A veya A'dan türeyen sınıfları temsil eder demektir yani A,A dan türeyen Byi C ve D'yi
    // where T : A   Bu komutlada T'nin sadece classları refere edebildiğini anlarız
{

}
class A
{

}
class B : A
{

}
class C : B
{

}
class D : C
{

}
class S
{

}
//Generic Class New Constraint 
class GeneriClass2<T> where T : new()  //new() kısıtlaması olmadan new T() ifadesini kullanamazsınız,
//çünkü derleyici T türünün parametresiz bir kurucuya sahip olup olmadığını bilemez ve bu durum derleme hatasına neden olur.
{
    public void X ()
    {
        T t1 = new T();
    }
}
class GeneriClass3<T> where T : class, new() //birden fazla şart aralarına virgül konularak yazılabilir, önce base class yazılır
{
    
}