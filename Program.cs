namespace TRABALHO;

class Program
{
    static void Main(string[] args)
    
    {      // Declarando variáveis antes do laço
         Random numAleatorio = new Random(); // ->criando a função que vai sortear o número       
         int numSecreto = numAleatorio.Next(1,21);  // -> número que vai ser sorteado❌ ❔🎉➡️ 
         int numDigitado = 0 ; // -> número dado pelo usuário   ➡️❌❌
         int tentativas =0;          
         string tnovamente;
         string jnovamente;
         
         
        do 
        {  /* Laço encarregado de fazer o looping de jogar novamente funcionar, sua condição engloba todo o código, pois por mais que não seja a primeira
            ação, ela faz o controle e engloba toda a estrutura do código, pois se o jogador vai jogar sobre as mesmas consições basta ter algo que "force" o a voltar para
            o início de novo, por isso está desde o início até  o fim. 
          //----------------------------------------------------------------------------------------------------------------------------
          */
             do { 
                    // início do laço encarrecado de repitir o processo de imprimir a pergunta novamente caso o usuário digite algo > que 20 ou < que 1.
                    Console.WriteLine("Olá este é o jogo  Acerte O número! 🎮 "); // ->  Apresentando o jogo para o usuário
                    Console.WriteLine("O jogo se baseia em você digitar um número, depois vamos sortear um número secreto que você vai tentar acertar ");  // Apresentando o jogo para o usuário
                    Console.WriteLine("Digite um número de 1 a 20: ");  // -> Solicitando ao usuário o número; mensagem / pergunta.
                    numDigitado = int.Parse(Console.ReadLine()); // ->  lendo o número.
                    if ( numDigitado > 20 || numDigitado < 1) // ->  condição para a mensagem aparecer.
                    { 
                        Console.WriteLine("Opaa número inválido, digite novamente❌ "); // -> mensagem.
                    }
               }while( numDigitado > 20 || numDigitado < 1); //-> condição parao laço se iniciar ou finalizar
              //-----------------------------------------------------------------------------------------------------------------------------
                 /*
                 -> Looping encarrecado de repitir o processo de tentativas, aqui o programa, depois que o usuário responde 'S', faz
                 toda a verificaçaõ do numedoDigitado novamente.
                */
            do{ 
                /* Iniciando o looping de tentativas, aqui o usuário poderá tentar de novo, com base no mesmo número sorteado do início
                    Se digitar "N" ele irá sair, se "S"  o looping se iniciará, o programa tolera tanto letras maiúsculas, quanto minúsculas.
                 
                 */
                  Console.WriteLine("INFELIZMENTE NÃO FOI DESTA VEZ!");// -> mensagem.
                  if (numDigitado > numSecreto)  // -> se o numDigitado for maior numSecreto a dica/mensagem é exibida.
                   {
                      Console.WriteLine("Chute um pouco mais baixo 🔵."); // -> mensagem.
                   } 
                   else // -> se não, exiba essa  dica/mensagem.
                   { 
                      Console.WriteLine("Chute um pouco mais alto 🟡."); // -> mensagem.
                   } 
                  tentativas++;// -> aqui as tentativas comecam a ser contabilizadas, logo a cada vez que a mensagem acima for exibida se inicia uma e finaliza a  tentativa.

                  //.........................................................................................................
                 do {
                            /*Iniciando looping de validação da resposta do usuário, aqui se ele digitar algo dierente de "s" "n" recebe a mensagem de erro e 
                            a pergunta é feita de novo, até que tnovamente == "s" e == "n".
                            */
                                Console.WriteLine("Vamos tentar novamente? Digite S (para sim) ou N (para sair)➡️.");  //mensagem / pergunta.
                                tnovamente = Console.ReadLine().ToLower();  // -> lendo o o tnovamente + a tolerância do tipo da letra Maius/Minus.
                                if (tnovamente != "s" && tnovamente != "n") // -> condição para a mensagem ser exibida.
                                {
                                    Console.WriteLine("Opaa, escolha inválida ❌ , digite S (para sim) ou N (para sair) ➡️.");   
                                }
                            
                    }while (tnovamente != "s" && tnovamente != "n"); //-> condição parao laço se iniciar ou finalizar.
                        //.........................................................................................................
                           
                        if (tnovamente == "s") // -> condição para mensagem a tentativa ser repitida.
                        {  
                          do{  Console.WriteLine("Digite um número de 1 a 20: "); // ->  Solicitando ao usuário o número.
                               numDigitado = int.Parse(Console.ReadLine()); // -> lendo o número.

                             if ( numDigitado > 20 || numDigitado < 1) // ->  condição para a mensagem aparecer.
                                { 
                                    Console.WriteLine("Opaa número inválido, digite novamente❌ "); // -> mensagem.
                                }
                           }while( numDigitado > 20 || numDigitado < 1); //-> condição parao laço se iniciar ou finalizar

                            if ( numSecreto == numDigitado) // -> condição para a mensagem de acerto e fim do jogo aparecer: se numSecreto for igual numDigitado a mensagem é exibida.
                            {
                                Console.WriteLine("PARABÉNS, VOCÊ ACERTOU 🟢!"); // -> mensagem.
                                Console.WriteLine(" 🎮 FIM DE JOGO! 🎮"); // -> mensagem.
                                Console.WriteLine($"Chegamos ao fim! Você tentou {tentativas} tentativas, o número sorteado era: {numSecreto}"); // -> mensagem.
                                
                                break; // -> serve para quebrar o looping.
                            }
                           
                        }
                        else if (tnovamente == "n")  // -> condição para mensagem ser exibida.       
                           {
                              Console.WriteLine("Ok, obrigada por jogar,  responda a pergunta abaixo para sair!➡️"); // -> mensagem.
                               break; // ->  serve para quebrar o looping.
                           }
                   
                }while(numSecreto != numDigitado); // -> condição para o numDigitado ser comparado e assim as dicas aparecerem.
              //--------------------------------------------------------------------------------------------------------------------------------
                 
                
                do 
                { /*Laço para a validação do jnovamente, caso seja != de "s" e != de "n", a mensagem será repitida, juntamente com a pergunta até 
                   o usuário digitar um valor válido.
                  */ Console.WriteLine("Vamos riniciar o jogo ? Digite S (para sim) ou N (para sair)➡️."); //mensagem / pergunta.
                     jnovamente = Console.ReadLine().ToLower();  // -> lendo o o jnovamente + a tolerância do tipo da letra Maius/Minus. 
                   
                    if (jnovamente == "n") // -> condição para  mensagem exibida.          
                    {
                        Console.WriteLine("Ok, obrigada por jogar!"); //-> mensagem.
                      
                        break; //-> serve para quebrar o looping.
                       
                    }
                     if (jnovamente != "s" && tnovamente != "n") // -> condição para  mensagem ser exibida.
                    {
                        Console.WriteLine("Opaa, escolha inválida  ❌ , digite S (para sim) ou N (para sair)➡️."); // -> mensagem.
                        Console.WriteLine($"Chegamos ao fim! Você tentou {tentativas} tentativas, o número sorteado era: {numSecreto}"); // -> mensagem.  
                    }
                    tentativas++; // -> aqui as tentativas comecam a ser contabilizadas, logo a cada vez que a mensagem acima for exibida e respondida se inicia uma nova tentativa.
               } while (jnovamente != "s" && tnovamente != "n"); // -> condição parao laço se iniciar ou finalizar.
                
      //----------------------------------------------------------------------------------------------------------------------     
        } while (jnovamente == "s"); // -> condição parao laço se iniciar ou finalizar.
        Console.WriteLine($"Chegamos ao fim! Você tentou {tentativas} tentativas, o número sorteado era: {numSecreto}"); // -> mensagem.
          
       
       
        
         
            
        
                     
    }
    
}

                           

                    
                    
              
                   
         

                
             
            



