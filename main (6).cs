using System;

class HelloWorld {
    static void Main() 
    {
      int operacoes = 1;
      string basico = "Simon Riley, conhecido como ghost, é atirador de elite britanico filiado a SAS, atualmente integra a força tarefa 141, opera usando uma máscara de caveira para esconder sua face";
      string patente = "tenente";
      string redeS = "@ghost_tf_141";
      char af1 = '1';
      char af2 = '4';
      char af3 = '1';
      
      
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();
         Console.WriteLine($"Acesso liberado para {nome}");
        Console.WriteLine("Informações militares confidenciais: Simon 'ghost' Riley");
        Console.WriteLine("Acessos permitidos");
        Console.WriteLine("-(1) N de operacoes,(2)identificacao social militar,(3) patente,(4) basico,(5) afiliacao");
        int acao = int.Parse(Console.ReadLine());
        
        if (acao != 1 && acao != 2 && acao != 3 && acao != 4 && acao != 5)
        {
             Console.WriteLine("Acesso negado. Inteligencia confidencial.");
        }
        
        else if (acao == 1)
        {
            int Noperacoes =  operacoes*33;
           Console.WriteLine($"Ghost ja participou de {Noperacoes} operacoes"); 
        }
        
        else if (acao == 2)
        {
          Console.WriteLine($"ids é a rede social militar usada pelo governo, ghost possui sua indicação como {redeS}."); 
          Console.WriteLine($"Ghost possui um total de 22 publicações digite o número da publicação que você deseja saber a quantidade de visualizações");
             float pub = float.Parse(Console.ReadLine());
             float numV = pub*54;
             Console.WriteLine($"Na publicacao {pub} ghost teve {numV} visualizações");
             int estimativa = 23*54;
              Console.WriteLine($"estima-se que na vigesima terceira pub, ghost tenha {estimativa} visualizações");
        }
        
      else if (acao == 3)
        {
           Console.WriteLine($"Atualmente, Ghost se ocupa um cargo de {patente}."); 
        }
        
         else if (acao == 4)
        {
           Console.WriteLine($"{basico}."); 
        }
        
        else if (acao == 5)
        {
           Console.WriteLine($"Atualmente, Ghost se afilia a força tarefa {af1}{af2}{af3}."); 
        }
     
    }
}