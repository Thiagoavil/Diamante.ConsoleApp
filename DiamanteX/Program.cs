using System;

namespace DiamanteX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int colunainc;
            int colunafin;
            int contador = 0;
            int metade = 0;


            Console.WriteLine("Diamante de X");
            Console.WriteLine("Digite um numero ímpar");
            numero = Convert.ToInt32(Console.ReadLine());



            colunainc = (numero -1)/ 2 ;
            colunafin = (numero -1) / 2 ;



            while (true)
            {
                
                if (metade == 0)


                {
                    
                    if (contador < colunainc || contador > colunafin)
                    {
                        
                        if (contador == numero)
                        {

                            if (contador == colunafin +1)
                            {
                                contador = 0;
                                metade++;
                                colunainc +=2;
                                colunafin -=2;
                                


                            }


                            contador = 0;
                            Console.WriteLine();
                            colunainc--;
                            colunafin++;
                           
                            continue;
                           
                        }
                        Console.Write(" ");





                    }
                    else
                    {
                        Console.Write("X");
                    }


                    
                    
                    

                }
                else
                {
                    if (contador < colunainc || contador > colunafin)
                    {

                        if (contador == numero)
                        {
                            contador = 0;
                            Console.WriteLine();
                            colunainc++;
                            colunafin--;
                            continue;
                        }
                        Console.Write(" ");


                      

                    }
                    else
                    {
                        Console.Write("X");
                    }
                    
                }
                if(colunafin == 1  && metade == 1 )
                {
                    break;
                }
                contador++;
                


            }


                

            }
        }
    }
