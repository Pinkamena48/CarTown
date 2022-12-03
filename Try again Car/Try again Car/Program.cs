using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Try_again_Car
{
    public class Program
    {
        static void Main()
        {
            bool loop = false;
            string Inp;
            
            Make_a_car car1 = new Make_a_car();
            Make_a_car Toymodel1 = new Make_a_car();
            Make_a_car Toymodel2 = new Make_a_car();
            Make_a_car Toymodel3 = new Make_a_car();
            Make_a_car Toybodytype1 = new Make_a_car();
            Make_a_car Rammodel1 = new Make_a_car();
            Make_a_car Rammodel2 = new Make_a_car();
            Make_a_car Rambodytype1 = new Make_a_car();
            Make_a_car GMCmodel1 = new Make_a_car();
            Make_a_car GMCmodel2 = new Make_a_car();
            Make_a_car GMCmodel3 = new Make_a_car();
            Make_a_car GMCbodytype1 = new Make_a_car();
            Make_a_car Submodel1 = new Make_a_car();
            Make_a_car Submodel2 = new Make_a_car();
            Make_a_car Submodel3 = new Make_a_car();
            Make_a_car Subbodytype1 = new Make_a_car();
            Make_a_car Satmodel1 = new Make_a_car();
            Make_a_car Satmodel2 = new Make_a_car();
            Make_a_car Satmodel3 = new Make_a_car();
            Make_a_car Satbodytype1 = new Make_a_car();
            Make_a_car Ponmodel1 = new Make_a_car();
            Make_a_car Ponmodel2 = new Make_a_car();
            Make_a_car Ponmodel3 = new Make_a_car();
            Make_a_car Ponmodel4 = new Make_a_car();
            Make_a_car Ponbodytype1 = new Make_a_car();
            Make_a_car Nismodel1 = new Make_a_car();
            Make_a_car Nismodel2 = new Make_a_car();
            Make_a_car Nismodel3 = new Make_a_car();
            Make_a_car Nismodel4 = new Make_a_car();
            Make_a_car Nismodel5 = new Make_a_car();
            Make_a_car Nisbodytype1 = new Make_a_car();
            Make_a_car Nisbodytype2 = new Make_a_car();
            Make_a_car Jeemodel1 = new Make_a_car();
            Make_a_car Jeemodel2 = new Make_a_car();
            Make_a_car Jeebodytype1 = new Make_a_car();
            Make_a_car Hyumodel1 = new Make_a_car();
            Make_a_car Hyubodytype1 = new Make_a_car();
            Make_a_car Formodel1 = new Make_a_car();
            Make_a_car Formodel2 = new Make_a_car();
            Make_a_car Formodel3 = new Make_a_car();
            Make_a_car Forbodytype1 = new Make_a_car();
            Make_a_car Dodmodel1 = new Make_a_car();
            Make_a_car Dodmodel2 = new Make_a_car();
            Make_a_car Dodmodel3 = new Make_a_car();
            Make_a_car Dodmodel4 = new Make_a_car();
            Make_a_car Dodbodytype1 = new Make_a_car();
            Make_a_car Chemodel1 = new Make_a_car();
            Make_a_car Chemodel2 = new Make_a_car();
            Make_a_car Chebodytype1 = new Make_a_car();
            Make_a_car Cadmodel1 = new Make_a_car();
            Make_a_car Cadbodytype1 = new Make_a_car();
            Make_a_car Buimodel1 = new Make_a_car();
            Make_a_car Buimodel2 = new Make_a_car();
            Make_a_car Buibodytype1 = new Make_a_car();


            car1.Make = "\nToyota\nRam\nGMC\nSubaru\nSaturn\nPontiac\nNissan\nJeep\nHyundai\nFord\nDodge\nChevrolet\nCadillac\nBuick";
            Toymodel1.Model = "\n4Runner\nC-HR";
            Toymodel2.Model = "\n86";
            Toymodel3.Model = "\nAvalon\nAvalon Hybrid";
            Toybodytype1.Bodytype = "\nSUV\nSedan\nCoupe";
            Rammodel1.Model = "\n1500 Classic Crew Cab\n2500 Crew Cab\n3500 Crew Cab";
            Rammodel2.Model = "\nC/V\nProMaster Cargo Van";
            Rambodytype1.Bodytype = "\nTruck\nVan";
            GMCmodel1.Model = "\nAcadia\nAcadia Limited";
            GMCmodel2.Model = "\nCanyon Crew Cab\nCanyon Extended Cab";
            GMCmodel3.Model = "\nSavana 1500 Passenger";
            GMCbodytype1.Bodytype = "\nSUV\nTruck\nVan";
            Submodel1.Model = "\nAscent\nCrosstrek\nForester";
            Submodel2.Model = "\nBRZ";
            Submodel3.Model = "\nImpreza";
            Subbodytype1.Bodytype = "\nSUV\nCoupe\nWagon";
            Satmodel1.Model = "\nAura";
            Satmodel2.Model = "\nSKY";
            Satmodel3.Model = "\nVUE";
            Satbodytype1.Bodytype = "\nSedan\nConvertible\nSUV";
            Ponmodel1.Model = "\nTorrent";
            Ponmodel2.Model = "\nG5\nG6";
            Ponmodel3.Model = "\nG8";
            Ponmodel4.Model = "\nSolstice";
            Ponbodytype1.Bodytype = "\nSUV\nCoupe\nSedan\nConvertible";
            Nismodel1.Model = "\n350Z\n370Z";
            Nismodel2.Model = "\n370Z";
            Nismodel3.Model = "\nAltima";
            Nismodel4.Model = "\nQuest";
            Nismodel5.Model = "\ncube";
            Nisbodytype1.Bodytype = "\nConvertible\nCoupe\nSedan\nMinivan\nSUV";
            Nisbodytype2.Bodytype = "\nConvertible";
            Jeemodel1.Model = "\nCherokee\nCompass\nGrand Cherokee\nGrand Cherokee L";
            Jeemodel2.Model = "\nGladiator";
            Jeebodytype1.Bodytype = "\nSUV\nTruck";
            Hyumodel1.Model = "\nAccent\nAzera\nElantra\nElantra GT\nEquus";
            Hyubodytype1.Bodytype = "\nSedan";
            Formodel1.Model = "\nBronco\nBronco Sport";
            Formodel2.Model = "\nC-MAX Energi\nC-MAX Hybrid";
            Formodel3.Model = "\nCrown Victoria";
            Forbodytype1.Bodytype = "\nSUV\nWagon\nSedan";
            Dodmodel1.Model = "\nGrand Caravan Passenger";
            Dodmodel2.Model = "\nCaliber";
            Dodmodel3.Model = "\nChallenger";
            Dodmodel4.Model = "\nRam 1500 Crew Cab\nRam 1500 Quad Cab";
            Dodbodytype1.Bodytype = "\nMinivan\nWagon\nCoupe\nTruck";
            Chemodel1.Model = "\nAvalanche\nBlazer\nBolt EUV";
            Chemodel2.Model = "\nAveo\nBolt EV";
            Chebodytype1.Bodytype = "\nSUV\nHatchback";
            Cadmodel1.Model = "\nATS\nATS-V\nCT4\nCT5\nCT6";
            Cadbodytype1.Bodytype = "\nSedan";
            Buimodel1.Model = "\nCascada";
            Buimodel2.Model = "\nEnclave\nEncore\nEncore GX\nEnvision";
            Buibodytype1.Bodytype = "\nConvertible\nSUV";

 
            do
            {
                Console.WriteLine("Press (n/N) to exit program.");
                Console.WriteLine(car1.Make);
                
                Console.Write("\nChoose Make:");
                string choosemake = Console.ReadLine();
                if (choosemake == "Toyota" ||
                    choosemake == "Ram" ||
                    choosemake == "GMC" ||
                    choosemake == "Subaru" ||
                    choosemake == "Saturn" ||
                    choosemake == "Pontiac" ||
                    choosemake == "Nissan" ||
                    choosemake == "Jeep" ||
                    choosemake == "Hyundai" ||
                    choosemake == "Ford" ||
                    choosemake == "Dodge" ||
                    choosemake == "Chevrolet" ||
                    choosemake == "Cadillac" ||
                    choosemake == "Buick" ||
                    choosemake == "n" || 
                    choosemake == "N")
                    Console.Write("\nChoose Make:");
                {
                    
                    if (choosemake == "Toyota")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to search your Toyota by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Toybodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "SUV" || choosebody == "Coupe" || choosebody == "Sedan")
                                {
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(Toymodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "4Runner" || choosemodel == "C-HR")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                    AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }   
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Coupe")
                                    {
                                        Console.WriteLine(Toymodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "86")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionCoupe();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Sedan")
                                    {
                                        Console.WriteLine(Toymodel3.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Avalon" || choosemodel == "Avalon Hybrid")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSedan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }

                                }
                                if (choosebody != "SUV" && choosebody != "Coupe" && choosebody != "Sedan")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }


                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Toymodel1.Model + Toymodel2.Model + Toymodel3.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "4Runner" ||
                                    choosemodel == "C-HR" ||
                                    choosemodel == "Avalon" ||
                                    choosemodel == "Avalon Hybrid" ||
                                    choosemodel == "86")
                                {
                                    if (choosemodel == "4Runner" || choosemodel == "C-HR")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "86")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Coupe" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOTwo();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionCoupe();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Avalon" || choosemodel == "Avalon Hybrid")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Sedan" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSedan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }

                                }
                                if (choosemodel != "4Runner" &&
                                    choosemodel != "C-HR" &&
                                    choosemodel != "Avalon" &&
                                    choosemodel != "Avalon Hybrid" &&
                                    choosemodel != "86")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Ram")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to search your Ram by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Rambodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "Truck" || choosebody == "Van")
                                {
                                    if (choosebody == "Truck")
                                    {
                                        Console.WriteLine(Rammodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "1500 Classic Crew Cab" || choosemodel == "2500 Crew Cab" || choosemodel == "3500 Crew Cab")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionTruck();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Van")
                                    {
                                        Console.WriteLine(Rammodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "C/V" || choosemodel == "ProMaster Cargo Van")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            if (choosemodel == "ProMaster Cargo Van")
                                                            {
                                                                car1.DoorOThree();
                                                            }
                                                            else
                                                            {
                                                                car1.DoorOFour();
                                                            }
                                                                
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionVan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }


                                }
                                if (choosebody != "Truck" && choosebody != "Van")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Rammodel1.Model + Rammodel2.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "1500 Classic Crew Cab" ||
                                    choosemodel == "2500 Crew Cab" ||
                                    choosemodel == "3500 Crew Cab" ||
                                    choosemodel == "C/V" ||
                                    choosemodel == "ProMaster Cargo Van")
                                {
                                    if (choosemodel == "1500 Classic Crew Cab" || choosemodel == "2500 Crew Cab" || choosemodel == "3500 Crew Cab")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Truck" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionTruck();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "C/V" || choosemodel == "ProMaster Cargo Van")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Van" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        if (choosemodel == "ProMaster Cargo Van")
                                                        {
                                                            car1.DoorOThree();
                                                        }
                                                        else
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionVan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }


                                }
                                if (choosemodel != "1500 Classic Crew Cab" &&
                                    choosemodel != "2500 Crew Cab" &&
                                    choosemodel != "3500 Crew Cab" &&
                                    choosemodel != "C/V" &&
                                    choosemodel != "ProMaster Cargo Van")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "GMC")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your GMC by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Toybodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "SUV" || choosebody == "Truck" || choosebody == "Van")
                                {
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(GMCmodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Acadia" || choosemodel == "Acadia Limited")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Truck")
                                    {
                                        Console.WriteLine(GMCmodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Canyon Crew Cab" || choosemodel == "Canyon Extended Cab")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            if (choosemodel == "Canyon Extended Cab")
                                                            {
                                                                car1.DoorOTwo();
                                                            }
                                                            else
                                                            {
                                                                car1.DoorOFour();
                                                            }
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionTruck();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Van")
                                    {
                                        Console.WriteLine(GMCmodel3.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Savana 1500 Passenger")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOThree();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionVan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }

                                }
                                if (choosebody != "SUV" && choosebody != "Truck" && choosebody != "Van")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(GMCmodel1.Model + GMCmodel2.Model + GMCmodel3.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "Acadia" ||
                                    choosemodel == "Acadia Limited" ||
                                    choosemodel == "Canyon Crew Cab" ||
                                    choosemodel == "Canyon Extended Cab" ||
                                    choosemodel == "Savana 1500 Passenger")
                                {
                                    if (choosemodel == "Acadia" || choosemodel == "Acadia Limited")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Canyon Crew Cab" || choosemodel == "Canyon Extended Cab")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Truck" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        if (choosemodel == "Canyon Extended Cab")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        else
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionTruck();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Savana 1500 Passenger")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Van" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOThree();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionVan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }

                                }
                                if (choosemodel != "Acadia" &&
                                    choosemodel != "Acadia Limited" &&
                                    choosemodel != "Canyon Crew Cab" &&
                                    choosemodel != "Canyon Extended Cab" &&
                                    choosemodel != "Savana 1500 Passenger")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Subaru")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Subaru by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Subbodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "SUV" || choosebody == "Coupe" || choosebody == "Wagon")
                                {
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(Submodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Ascent" || choosemodel == "Crosstrek" || choosemodel == "Forester")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Coupe")
                                    {
                                        Console.WriteLine(Submodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "BRZ")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionCoupe();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Wagon")
                                    {
                                        Console.WriteLine(Submodel3.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Impreza")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionWagon();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }

                                }
                                if (choosebody != "SUV" && choosebody != "Coupe" && choosebody != "Wagon")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Submodel1.Model + Submodel2.Model + Submodel3.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "Ascent" ||
                                    choosemodel == "Crosstrek" ||
                                    choosemodel == "Forester" ||
                                    choosemodel == "BRZ" ||
                                    choosemodel == "Impreza")
                                {
                                    if (choosemodel == "Ascent" || choosemodel == "Crosstrek" || choosemodel == "Forester")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "BRZ")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Coupe" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionCoupe();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Impreza")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Wagon" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionWagon();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }

                                }
                                if (choosemodel != "Ascent" &&
                                    choosemodel != "Crosstrek" &&
                                    choosemodel != "Forester" &&
                                    choosemodel != "BRZ" &&
                                    choosemodel != "Impreza")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Saturn")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Saturn by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Satbodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "Sedan" || choosebody == "Convertible" || choosebody == "SUV")
                                {
                                    if (choosebody == "Sedan")
                                    {
                                        Console.WriteLine(Satmodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Aura")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSedan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Convertible")
                                    {
                                        Console.WriteLine(Satmodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "SKY")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionConvertible();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(Satmodel3.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "VUE")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }

                                }
                                if (choosebody != "Sedan" && choosebody != "Convertible" && choosebody != "SUV")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Satmodel1.Model + Satmodel2.Model + Satmodel3.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "Aura" ||
                                    choosemodel == "SKY" ||
                                    choosemodel == "VUE")

                                {
                                    if (choosemodel == "Aura")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Sedan" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSedan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "SKY")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Convertible" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOTwo();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionConvertible();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "VUE")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }

                                }
                                if (choosemodel != "Aura" &&
                                    choosemodel != "SKY" &&
                                    choosemodel != "VUE")

                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Pontiac")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Pontiac by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Ponbodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "Coupe" || choosebody == "Sedan" || choosebody == "Convertible" || choosebody == "SUV")
                                {
                                    if (choosebody == "Coupe")
                                    {
                                        Console.WriteLine(Ponmodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "G5" || choosemodel == "G6")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionCoupe();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Sedan")
                                    {
                                        Console.WriteLine(Ponmodel3.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "G8")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSedan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Convertible")
                                    {
                                        Console.WriteLine(Ponmodel4.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Solstice")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionConvertible();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(Ponmodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Torrent")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }
                                }
                                if (choosebody != "Coupe" && choosebody != "Sedan" && choosebody != "Convertible" && choosebody != "SUV")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Ponmodel1.Model + Ponmodel2.Model + Ponmodel3.Model + Ponmodel4.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "G5" ||
                                    choosemodel == "G6" ||
                                    choosemodel == "G8" ||
                                    choosemodel == "Solstice" ||
                                    choosemodel == "Torrent")
                                {
                                    if (choosemodel == "G5" || choosemodel == "G6")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Coupe" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOTwo();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionCoupe();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "G8")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Sedan" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSedan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Solstice")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Convertible" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOTwo();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionConvertible();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Torrent")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }

                                }
                                if (choosemodel != "G5" &&
                                   choosemodel != "G6" &&
                                   choosemodel != "G8" &&
                                   choosemodel != "Solstice" &&
                                   choosemodel != "Torrent")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Nissan")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Nissan by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Nisbodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "Convertible" || choosebody == "Coupe" || choosebody == "Sedan" || choosebody == "Minivan" || choosebody == "SUV")
                                {
                                    if (choosebody == "Convertible")
                                    {
                                        Console.WriteLine(Nismodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "350Z" || choosemodel == "370Z")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionConvertible();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Coupe")
                                    {
                                        Console.WriteLine(Nismodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "370Z")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionCoupe();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Sedan")
                                    {
                                        Console.WriteLine(Nismodel3.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Altima")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSedan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }
                                    if (choosebody == "Minivan")
                                    {
                                        Console.WriteLine(Nismodel4.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Quest")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionMinivan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(Nismodel5.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "cube")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }

                                }
                                if (choosebody != "Convertible" && choosebody != "Coupe" && choosebody != "Sedan" && choosebody != "Minivan" && choosebody != "SUV")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Nismodel1.Model + Nismodel3.Model + Nismodel4.Model + Nismodel5.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "350Z" ||
                                    choosemodel == "370Z" ||
                                    choosemodel == "Altima" ||
                                    choosemodel == "Quest" ||
                                    choosemodel == "cube")
                                {

                                    if (choosemodel == "350Z")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Convertible" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOTwo();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionConvertible();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "370Z")
                                    {
                                        Console.WriteLine("Please choose a bodytype for the 370Z:");
                                        Console.WriteLine("Your options are Convertible or Coupe");
                                        string choosebody = Console.ReadLine();
                                        if (choosebody == "Convertible")
                                        {
                                            Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Convertible" + "\n:O");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionConvertible();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                        if (choosebody == "Coupe")
                                        {
                                            Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Coupe" + "\n:O");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionCoupe();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }




                                    }
                                    if (choosemodel == "Altima")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Sedan" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSedan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Quest")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Minivan" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionMinivan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "cube")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }

                                }
                                if (choosemodel != "350Z" &&
                                    choosemodel != "370Z" &&
                                    choosemodel != "Altima" &&
                                    choosemodel != "Quest" &&
                                    choosemodel != "cube")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Jeep")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Jeep by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Jeebodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "SUV" || choosebody == "Truck")
                                {
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(Jeemodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Cherokee" || choosemodel == "Compass" || choosemodel == "Grand Cherokee" || choosemodel == "Grand Cherokee L")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Truck")
                                    {
                                        Console.WriteLine(Jeemodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Gladiator")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionTruck();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }


                                }
                                if (choosebody != "SUV" && choosebody != "Truck")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Jeemodel1.Model + Jeemodel2.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "Cherokee" ||
                                    choosemodel == "Compass" ||
                                    choosemodel == "Grand Cherokee" ||
                                    choosemodel == "Grand Cherokee L" ||
                                    choosemodel == "Gladiator")
                                {
                                    if (choosemodel == "Cherokee" || choosemodel == "Compass" || choosemodel == "Grand Cherokee" || choosemodel == "Grand Cherokee L")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Gladiator")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Truck" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionTruck();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }


                                }
                                if (choosemodel != "Cherokee" &&
                                    choosemodel != "Compass" &&
                                    choosemodel != "Grand Cherokee" &&
                                    choosemodel != "Grand Cherokee L" &&
                                    choosemodel != "Gladiator")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Hyundai")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Hyundai by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Hyubodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "Sedan")
                                {
                                    if (choosebody == "Sedan")
                                    {
                                        Console.WriteLine(Hyumodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Accent" || choosemodel == "Azera" || choosemodel == "Elantra" || choosemodel == "Elantra GT" || choosemodel == "Equus")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSedan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }


                                }
                                if (choosebody != "Sedan")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Hyumodel1.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "Accent" ||
                                    choosemodel == "Azera" ||
                                    choosemodel == "Elantra" ||
                                    choosemodel == "Elantra GT" ||
                                    choosemodel == "Equus")
                                {

                                    if (choosemodel == "Accent" || choosemodel == "Azera" || choosemodel == "Elantra" || choosemodel == "Elantra GT" || choosemodel == "Equus")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Sedan" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSedan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }

                                }
                                if (choosemodel != "Accent" &&
                                    choosemodel != "Azera" &&
                                    choosemodel != "Elantra" &&
                                    choosemodel != "Elantra GT" &&
                                    choosemodel != "Equus")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Ford")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Ford by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Forbodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "SUV" || choosebody == "Wagon" || choosebody == "Sedan")
                                {
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(Formodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Bronco" || choosemodel == "Bronco Sport")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            if (choosemodel == "Bronco")
                                                            {
                                                                car1.DoorOTwo();
                                                            }
                                                            else
                                                            {
                                                                car1.DoorOFour();
                                                            }
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Wagon")
                                    {
                                        Console.WriteLine(Formodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "C-MAX Energi" || choosemodel == "C-MAX Hybrid")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionWagon();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Sedan")
                                    {
                                        Console.WriteLine(Formodel3.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Crown Victoria")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSedan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }

                                }
                                if (choosebody != "SUV" && choosebody != "Wagon" && choosebody != "Sedan")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Formodel1.Model + Formodel2.Model + Formodel3.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "Bronco" ||
                                    choosemodel == "Bronco Sport" ||
                                    choosemodel == "C-MAX Energi" ||
                                    choosemodel == "C-MAX Hybrid" ||
                                    choosemodel == "Crown Victoria")
                                {
                                    if (choosemodel == "Bronco" || choosemodel == "Bronco Sport")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        if (choosemodel == "Canyon Extended Cab")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        else
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "C-MAX Energi" || choosemodel == "C-MAX Hybrid")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Wagon" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionWagon();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Crown Victoria")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Sedan" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSedan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }

                                }
                                if (choosemodel != "Bronco" &&
                                    choosemodel != "Bronco Sport" &&
                                    choosemodel != "C-MAX Energi" &&
                                    choosemodel != "C-MAX Hybrid" &&
                                    choosemodel != "Crown Victoria")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Dodge")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Dodge by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Dodbodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "Minivan" || choosebody == "Wagon" || choosebody == "Coupe" || choosebody == "Truck")
                                {
                                    if (choosebody == "Minivan")
                                    {
                                        Console.WriteLine(Dodmodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Grand Caravan Passenger")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionMinivan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Wagon")
                                    {
                                        Console.WriteLine(Dodmodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Caliber")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionWagon();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Coupe")
                                    {
                                        Console.WriteLine(Dodmodel3.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Challenger")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionCoupe();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }
                                    if (choosebody == "Truck")
                                    {
                                        Console.WriteLine(Dodmodel4.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Ram 1500 Crew Cab" || choosemodel == "Ram 1500 Quad Cab")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionTruck();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }

                                    }

                                }
                                if (choosebody != "Minivan" && choosebody != "Wagon" && choosebody != "Coupe" && choosebody != "Truck")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Dodmodel1.Model + Dodmodel2.Model + Dodmodel3.Model + Dodmodel4.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "Grand Caravan Passenger" ||
                                    choosemodel == "Caliber" ||
                                    choosemodel == "Challenger" ||
                                    choosemodel == "Ram 1500 Crew Cab" ||
                                    choosemodel == "Ram 1500 Quad Cab")
                                {
                                    if (choosemodel == "Grand Caravan Passenger")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Minivan" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionMinivan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Caliber")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Wagon" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionWagon();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Challenger")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Coupe" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOTwo();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionCoupe();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Ram 1500 Crew Cab" || choosemodel == "Ram 1500 Quad Cab")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Truck" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionTruck();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }

                                }
                                if (choosemodel != "Grand Caravan Passenger" &&
                                   choosemodel != "Caliber" &&
                                   choosemodel != "Challenger" &&
                                   choosemodel != "Ram 1500 Crew Cab" &&
                                   choosemodel != "Ram 1500 Quad Cab")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Chevrolet")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Chevrolet by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Chebodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "SUV" || choosebody == "Hatchback")
                                {
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(Chemodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Avalanche" || choosemodel == "Blazer" || choosemodel == "Bolt EUV")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "Hatchback")
                                    {
                                        Console.WriteLine(Chemodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Aveo" || choosemodel == "Bolt EV")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionHatchback();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    
                                    }


                                }
                                if (choosebody != "SUV" && choosebody != "Hatchback")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Chemodel1.Model + Chemodel2.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "Avalanche" ||
                                    choosemodel == "Aveo" ||
                                    choosemodel == "Blazer" ||
                                    choosemodel == "Bolt EUV" ||
                                    choosemodel == "Bolt EV")
                                {
                                    if (choosemodel == "Avalanche" || choosemodel == "Blazer" || choosemodel == "Bolt EUV")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Aveo" || choosemodel == "Bolt EV")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Hatchback" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionHatchback();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }


                                }
                                if (choosemodel != "Avalanche" &&
                                    choosemodel != "Aveo" &&
                                    choosemodel != "Blazer" &&
                                    choosemodel != "Bolt EUV" &&
                                    choosemodel != "Bolt EV")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Cadillac")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Cadillac by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Cadbodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "Sedan")
                                {
                                    if (choosebody == "Sedan")
                                    {
                                        Console.WriteLine(Cadmodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "ATS" || choosemodel == "ATS-V" || choosemodel == "CT4" || choosemodel == "CT5" || choosemodel == "CT6")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSedan();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }


                                }
                                if (choosebody != "Sedan")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Cadmodel1.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "ATS" ||
                                    choosemodel == "ATS-V" ||
                                    choosemodel == "CT4" ||
                                    choosemodel == "CT5" ||
                                    choosemodel == "CT6")
                                {

                                    if (choosemodel == "ATS" || choosemodel == "ATS-V" || choosemodel == "CT4" || choosemodel == "CT5" || choosemodel == "CT6")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Sedan" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSedan();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }


                                }
                                if (choosemodel != "ATS" &&
                                    choosemodel != "ATS-V" &&
                                    choosemodel != "CT4" &&
                                    choosemodel != "CT5" &&
                                    choosemodel != "CT6")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }
                    if (choosemake == "Buick")
                    {
                        Console.WriteLine("You chose:" + choosemake);
                        Console.WriteLine("Would you like to Search your Buick by its Bodytype or Model? :");
                        string Cmodelorbody = Console.ReadLine();
                        if (Cmodelorbody == "Bodytype")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Buibodytype1.Bodytype);
                                string choosebody = Console.ReadLine();
                                if (choosebody == "Convertible" || choosebody == "SUV")
                                {
                                    if (choosebody == "Convertible")
                                    {
                                        Console.WriteLine(Buimodel1.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Cascada")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOTwo();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionConvertible();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }
                                    if (choosebody == "SUV")
                                    {
                                        Console.WriteLine(Buimodel2.Model);
                                        Console.WriteLine("choose model:");
                                        string choosemodel = Console.ReadLine();
                                        if (choosemodel == "Enclave" || choosemodel == "Encore" || choosemodel == "Encore GX" || choosemodel == "Envision")
                                        {
                                            Console.WriteLine(":)\n" + choosecolor + choosemake + choosemodel + choosebody + "\n:)");
                                            Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                            Inp = Console.ReadLine();
                                            if (Inp.Equals("y") || Inp.Equals("Y"))
                                            {
                                                do
                                                {

                                                AB:
                                                    Console.WriteLine("Here are some details on your Vehicle");
                                                    Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                    Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                    Inp = Console.ReadLine();
                                                    if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                    {
                                                        if (Inp == "1")
                                                        {
                                                            car1.KeyOn();
                                                            car1.EngineOn();
                                                        AC:
                                                            Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                            Inp = Console.ReadLine();
                                                            if (Inp == "1" || Inp == "2" || Inp == "3")
                                                            {
                                                                if (Inp == "1")
                                                                {
                                                                    car1.MotionOn();
                                                                Abb:
                                                                    Console.WriteLine("[1] Keys [2] Breaks");
                                                                    Inp = Console.ReadLine();
                                                                    if (Inp == "1" || Inp == "2")
                                                                    {
                                                                        if (Inp == "1")
                                                                        {
                                                                            car1.KeyError();
                                                                            goto Abb;
                                                                        }
                                                                        if (Inp == "2")
                                                                        {
                                                                            car1.BreakOn();
                                                                            car1.MotionOff();
                                                                            goto AB;
                                                                        }
                                                                    }
                                                                }
                                                                if (Inp == "2")
                                                                {
                                                                    car1.KeyOff();
                                                                    car1.EngineOff();
                                                                    goto AB;
                                                                }
                                                                if (Inp == "3")
                                                                {
                                                                    car1.BreakOn();
                                                                    goto AC;
                                                                }

                                                            }

                                                        }
                                                        if (Inp == "2")
                                                        {
                                                            car1.Tires();
                                                        }
                                                        if (Inp == "3")
                                                        {
                                                            car1.DoorOFour();
                                                        }
                                                        if (Inp == "4")
                                                        {
                                                            car1.DescriptionSUV();
                                                        }
                                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                                        {
                                                            loop = true;
                                                        }
                                                    }
                                                } while (false == loop);
                                            }
                                            if (Inp.Equals("n") || Inp.Equals("N"))
                                            {
                                                loop = true;
                                            }
                                        }
                                    }


                                }
                                if (choosebody != "Convertible" && choosebody != "SUV")
                                {
                                    Console.WriteLine("Must choose a relivent bodytype shown");
                                }
                            }
                        }
                        if (Cmodelorbody == "Model")
                        {
                            Console.WriteLine("What color would you like your Vehicle to be?:");
                            Console.WriteLine("Our color options are Black, White, Red, Green, and Beige:");
                            string choosecolor = Console.ReadLine();
                            if (choosecolor == "Black" ||
                                choosecolor == "White" ||
                                choosecolor == "Red" ||
                                choosecolor == "Green" ||
                                choosecolor == "Beige")
                            {
                                Console.WriteLine(Buimodel1.Model + Buimodel2.Model);
                                string choosemodel = Console.ReadLine();
                                if (choosemodel == "Cascada" ||
                                    choosemodel == "Enclave" ||
                                    choosemodel == "Encore" ||
                                    choosemodel == "Encore GX" ||
                                    choosemodel == "Envision")
                                {
                                    if (choosemodel == "Cascada")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "Convertible" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOTwo();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionConvertible();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }
                                    if (choosemodel == "Enclave" || choosemodel == "Encore" || choosemodel == "Encore GX" || choosemodel == "Envision")
                                    {
                                        Console.WriteLine(":O\n" + choosecolor + choosemake + choosemodel + "SUV" + "\n:O");
                                        Console.WriteLine("Please enter (Y/N) to look at your new vehicle or to exit.");
                                        Inp = Console.ReadLine();
                                        if (Inp.Equals("y") || Inp.Equals("Y"))
                                        {
                                            do
                                            {

                                            AB:
                                                Console.WriteLine("Here are some details on your Vehicle");
                                                Console.WriteLine("Feel free to get to know your car a bit more. Press ( N/n ) at anytime to quit.");
                                                Console.WriteLine("[1] Keys [2] Tires [3] Doors [4] Description [n] Exit");
                                                Inp = Console.ReadLine();
                                                if (Inp == "1" || Inp == "2" || Inp == "3" || Inp == "4" || Inp == "n" || Inp == "N")
                                                {
                                                    if (Inp == "1")
                                                    {
                                                        car1.KeyOn();
                                                        car1.EngineOn();
                                                    AC:
                                                        Console.WriteLine("[1] Gas [2] Keys [3] Breaks");
                                                        Inp = Console.ReadLine();
                                                        if (Inp == "1" || Inp == "2" || Inp == "3")
                                                        {
                                                            if (Inp == "1")
                                                            {
                                                                car1.MotionOn();
                                                            Abb:
                                                                Console.WriteLine("[1] Keys [2] Breaks");
                                                                Inp = Console.ReadLine();
                                                                if (Inp == "1" || Inp == "2")
                                                                {
                                                                    if (Inp == "1")
                                                                    {
                                                                        car1.KeyError();
                                                                        goto Abb;
                                                                    }
                                                                    if (Inp == "2")
                                                                    {
                                                                        car1.BreakOn();
                                                                        car1.MotionOff();
                                                                        goto AB;
                                                                    }
                                                                }
                                                            }
                                                            if (Inp == "2")
                                                            {
                                                                car1.KeyOff();
                                                                car1.EngineOff();
                                                                goto AB;
                                                            }
                                                            if (Inp == "3")
                                                            {
                                                                car1.BreakOn();
                                                                goto AC;
                                                            }

                                                        }

                                                    }
                                                    if (Inp == "2")
                                                    {
                                                        car1.Tires();
                                                    }
                                                    if (Inp == "3")
                                                    {
                                                        car1.DoorOFour();
                                                    }
                                                    if (Inp == "4")
                                                    {
                                                        car1.DescriptionSUV();
                                                    }
                                                    if (Inp.Equals("n") || Inp.Equals("N"))
                                                    {
                                                        loop = true;
                                                    }
                                                }
                                            } while (false == loop);
                                        }
                                        if (Inp.Equals("n") || Inp.Equals("N"))
                                        {
                                            loop = true;
                                        }
                                    }


                                }
                                if (choosemodel != "Cascada" &&
                                    choosemodel != "Enclave" &&
                                    choosemodel != "Encore" &&
                                    choosemodel != "Encore GX" &&
                                    choosemodel != "Envision")
                                {
                                    Console.WriteLine("Must choose a relivant Model shown.");
                                }
                            }
                        }
                        if (Cmodelorbody != "Bodytype" && Cmodelorbody != "Model")
                        {
                            Console.WriteLine("Must choose between a Bodytype or a Model");
                        }

                    }

                }
                
                if (choosemake != "Toyota" &&
                    choosemake != "Ram" &&
                    choosemake != "GMC" &&
                    choosemake != "Subaru" &&
                    choosemake != "Saturn" &&
                    choosemake != "Pontiac" &&
                    choosemake != "Nissan" &&
                    choosemake != "Jeep" &&
                    choosemake != "Hyundai" &&
                    choosemake != "Ford" &&
                    choosemake != "Dodge" &&
                    choosemake != "Chevrolet" &&
                    choosemake != "Cadillac" &&
                    choosemake != "Buick")
                    
                {
                    Console.WriteLine("Make sure the make you chose was input correctly.");
                    
                }
                if (choosemake.Equals("n") || choosemake.Equals("N"))
                {
                    loop = true;
                }


            } while(false == loop);


        }




    }
}
