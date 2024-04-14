namespace ListaCalculatoare.Models
{
    public class ProdusRepsitory
    {
        private static List<Produs> _produs = new List<Produs>
        {
            new Produs{Id=1, Name="Laptop:ASUS", Categorie="Hardware",Pret=15000, Img="https://images.unsplash.com/photo-1496181133206-80ce9b88a853?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2071&q=80" },
            new Produs{Id=2, Name="Mouse", Categorie="Periferice",Pret=80, Img="https://images.unsplash.com/photo-1527814050087-3793815479db?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1928&q=80"},
            new Produs{Id=3, Name="Monitor", Categorie= "Periferice", Pret=400, Img="https://images.unsplash.com/photo-1570485071395-29b575ea3b4e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2080&q=80" },
            new Produs{Id=4, Name="Tastatura", Categorie= "Periferice", Pret=150, Img="https://images.unsplash.com/photo-1589578228447-e1a4e481c6c8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1932&q=80" },
            new Produs{Id=5, Name="All-In-One:Lenovo", Categorie="Hardware",Pret=25000, Img="https://images.unsplash.com/photo-1541807084-5c52b6b3adef?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1974&q=80" },
            new Produs{Id=6, Name="Laptop:Lenovo", Categorie="Hardware",Pret=18000, Img="https://images.unsplash.com/photo-1511385348-a52b4a160dc2?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2107&q=80" },
            new Produs{Id=7, Name="Laptop:Asus", Categorie="Hardware",Pret=15000, Img="https://plus.unsplash.com/premium_photo-1681702156223-ea59bfbf1065?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1935&q=80" },
            new Produs{Id=8, Name="Imprimanta", Categorie="Periferice",Pret=3000, Img="https://images.unsplash.com/photo-1650094980833-7373de26feb6?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1974&q=80" },
            new Produs{Id=9, Name="Laptop:HP", Categorie="Hardware",Pret=18000, Img="https://images.unsplash.com/photo-1615750173609-2fbf12fd1d2d?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2070&q=80" }
        };

        public static List<Produs> GetProduse()
        {
            return _produs;
        }
    }
}
