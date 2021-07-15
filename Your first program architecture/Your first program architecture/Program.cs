using System;

namespace Your_first_program_architecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bine ati venit!");
            Expressor expressor = new Expressor(false, 100, 100, 100, 100);

        start:


        cafea:
                if (expressor.NivelCafea < 30)
                {
                   Console.WriteLine("Nivelul de cafea din expressor nu este suficient. Tastati \"ok\" dupa ce introduceti cafeaua macinata");
                   if (Console.ReadLine() == "ok")
                   {
                      expressor.AdaugaCafea();
                   }
                   else
                   {
                       goto cafea;
                   }
                }

        apa:
                if (expressor.NivelApa < 30) {
                    Console.WriteLine("Nivelul de apa din expressor nu este suficient. Tastati \"ok\" dupa ce rezervorul este plin");
                    if (Console.ReadLine() == "ok")
                    {
                        expressor.AdaugaApa();
                    }else 
                    {   goto apa;
                    }
                }

        lapte:
            if (expressor.NivelLapte < 30)
            {
                Console.WriteLine("Nivelul de lapte din expressor nu este suficient. Tastati \"ok\" dupa ce rezervorul este plin");
                if (Console.ReadLine() == "ok")
                {
                    expressor.AdaugaLapte();
                }
                else
                {
                    goto lapte;
                }
            }


        cana:   
               
               if(expressor.Cana == true)
                {
                    nivelZahar:
                    Console.WriteLine("Selecteaza nivelul de zahar dorit : 0(fara zahar) - 5 (nivelul cel mai mare de zahar)");
                    string zahar = Console.ReadLine();
                    int zaharNivel = int.Parse(zahar);

                    if( zaharNivel >= 0 && zaharNivel <=5) {

                    if (expressor.NivelZahar < zaharNivel * 20)
                    {
                        Console.WriteLine("Nivelul de zahar din expressor nu este suficient.Tastati \"ok\" dupa ce rezervorul este plin");
                        if (Console.ReadLine() == "ok")
                        {
                            expressor.AdaugaZahar();
                            goto nivelZahar;
                        }
                        else
                        {
                            goto nivelZahar;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nivelul de zahar ales este " + zaharNivel + " .Tastati \"da\"  pentru continuare si altceva pentru a seta alt nivel de zahar");

                        if (Console.ReadLine() == "da")
                        {
                            expressor.NivelZahar = expressor.NivelZahar - zaharNivel * 20;

                        bautura:
                            Console.WriteLine("Alegeti o bautura! 1-Cafea , 2-LatteMacchiato , 3-Cappuccino , 4-Expresso");
                            int bauturaAleasa = int.Parse(Console.ReadLine());

                            if (bauturaAleasa >= 1 && bauturaAleasa <= 4)
                            {
                                Console.WriteLine("Bautura aleasa este " + bauturaAleasa + ". Daca doriti sa continuati tastati \"da\" , altfel tastati orice altceva");

                                if (Console.ReadLine() == "da")
                                {
                                    switch (bauturaAleasa)
                                    {
                                        case 1:
                                            Bautura Cafea = new Bautura(30,0);
                                            expressor.NivelCafea = expressor.NivelCafea - Cafea.NivelCafeaBautura;
                                            expressor.NivelLapte = expressor.NivelLapte - Cafea.NivelLapteBautura;
                                            expressor.NivelApa = expressor.NivelApa - 30;
                                            break;
                                        case 2:
                                            Bautura LatteMacchiato = new Bautura(10,30);
                                            expressor.NivelCafea = expressor.NivelCafea - LatteMacchiato.NivelCafeaBautura;
                                            expressor.NivelLapte = expressor.NivelLapte - LatteMacchiato.NivelLapteBautura;
                                            expressor.NivelApa = expressor.NivelApa - 30;
                                            break;
                                        case 3:

                                            Bautura Cappuccino = new Bautura(20,20);
                                            expressor.NivelCafea = expressor.NivelCafea - Cappuccino.NivelCafeaBautura;
                                            expressor.NivelLapte = expressor.NivelLapte - Cappuccino.NivelLapteBautura;
                                            expressor.NivelApa = expressor.NivelApa - 30;
                                            break;
                                        case 4:
                                            Bautura Espresso = new Bautura(25,0);
                                            expressor.NivelCafea = expressor.NivelCafea - Espresso.NivelCafeaBautura;
                                            expressor.NivelLapte = expressor.NivelLapte - Espresso.NivelLapteBautura;
                                            expressor.NivelApa = expressor.NivelApa - 30;
                                            break;

                                    }

                                    Console.WriteLine("Bautura se pregateste");
                                    Console.WriteLine("Bautura este gata. Scoateti cana!");
                                    expressor.ScoateCana();

                                    Console.WriteLine("Doriti o alta bautura ? Tastati \"ok\" pentru raspuns pozitiv si orice altceva daca raspunsul este negativ");
                                    if (Console.ReadLine() == "ok")
                                    {
                                        goto start;
                                    }
                                    else
                                    {
                                        Console.WriteLine("La revedere! O zi frumoasa!");
                                    }

                                }
                                else
                                {
                                    goto bautura;
                                }
                               
                                   
                            }
                            else
                            {
                                Console.WriteLine("Nu ati ales o bautura care se afla in meniul expressorului");
                                goto bautura;
                            }


                        }
                        else
                        {
                            goto nivelZahar;
                        }
                    
                        }

                    } else
                    {
                        Console.WriteLine("Nu ati introdus un nivel al zaharului permis de expressor");
                        goto nivelZahar;
                        
                    }
                }
                else
                {
                Console.WriteLine("Introdu cana si tastati \"ok\" dupa efectuarea comenzii");
                 if(Console.ReadLine() == "ok")
                {
                    expressor.AdaugaCana();
                    goto cana; //nu m-a lasat sa pun goto nivelZahar 
                }
                else
                {
                    goto cana;
                }

                }


        }
    }
}
